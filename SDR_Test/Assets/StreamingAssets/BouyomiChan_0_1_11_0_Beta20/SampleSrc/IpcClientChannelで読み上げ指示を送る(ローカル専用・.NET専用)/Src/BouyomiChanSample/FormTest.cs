using System;
using System.Text;
using System.Windows.Forms;
using System.Runtime.Remoting;
using FNF.Utility;

namespace BouyomiChanSample {
    public partial class FormTest : Form {

        //棒読みちゃんに接続するためのオブジェクト
        private BouyomiChanClient BouyomiChan;

        public FormTest() {
            InitializeComponent();

            //棒読みちゃんに接続
            BouyomiChan = new BouyomiChanClient();
        }

        private void FormTest_FormClosed(object sender, FormClosedEventArgs e) {
            //タイマ停止
            timerCheck.Stop();

            //棒読みちゃんへの接続を解除
            BouyomiChan.Dispose();
        }

        private void buttonAddText_Click(object sender, EventArgs e) {
            //テキストボックスに入力されている文章を読み上げる
            try {
                //BouyomiChan.AddTalkTask(textBoxMessage.Text);　←旧形式（タスクIDが必要ないならこちらでもOK）
                int taskId = BouyomiChan.AddTalkTask2(textBoxMessage.Text);
                labelAddTaskId.Text = "登録したタスクID：" + taskId.ToString();
            } catch (RemotingException) {
                MessageBox.Show("棒読みちゃんに接続できませんでした");
            }
        }

        private void buttonAddSample_Click(object sender, EventArgs e) {
            try {
                //棒読みちゃん側で選んでいる、声質・速さ・音量で読み上げる
                BouyomiChan.AddTalkTask("デフォルト1");

                //棒読みちゃん側で選んでいる、声質・速さ・音量で読み上げる(上記と同等)
                BouyomiChan.AddTalkTask("デフォルト2",  -1,  -1,  -1, VoiceType.Default);

                //声質(女性1)
                BouyomiChan.AddTalkTask("女性1",        -1,  -1,  -1, VoiceType.Female1);

                //声質(女性2)
                BouyomiChan.AddTalkTask("女性2",        -1,  -1,  -1, VoiceType.Female2);

                //声質(男性1)
                BouyomiChan.AddTalkTask("男性1",        -1,  -1,  -1, VoiceType.Male1);

                //声質(男性2)
                BouyomiChan.AddTalkTask("男性2",        -1,  -1,  -1, VoiceType.Male2);

                //声質(中性)
                BouyomiChan.AddTalkTask("中性",         -1,  -1,  -1, VoiceType.Imd1);

                //声質(ロボット)
                BouyomiChan.AddTalkTask("ロボット",     -1,  -1,  -1, VoiceType.Robot1);

                //声質(機械1)
                BouyomiChan.AddTalkTask("機械1",        -1,  -1,  -1, VoiceType.Machine1);

                //声質(機械2)
                BouyomiChan.AddTalkTask("機械2",        -1,  -1,  -1, VoiceType.Machine2);

                //速度（最低速）
                BouyomiChan.AddTalkTask("最低速度",     50,  -1,  -1, VoiceType.Default);

                //速度（通常）
                BouyomiChan.AddTalkTask("普通の速度",  100,  -1,  -1, VoiceType.Default);

                //速度（最高速）
                BouyomiChan.AddTalkTask("最高速度",    300,  -1,  -1, VoiceType.Default);

                //音程（最低）
                BouyomiChan.AddTalkTask("半分の周波数", -1,  50,  -1, VoiceType.Default);

                //音程（通常）
                BouyomiChan.AddTalkTask("普通の周波数", -1, 100,  -1, VoiceType.Default);

                //音程（最高）
                BouyomiChan.AddTalkTask("倍の周波数",   -1, 200,  -1, VoiceType.Default);

                //音量（小さめ）
                BouyomiChan.AddTalkTask("音量低め",     -1,  -1,  10, VoiceType.Default);

                //音量（中ぐらい）
                BouyomiChan.AddTalkTask("音量中ぐらい", -1,  -1,  50, VoiceType.Default);

                //音量（最大）
                BouyomiChan.AddTalkTask("音量最大",     -1,  -1, 100, VoiceType.Default);
            } catch (RemotingException) {
                MessageBox.Show("棒読みちゃんに接続できませんでした");
            }
        }

        private void buttonSkip_Click(object sender, EventArgs e) {
            try {
                BouyomiChan.SkipTalkTask();
            } catch {
            }
        }

        private void buttonClear_Click(object sender, EventArgs e) {
            try {
                BouyomiChan.ClearTalkTasks();
            } catch {
            }
        }

        private void buttonPause_Click(object sender, EventArgs e) {
            try {
                BouyomiChan.Pause = !BouyomiChan.Pause;
            } catch {
            }
        }

        private void timerCheck_Tick(object sender, EventArgs e) {
            try {
                buttonPause.Text        = BouyomiChan.Pause ? "棒読みちゃんはPause状態です" : "棒読みちゃんはPlay状態です";
                labelNowPlaying.Text    = BouyomiChan.NowPlaying ? "再生中" : "停止中";
                labelTalkTaskCount.Text = "再生待ち行数 : " + BouyomiChan.TalkTaskCount.ToString() + " 件";
                labelNowTaskId.Text     = "読み上げ中のタスクID：" + BouyomiChan.NowTaskId.ToString();
            } catch {
                buttonPause.Text = labelTalkTaskCount.Text = labelNowPlaying.Text = "接続できません";
            }
        }
    }
}