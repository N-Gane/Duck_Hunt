namespace Duck_Hunt
{
    partial class Connection
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
            this.IPLabel = new System.Windows.Forms.Label();
            this.portLabel = new System.Windows.Forms.Label();
            this.ip_textbox = new System.Windows.Forms.TextBox();
            this.port_textbox = new System.Windows.Forms.TextBox();
            this.returnBtn = new System.Windows.Forms.Button();
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IPLabel
            // 
            this.IPLabel.AutoSize = true;
            this.IPLabel.Location = new System.Drawing.Point(264, 160);
            this.IPLabel.Name = "IPLabel";
            this.IPLabel.Size = new System.Drawing.Size(17, 13);
            this.IPLabel.TabIndex = 0;
            this.IPLabel.Text = "IP";
            // 
            // portLabel
            // 
            this.portLabel.AutoSize = true;
            this.portLabel.Location = new System.Drawing.Point(264, 253);
            this.portLabel.Name = "portLabel";
            this.portLabel.Size = new System.Drawing.Size(26, 13);
            this.portLabel.TabIndex = 1;
            this.portLabel.Text = "Port";
            // 
            // ip_textbox
            // 
            this.ip_textbox.Location = new System.Drawing.Point(267, 176);
            this.ip_textbox.Name = "ip_textbox";
            this.ip_textbox.Size = new System.Drawing.Size(214, 20);
            this.ip_textbox.TabIndex = 2;
            
            // 
            // port_textbox
            // 
            this.port_textbox.Location = new System.Drawing.Point(267, 269);
            this.port_textbox.Name = "port_textbox";
            this.port_textbox.Size = new System.Drawing.Size(214, 20);
            this.port_textbox.TabIndex = 3;
            // 
            // returnBtn
            // 
            this.returnBtn.Location = new System.Drawing.Point(267, 363);
            this.returnBtn.Name = "returnBtn";
            this.returnBtn.Size = new System.Drawing.Size(75, 23);
            this.returnBtn.TabIndex = 4;
            this.returnBtn.Text = "Вернуться";
            this.returnBtn.UseVisualStyleBackColor = true;
            this.returnBtn.Click += new System.EventHandler(this.returnBtn_Click);
            // 
            // btnChooseColor
            // 
            this.btnChooseColor.Location = new System.Drawing.Point(406, 363);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(75, 23);
            this.btnChooseColor.TabIndex = 5;
            this.btnChooseColor.Text = "Дальше";
            this.btnChooseColor.UseVisualStyleBackColor = true;
            this.btnChooseColor.Click += new System.EventHandler(this.btnChooseColor_Click_1);
            // 
            // Connection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChooseColor);
            this.Controls.Add(this.returnBtn);
            this.Controls.Add(this.port_textbox);
            this.Controls.Add(this.ip_textbox);
            this.Controls.Add(this.portLabel);
            this.Controls.Add(this.IPLabel);
            this.Name = "Connection";
            this.Text = "Connection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IPLabel;
        private System.Windows.Forms.Label portLabel;
        private System.Windows.Forms.TextBox ip_textbox;
        private System.Windows.Forms.TextBox port_textbox;
        private System.Windows.Forms.Button returnBtn;
        private System.Windows.Forms.Button btnChooseColor;
    }
}