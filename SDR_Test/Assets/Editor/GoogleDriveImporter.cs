using System;
using UnityEditor;
using Google.Apis.Auth.OAuth2;
using Google.Apis.Drive.v3;
using Google.Apis.Services;
using Google.Apis.Download;
using Google.Apis.Util.Store;
using System.IO;
using System.Threading;

/// <summary>
/// GoogleDriveからファイルをインポート
/// </summary>
public static class GoogleDriveImporter
{
    /// <summary>
    /// GoogleDriveAPIの設定ファイル
    /// </summary>
    private static string CLIENT_SECRET_FILE = "./Assets/client_secret.json";

    /// <summary>
    /// GoogleDriveAPIの出力ファイル
    /// </summary>
    private static string CREDENTIAL_FILE = "./Assets/credential.json";

    /// <summary>
    /// GoogleDriveからインポート
    /// </summary>
    public static void Import(string fileID, string destPath, Action onComplete)
    {
        // スコープを設定
        string[] scopes = { DriveService.Scope.DriveReadonly };

        // 認証
        UserCredential credential;
        using (var stream = new FileStream(CLIENT_SECRET_FILE, FileMode.Open, FileAccess.Read))
        {
            credential = GoogleWebAuthorizationBroker.AuthorizeAsync(
                GoogleClientSecrets.Load(stream).Secrets,
                scopes,
                "user",
                CancellationToken.None,
                new FileDataStore(CREDENTIAL_FILE, true)).Result;
        }

        // GoogleDriveAPIに必要
        var service = new DriveService(new BaseClientService.Initializer()
        {
            HttpClientInitializer = credential,
            ApplicationName = "default name",
        });

        // ファイル取得
        var request = service.Files.Get(fileID);
        var output = new FileStream(destPath, FileMode.Create, FileAccess.Write);
        request.MediaDownloader.ProgressChanged += (IDownloadProgress progress) =>
        {
            switch (progress.Status)
            {
                case DownloadStatus.Completed:
                    {
                        // 成功
                        ImportProgress.UpdateStatus(ImportProgress.ProgressStatus.Converting);
                        ImportProgress.Post(() =>
                        {
                            AssetDatabase.ImportAsset(destPath);
                            AssetDatabase.SaveAssets();
                            AssetDatabase.Refresh();
                            output.Close();
                            onComplete?.Invoke();
                        });
                        break;
                    }
                case DownloadStatus.Failed:
                    {
                        // 失敗
                        UnityEngine.Debug.LogError("インポートに失敗しました: " + progress.Exception);
                        ImportProgress.UpdateStatus(ImportProgress.ProgressStatus.Error);
                        break;
                    }
            }
        };
        request.Download(output);
    }
}