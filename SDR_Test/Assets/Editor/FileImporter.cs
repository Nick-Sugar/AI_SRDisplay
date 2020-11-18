using System.Threading;
using System.Threading.Tasks;
using UnityEditor;
using UnityEngine;

/// <summary>
/// GoogleDriveからファイルをインポート
/// </summary>
public static class FileImporter
{
    /// <summary>
    /// インポート先
    /// </summary>
    private static string DESTINATION_PATH = "./Assets/test.json";

    /// <summary>
    /// GoogleDriveにある対象のファイルID
    /// </summary>
    private static string DRIVE_FILE_ID = "1Dy-0x9Q95dGDBgVfi-8hV6Lovvk5DqVI";

    /// <summary>
    /// インポートしたい時に呼び出す
    /// </summary>
    [MenuItem("Tools/GoogleDriveからインポート")]
    private static async void Import()
    {
        ImportProgress.Init();
        var context = SynchronizationContext.Current;
        await Task.Run(() =>
        {
            ImportProgress.UpdateStatus(ImportProgress.ProgressStatus.Downloading);
            context.Post(_ =>
            {
                GoogleDriveImporter.Import(DRIVE_FILE_ID, DESTINATION_PATH,
                    () => ImportProgress.UpdateStatus(ImportProgress.ProgressStatus.Finished));
            }, null);
        });
    }
}