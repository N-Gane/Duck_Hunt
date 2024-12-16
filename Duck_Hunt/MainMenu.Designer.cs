namespace Duck_Hunt
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.startSingleplayerGameBtn = new System.Windows.Forms.Button();
            this.startMultiplayerGameBtn = new System.Windows.Forms.Button();
            this.quitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // startSingleplayerGameBtn
            // 
            this.startSingleplayerGameBtn.Location = new System.Drawing.Point(297, 210);
            this.startSingleplayerGameBtn.Name = "startSingleplayerGameBtn";
            this.startSingleplayerGameBtn.Size = new System.Drawing.Size(188, 23);
            this.startSingleplayerGameBtn.TabIndex = 0;
            this.startSingleplayerGameBtn.Text = "Игра на одного";
            this.startSingleplayerGameBtn.UseVisualStyleBackColor = true;
            this.startSingleplayerGameBtn.Click += new System.EventHandler(this.startSingleplayerGameBtn_Click);
            // 
            // startMultiplayerGameBtn
            // 
            this.startMultiplayerGameBtn.Location = new System.Drawing.Point(297, 261);
            this.startMultiplayerGameBtn.Name = "startMultiplayerGameBtn";
            this.startMultiplayerGameBtn.Size = new System.Drawing.Size(188, 23);
            this.startMultiplayerGameBtn.TabIndex = 1;
            this.startMultiplayerGameBtn.Text = "Игра на двоих";
            this.startMultiplayerGameBtn.UseVisualStyleBackColor = true;
            this.startMultiplayerGameBtn.Click += new System.EventHandler(this.startMultiplayerGameBtn_Click);
            // 
            // quitBtn
            // 
            this.quitBtn.Location = new System.Drawing.Point(297, 311);
            this.quitBtn.Name = "quitBtn";
            this.quitBtn.Size = new System.Drawing.Size(188, 23);
            this.quitBtn.TabIndex = 2;
            this.quitBtn.Text = "Выход";
            this.quitBtn.UseVisualStyleBackColor = true;
            this.quitBtn.Click += new System.EventHandler(this.quitBtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.quitBtn);
            this.Controls.Add(this.startMultiplayerGameBtn);
            this.Controls.Add(this.startSingleplayerGameBtn);
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button startSingleplayerGameBtn;
        private System.Windows.Forms.Button startMultiplayerGameBtn;
        private System.Windows.Forms.Button quitBtn;

    }
}