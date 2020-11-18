using System.Threading;
using UnityEditor;
using UnityEngine.Events;

/// <summary>
/// インポートの進度を表示
/// </summary>
public static class ImportProgress
{
    /// <summary>
    /// 進度
    /// </summary>
    public enum ProgressStatus
    {
        Preparing,
        Downloading,
        Converting,
        Finished,
        Error,
    }

    /// <summary>
    /// SynchronizationContext
    /// </summary>
    private static SynchronizationContext context;

    /// <summary>
    /// 初期化
    /// </summary>
    public static void Init()
    {
        context = SynchronizationContext.Current;
        UpdateStatus(ProgressStatus.Preparing);
    }

    public static void Post(UnityAction action)
    {
        context.Post(_ => action?.Invoke(), null);
    }

    /// <summary>
    /// 進度を更新
    /// </summary>
    public static void UpdateStatus(ProgressStatus status)
    {
        context.Post(_ =>
        {
            switch (status)
            {
                case ProgressStatus.Preparing:
                    EditorUtility.DisplayProgressBar("インポート中", "ファイル作成中...", 0.1f);
                    break;
                case ProgressStatus.Downloading:
                    EditorUtility.DisplayProgressBar("インポート中", "ファイルダウンロード中...", 0.4f);
                    break;
                case ProgressStatus.Converting:
                    EditorUtility.DisplayProgressBar("インポート中", "ファイル展開中...", 0.8f);
                    break;
                case ProgressStatus.Finished:
                case ProgressStatus.Error:
                    EditorUtility.ClearProgressBar();
                    break;
            }
        }, null);
    }
}