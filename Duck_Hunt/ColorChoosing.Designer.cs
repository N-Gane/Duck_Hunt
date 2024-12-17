namespace Duck_Hunt
{
    partial class ColorChoosing
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
            this.lbColor = new System.Windows.Forms.Label();
            this.tbColor = new System.Windows.Forms.TextBox();
            this.chooseRedPlayerBtn = new System.Windows.Forms.Button();
            this.chooseBluePlayerBtn = new System.Windows.Forms.Button();
            this.returnBtn = new System.Windows.Forms.Button();
            this.connect_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbColor
            // 
            this.lbColor.AutoSize = true;
            this.lbColor.Location = new System.Drawing.Point(504, 224);
            this.lbColor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbColor.Name = "lbColor";
            this.lbColor.Size = new System.Drawing.Size(91, 16);
            this.lbColor.TabIndex = 0;
            this.lbColor.Text = "Выбери цвет";
            // 
            // tbColor
            // 
            this.tbColor.Enabled = false;
            this.tbColor.Location = new System.Drawing.Point(452, 244);
            this.tbColor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbColor.Name = "tbColor";
            this.tbColor.Size = new System.Drawing.Size(193, 22);
            this.tbColor.TabIndex = 32;
            // 
            // chooseRedPlayerBtn
            // 
            this.chooseRedPlayerBtn.BackColor = System.Drawing.Color.Brown;
            this.chooseRedPlayerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chooseRedPlayerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chooseRedPlayerBtn.Location = new System.Drawing.Point(452, 297);
            this.chooseRedPlayerBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chooseRedPlayerBtn.Name = "chooseRedPlayerBtn";
            this.chooseRedPlayerBtn.Size = new System.Drawing.Size(93, 86);
            this.chooseRedPlayerBtn.TabIndex = 33;
            this.chooseRedPlayerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.chooseRedPlayerBtn.UseVisualStyleBackColor = false;
            this.chooseRedPlayerBtn.Click += new System.EventHandler(this.chooseRedPlayerBtn_Click);
            // 
            // chooseBluePlayerBtn
            // 
            this.chooseBluePlayerBtn.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.chooseBluePlayerBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.chooseBluePlayerBtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.chooseBluePlayerBtn.Location = new System.Drawing.Point(553, 297);
            this.chooseBluePlayerBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chooseBluePlayerBtn.Name = "chooseBluePlayerBtn";
            this.chooseBluePlayerBtn.Size = new System.Drawing.Size(93, 86);
            this.chooseBluePlayerBtn.TabIndex = 34;
            this.chooseBluePlayerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.chooseBluePlayerBtn.UseVisualStyleBackColor = false;
            this.chooseBluePlayerBtn.Click += new System.EventHandler(this.chooseBluePlayerBtn_Click);
            // 
            // returnBtn
            // 
            this.returnBtn.BackColor = System.Drawing.Color.White;
            this.returnBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.returnBtn.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.returnBtn.ForeColor = System.Drawing.Color.White;
            this.returnBtn.Location = new System.Drawing.Point(365, 450);
            this.returnBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(180, 43);
            this.returnBtn.TabIndex = 35;
            this.returnBtn.Text = "Back";
            this.returnBtn.UseVisualStyleBackColor = false;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // connect_button
            // 
            this.connect_button.BackColor = System.Drawing.Color.White;
            this.connect_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.connect_button.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.connect_button.ForeColor = System.Drawing.Color.White;
            this.connect_button.Location = new System.Drawing.Point(553, 450);
            this.connect_button.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(180, 43);
            this.connect_button.TabIndex = 36;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = false;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // ColorChoosing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.chooseBluePlayerBtn);
            this.Controls.Add(this.chooseRedPlayerBtn);
            this.Controls.Add(this.tbColor);
            this.Controls.Add(this.lbColor);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "ColorChoosing";
            this.Text = "ColorChoosing";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbColor;
        private System.Windows.Forms.TextBox tbColor;
        public System.Windows.Forms.Button chooseRedPlayerBtn;
        public System.Windows.Forms.Button chooseBluePlayerBtn;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button connect_button;
    }
}