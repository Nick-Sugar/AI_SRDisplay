namespace BouyomiChanSample {
    partial class FormTest {
        /// <summary>
        /// 必要なデザイナ変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースが破棄される場合 true、破棄されない場合は false です。</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナで生成されたコード

        /// <summary>
        /// デザイナ サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディタで変更しないでください。
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            this.textBoxMessage = new System.Windows.Forms.TextBox();
            this.buttonAddText = new System.Windows.Forms.Button();
            this.buttonAddSample = new System.Windows.Forms.Button();
            this.timerCheck = new System.Windows.Forms.Timer(this.components);
            this.labelTalkTaskCount = new System.Windows.Forms.Label();
            this.labelNowPlaying = new System.Windows.Forms.Label();
            this.buttonPause = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.buttonSkip = new System.Windows.Forms.Button();
            this.labelNowTaskId = new System.Windows.Forms.Label();
            this.labelAddTaskId = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBoxMessage
            // 
            this.textBoxMessage.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxMessage.Location = new System.Drawing.Point(14, 12);
            this.textBoxMessage.Multiline = true;
            this.textBoxMessage.Name = "textBoxMessage";
            this.textBoxMessage.Size = new System.Drawing.Size(307, 68);
            this.textBoxMessage.TabIndex = 0;
            // 
            // buttonAddText
            // 
            this.buttonAddText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddText.Location = new System.Drawing.Point(14, 86);
            this.buttonAddText.Name = "buttonAddText";
            this.buttonAddText.Size = new System.Drawing.Size(307, 23);
            this.buttonAddText.TabIndex = 1;
            this.buttonAddText.Text = "上の文章を棒読みちゃんに送信する";
            this.buttonAddText.UseVisualStyleBackColor = true;
            this.buttonAddText.Click += new System.EventHandler(this.buttonAddText_Click);
            // 
            // buttonAddSample
            // 
            this.buttonAddSample.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddSample.Location = new System.Drawing.Point(14, 114);
            this.buttonAddSample.Name = "buttonAddSample";
            this.buttonAddSample.Size = new System.Drawing.Size(307, 23);
            this.buttonAddSample.TabIndex = 2;
            this.buttonAddSample.Text = "サンプル文章を棒読みちゃんに送信する";
            this.buttonAddSample.UseVisualStyleBackColor = true;
            this.buttonAddSample.Click += new System.EventHandler(this.buttonAddSample_Click);
            // 
            // timerCheck
            // 
            this.timerCheck.Enabled = true;
            this.timerCheck.Interval = 500;
            this.timerCheck.Tick += new System.EventHandler(this.timerCheck_Tick);
            // 
            // labelTalkTaskCount
            // 
            this.labelTalkTaskCount.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTalkTaskCount.AutoSize = true;
            this.labelTalkTaskCount.Location = new System.Drawing.Point(12, 256);
            this.labelTalkTaskCount.Name = "labelTalkTaskCount";
            this.labelTalkTaskCount.Size = new System.Drawing.Size(11, 12);
            this.labelTalkTaskCount.TabIndex = 7;
            this.labelTalkTaskCount.Text = "-";
            // 
            // labelNowPlaying
            // 
            this.labelNowPlaying.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNowPlaying.AutoSize = true;
            this.labelNowPlaying.Location = new System.Drawing.Point(12, 233);
            this.labelNowPlaying.Name = "labelNowPlaying";
            this.labelNowPlaying.Size = new System.Drawing.Size(11, 12);
            this.labelNowPlaying.TabIndex = 6;
            this.labelNowPlaying.Text = "-";
            // 
            // buttonPause
            // 
            this.buttonPause.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonPause.Location = new System.Drawing.Point(14, 201);
            this.buttonPause.Name = "buttonPause";
            this.buttonPause.Size = new System.Drawing.Size(305, 23);
            this.buttonPause.TabIndex = 5;
            this.buttonPause.Text = "-";
            this.buttonPause.UseVisualStyleBackColor = true;
            this.buttonPause.Click += new System.EventHandler(this.buttonPause_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonClear.Location = new System.Drawing.Point(14, 172);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(305, 23);
            this.buttonClear.TabIndex = 4;
            this.buttonClear.Text = "全てのタスクをキャンセルする";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // buttonSkip
            // 
            this.buttonSkip.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSkip.Location = new System.Drawing.Point(14, 143);
            this.buttonSkip.Name = "buttonSkip";
            this.buttonSkip.Size = new System.Drawing.Size(305, 23);
            this.buttonSkip.TabIndex = 3;
            this.buttonSkip.Text = "現在の行の再生をやめ次の行へ移る";
            this.buttonSkip.UseVisualStyleBackColor = true;
            this.buttonSkip.Click += new System.EventHandler(this.buttonSkip_Click);
            // 
            // labelNowTaskId
            // 
            this.labelNowTaskId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelNowTaskId.AutoSize = true;
            this.labelNowTaskId.Location = new System.Drawing.Point(177, 256);
            this.labelNowTaskId.Name = "labelNowTaskId";
            this.labelNowTaskId.Size = new System.Drawing.Size(11, 12);
            this.labelNowTaskId.TabIndex = 8;
            this.labelNowTaskId.Text = "-";
            // 
            // labelAddTaskId
            // 
            this.labelAddTaskId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelAddTaskId.AutoSize = true;
            this.labelAddTaskId.Location = new System.Drawing.Point(177, 233);
            this.labelAddTaskId.Name = "labelAddTaskId";
            this.labelAddTaskId.Size = new System.Drawing.Size(11, 12);
            this.labelAddTaskId.TabIndex = 9;
            this.labelAddTaskId.Text = "-";
            // 
            // FormTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 278);
            this.Controls.Add(this.labelAddTaskId);
            this.Controls.Add(this.labelNowTaskId);
            this.Controls.Add(this.buttonSkip);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonPause);
            this.Controls.Add(this.labelNowPlaying);
            this.Controls.Add(this.labelTalkTaskCount);
            this.Controls.Add(this.buttonAddSample);
            this.Controls.Add(this.buttonAddText);
            this.Controls.Add(this.textBoxMessage);
            this.Name = "FormTest";
            this.Text = "棒読みちゃん テスト";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormTest_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxMessage;
        private System.Windows.Forms.Button buttonAddText;
        private System.Windows.Forms.Button buttonAddSample;
        private System.Windows.Forms.Timer timerCheck;
        private System.Windows.Forms.Label labelTalkTaskCount;
        private System.Windows.Forms.Label labelNowPlaying;
        private System.Windows.Forms.Button buttonPause;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Button buttonSkip;
        private System.Windows.Forms.Label labelNowTaskId;
        private System.Windows.Forms.Label labelAddTaskId;
    }
}

