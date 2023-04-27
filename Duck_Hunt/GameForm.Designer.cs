namespace Duck_Hunt
{
    partial class GameForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameForm));
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.gLControl = new OpenTK.GLControl();
            this.label5 = new System.Windows.Forms.Label();
            this.panelLeft = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TypeBulletLeft = new System.Windows.Forms.Label();
            this.CountBulletLeft = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DownedDuksLeft = new System.Windows.Forms.Label();
            this.Play = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TypeBulletRight = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.CountBulletRight = new System.Windows.Forms.Label();
            this.DownedDuksRight = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.labelWin = new System.Windows.Forms.Label();
            this.panelRight = new System.Windows.Forms.Panel();
            this.glControl1 = new OpenTK.GLControl();
            this.panelLeft.SuspendLayout();
            this.panelRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 16;
            this.label1.Text = "label1";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(528, 359);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 52);
            this.button1.TabIndex = 17;
            this.button1.Text = "PLAY";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(1219, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(18, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "0";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // gLControl
            // 
            this.gLControl.BackColor = System.Drawing.Color.Transparent;
            this.gLControl.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gLControl.BackgroundImage")));
            this.gLControl.Location = new System.Drawing.Point(0, 0);
            this.gLControl.Name = "gLControl";
            this.gLControl.Size = new System.Drawing.Size(1264, 681);
            this.gLControl.TabIndex = 0;
            this.gLControl.VSync = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label5.Location = new System.Drawing.Point(1196, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 24);
            this.label5.TabIndex = 28;
            this.label5.Text = "0";
            // 
            // panelLeft
            // 
            this.panelLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(170)))), ((int)(((byte)(55)))));
            this.panelLeft.Controls.Add(this.label3);
            this.panelLeft.Controls.Add(this.label4);
            this.panelLeft.Controls.Add(this.TypeBulletLeft);
            this.panelLeft.Controls.Add(this.CountBulletLeft);
            this.panelLeft.Controls.Add(this.label6);
            this.panelLeft.Controls.Add(this.DownedDuksLeft);
            this.panelLeft.Location = new System.Drawing.Point(0, 621);
            this.panelLeft.Name = "panelLeft";
            this.panelLeft.Size = new System.Drawing.Size(458, 60);
            this.panelLeft.TabIndex = 25;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(170)))), ((int)(((byte)(55)))));
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(185, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 29);
            this.label3.TabIndex = 6;
            this.label3.Text = "Count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(170)))), ((int)(((byte)(55)))));
            this.label4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label4.Location = new System.Drawing.Point(-1, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(180, 29);
            this.label4.TabIndex = 3;
            this.label4.Text = "Type of bullet:";
            // 
            // TypeBulletLeft
            // 
            this.TypeBulletLeft.AutoSize = true;
            this.TypeBulletLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(170)))), ((int)(((byte)(55)))));
            this.TypeBulletLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TypeBulletLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeBulletLeft.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TypeBulletLeft.Location = new System.Drawing.Point(-1, 29);
            this.TypeBulletLeft.Name = "TypeBulletLeft";
            this.TypeBulletLeft.Size = new System.Drawing.Size(56, 29);
            this.TypeBulletLeft.TabIndex = 5;
            this.TypeBulletLeft.Text = "Null";
            // 
            // CountBulletLeft
            // 
            this.CountBulletLeft.AutoSize = true;
            this.CountBulletLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(170)))), ((int)(((byte)(55)))));
            this.CountBulletLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CountBulletLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountBulletLeft.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CountBulletLeft.Location = new System.Drawing.Point(185, 29);
            this.CountBulletLeft.Name = "CountBulletLeft";
            this.CountBulletLeft.Size = new System.Drawing.Size(56, 29);
            this.CountBulletLeft.TabIndex = 7;
            this.CountBulletLeft.Text = "Null";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(170)))), ((int)(((byte)(55)))));
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label6.Location = new System.Drawing.Point(279, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(178, 29);
            this.label6.TabIndex = 8;
            this.label6.Text = "Downed duks:";
            // 
            // DownedDuksLeft
            // 
            this.DownedDuksLeft.AutoSize = true;
            this.DownedDuksLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(170)))), ((int)(((byte)(55)))));
            this.DownedDuksLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownedDuksLeft.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DownedDuksLeft.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DownedDuksLeft.Location = new System.Drawing.Point(279, 29);
            this.DownedDuksLeft.Name = "DownedDuksLeft";
            this.DownedDuksLeft.Size = new System.Drawing.Size(26, 29);
            this.DownedDuksLeft.TabIndex = 9;
            this.DownedDuksLeft.Text = "0";
            // 
            // Play
            // 
            this.Play.BackColor = System.Drawing.Color.Transparent;
            this.Play.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Play.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Play.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.Play.FlatAppearance.BorderSize = 4;
            this.Play.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.Play.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.Play.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Play.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Play.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Play.Location = new System.Drawing.Point(527, 424);
            this.Play.Name = "Play";
            this.Play.Size = new System.Drawing.Size(218, 71);
            this.Play.TabIndex = 24;
            this.Play.Text = "Play";
            this.Play.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label7.Location = new System.Drawing.Point(13, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(109, 39);
            this.label7.TabIndex = 23;
            this.label7.Text = "label7";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(170)))), ((int)(((byte)(55)))));
            this.label10.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label10.Location = new System.Drawing.Point(280, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 29);
            this.label10.TabIndex = 10;
            this.label10.Text = "Type of bullet:";
            // 
            // TypeBulletRight
            // 
            this.TypeBulletRight.AutoSize = true;
            this.TypeBulletRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(170)))), ((int)(((byte)(55)))));
            this.TypeBulletRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.TypeBulletRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TypeBulletRight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TypeBulletRight.Location = new System.Drawing.Point(280, 29);
            this.TypeBulletRight.Name = "TypeBulletRight";
            this.TypeBulletRight.Size = new System.Drawing.Size(56, 29);
            this.TypeBulletRight.TabIndex = 11;
            this.TypeBulletRight.Text = "Null";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(170)))), ((int)(((byte)(55)))));
            this.label8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label8.Location = new System.Drawing.Point(189, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 29);
            this.label8.TabIndex = 12;
            this.label8.Text = "Count:";
            // 
            // CountBulletRight
            // 
            this.CountBulletRight.AutoSize = true;
            this.CountBulletRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(170)))), ((int)(((byte)(55)))));
            this.CountBulletRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CountBulletRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountBulletRight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.CountBulletRight.Location = new System.Drawing.Point(189, 29);
            this.CountBulletRight.Name = "CountBulletRight";
            this.CountBulletRight.Size = new System.Drawing.Size(56, 29);
            this.CountBulletRight.TabIndex = 13;
            this.CountBulletRight.Text = "Null";
            // 
            // DownedDuksRight
            // 
            this.DownedDuksRight.AutoSize = true;
            this.DownedDuksRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(170)))), ((int)(((byte)(55)))));
            this.DownedDuksRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DownedDuksRight.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DownedDuksRight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.DownedDuksRight.Location = new System.Drawing.Point(5, 29);
            this.DownedDuksRight.Name = "DownedDuksRight";
            this.DownedDuksRight.Size = new System.Drawing.Size(26, 29);
            this.DownedDuksRight.TabIndex = 15;
            this.DownedDuksRight.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(170)))), ((int)(((byte)(55)))));
            this.label9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label9.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label9.Location = new System.Drawing.Point(5, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 29);
            this.label9.TabIndex = 14;
            this.label9.Text = "Downed duks:";
            // 
            // labelWin
            // 
            this.labelWin.AutoSize = true;
            this.labelWin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelWin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelWin.Location = new System.Drawing.Point(416, 284);
            this.labelWin.Name = "labelWin";
            this.labelWin.Size = new System.Drawing.Size(132, 55);
            this.labelWin.TabIndex = 27;
            this.labelWin.Text = "none";
            // 
            // panelRight
            // 
            this.panelRight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(101)))), ((int)(((byte)(170)))), ((int)(((byte)(55)))));
            this.panelRight.Controls.Add(this.label10);
            this.panelRight.Controls.Add(this.TypeBulletRight);
            this.panelRight.Controls.Add(this.label8);
            this.panelRight.Controls.Add(this.CountBulletRight);
            this.panelRight.Controls.Add(this.DownedDuksRight);
            this.panelRight.Controls.Add(this.label9);
            this.panelRight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelRight.Location = new System.Drawing.Point(801, 621);
            this.panelRight.Name = "panelRight";
            this.panelRight.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.panelRight.Size = new System.Drawing.Size(463, 60);
            this.panelRight.TabIndex = 26;
            // 
            // glControl1
            // 
            this.glControl1.BackColor = System.Drawing.Color.Transparent;
            this.glControl1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("glControl1.BackgroundImage")));
            this.glControl1.Location = new System.Drawing.Point(0, 0);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(1264, 681);
            this.glControl1.TabIndex = 22;
            this.glControl1.VSync = false;
            // 
            // GameForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::Duck_Hunt.Properties.Resources.Start;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.panelLeft);
            this.Controls.Add(this.Play);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.labelWin);
            this.Controls.Add(this.panelRight);
            this.Controls.Add(this.glControl1);
            this.Controls.Add(this.gLControl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "GameForm";
            this.Text = "Dack Game";
            this.Load += new System.EventHandler(this.GameForm_Load);
            this.panelLeft.ResumeLayout(false);
            this.panelLeft.PerformLayout();
            this.panelRight.ResumeLayout(false);
            this.panelRight.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private OpenTK.GLControl gLControl;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panelLeft;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TypeBulletLeft;
        private System.Windows.Forms.Label CountBulletLeft;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label DownedDuksLeft;
        private System.Windows.Forms.Button Play;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label TypeBulletRight;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label CountBulletRight;
        private System.Windows.Forms.Label DownedDuksRight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelWin;
        private System.Windows.Forms.Panel panelRight;
        private OpenTK.GLControl glControl1;
    }
}

