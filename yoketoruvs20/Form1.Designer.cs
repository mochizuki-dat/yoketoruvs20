namespace yoketoruvs20
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.startbutton = new System.Windows.Forms.Button();
            this.clearLabel = new System.Windows.Forms.Label();
            this.copyLabel = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.leftLabel = new System.Windows.Forms.Label();
            this.hiLabel = new System.Windows.Forms.Label();
            this.TitleButton = new System.Windows.Forms.Button();
            this.gameOverLabel = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.tempLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("ＭＳ Ｐ明朝", 50F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.titleLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.titleLabel.Location = new System.Drawing.Point(279, 117);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(243, 67);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "よけとる";
            // 
            // startbutton
            // 
            this.startbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.startbutton.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.startbutton.Location = new System.Drawing.Point(291, 299);
            this.startbutton.Name = "startbutton";
            this.startbutton.Size = new System.Drawing.Size(213, 59);
            this.startbutton.TabIndex = 1;
            this.startbutton.Text = "スタート";
            this.startbutton.UseVisualStyleBackColor = false;
            this.startbutton.Click += new System.EventHandler(this.startbutton_Click);
            // 
            // clearLabel
            // 
            this.clearLabel.AutoSize = true;
            this.clearLabel.BackColor = System.Drawing.SystemColors.Control;
            this.clearLabel.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.clearLabel.ForeColor = System.Drawing.Color.Coral;
            this.clearLabel.Location = new System.Drawing.Point(275, 90);
            this.clearLabel.Name = "clearLabel";
            this.clearLabel.Size = new System.Drawing.Size(247, 94);
            this.clearLabel.TabIndex = 2;
            this.clearLabel.Text = "Clear";
            // 
            // copyLabel
            // 
            this.copyLabel.AutoSize = true;
            this.copyLabel.Font = new System.Drawing.Font("MS UI Gothic", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.copyLabel.Location = new System.Drawing.Point(581, 421);
            this.copyLabel.Name = "copyLabel";
            this.copyLabel.Size = new System.Drawing.Size(207, 20);
            this.copyLabel.TabIndex = 3;
            this.copyLabel.Text = "Copyrigth Ⓒ 2020 望月";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.timeLabel.Location = new System.Drawing.Point(12, 9);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(176, 40);
            this.timeLabel.TabIndex = 4;
            this.timeLabel.Text = "TIME 100";
            // 
            // leftLabel
            // 
            this.leftLabel.AutoSize = true;
            this.leftLabel.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.leftLabel.Location = new System.Drawing.Point(683, 9);
            this.leftLabel.Name = "leftLabel";
            this.leftLabel.Size = new System.Drawing.Size(105, 40);
            this.leftLabel.TabIndex = 5;
            this.leftLabel.Text = "★:10";
            // 
            // hiLabel
            // 
            this.hiLabel.AutoSize = true;
            this.hiLabel.Font = new System.Drawing.Font("MS UI Gothic", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.hiLabel.Location = new System.Drawing.Point(280, 213);
            this.hiLabel.Name = "hiLabel";
            this.hiLabel.Size = new System.Drawing.Size(241, 40);
            this.hiLabel.TabIndex = 6;
            this.hiLabel.Text = "ハイスコア 100";
            // 
            // TitleButton
            // 
            this.TitleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.TitleButton.Font = new System.Drawing.Font("MS UI Gothic", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.TitleButton.Location = new System.Drawing.Point(291, 299);
            this.TitleButton.Name = "TitleButton";
            this.TitleButton.Size = new System.Drawing.Size(213, 59);
            this.TitleButton.TabIndex = 7;
            this.TitleButton.Text = "タイトルへ";
            this.TitleButton.UseVisualStyleBackColor = false;
            this.TitleButton.Click += new System.EventHandler(this.TitleButton_Click);
            // 
            // gameOverLabel
            // 
            this.gameOverLabel.AutoSize = true;
            this.gameOverLabel.Font = new System.Drawing.Font("ＭＳ Ｐゴシック", 70F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.gameOverLabel.ForeColor = System.Drawing.Color.Crimson;
            this.gameOverLabel.Location = new System.Drawing.Point(158, 90);
            this.gameOverLabel.Name = "gameOverLabel";
            this.gameOverLabel.Size = new System.Drawing.Size(485, 94);
            this.gameOverLabel.TabIndex = 8;
            this.gameOverLabel.Text = "Game Over";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tempLabel.Location = new System.Drawing.Point(77, 215);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(47, 33);
            this.tempLabel.TabIndex = 9;
            this.tempLabel.Text = "★";
            this.tempLabel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 451);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.hiLabel);
            this.Controls.Add(this.leftLabel);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.copyLabel);
            this.Controls.Add(this.startbutton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.clearLabel);
            this.Controls.Add(this.gameOverLabel);
            this.Controls.Add(this.TitleButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button startbutton;
        private System.Windows.Forms.Label clearLabel;
        private System.Windows.Forms.Label copyLabel;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label leftLabel;
        private System.Windows.Forms.Label hiLabel;
        private System.Windows.Forms.Button TitleButton;
        private System.Windows.Forms.Label gameOverLabel;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label tempLabel;
    }
}

