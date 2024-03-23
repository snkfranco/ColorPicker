namespace ColorPicker
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Elipse2 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.TRACK_RED = new Guna.UI2.WinForms.Guna2TrackBar();
            this.TRACK_GREEN = new Guna.UI2.WinForms.Guna2TrackBar();
            this.TRACK_BLUE = new Guna.UI2.WinForms.Guna2TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.label4 = new System.Windows.Forms.Label();
            this.LBL_RED = new System.Windows.Forms.Label();
            this.LBL_GREEN = new System.Windows.Forms.Label();
            this.LBL_BLUE = new System.Windows.Forms.Label();
            this.LBL_RGB = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LBL_HEX = new System.Windows.Forms.Label();
            this.LBL_CopiedRGB = new System.Windows.Forms.Label();
            this.LBL_CopiedHEX = new System.Windows.Forms.Label();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 15;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2Panel1.Location = new System.Drawing.Point(586, 105);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(154, 218);
            this.guna2Panel1.TabIndex = 0;
            this.guna2Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.guna2Panel1_Paint);
            // 
            // guna2Elipse2
            // 
            this.guna2Elipse2.BorderRadius = 15;
            this.guna2Elipse2.TargetControl = this.guna2Panel1;
            // 
            // TRACK_RED
            // 
            this.TRACK_RED.Location = new System.Drawing.Point(53, 154);
            this.TRACK_RED.Maximum = 255;
            this.TRACK_RED.Name = "TRACK_RED";
            this.TRACK_RED.Size = new System.Drawing.Size(426, 23);
            this.TRACK_RED.TabIndex = 1;
            this.TRACK_RED.ThumbColor = System.Drawing.Color.Tomato;
            this.TRACK_RED.Value = 90;
            // 
            // TRACK_GREEN
            // 
            this.TRACK_GREEN.Location = new System.Drawing.Point(53, 199);
            this.TRACK_GREEN.Maximum = 255;
            this.TRACK_GREEN.Name = "TRACK_GREEN";
            this.TRACK_GREEN.Size = new System.Drawing.Size(426, 23);
            this.TRACK_GREEN.TabIndex = 2;
            this.TRACK_GREEN.ThumbColor = System.Drawing.Color.Green;
            // 
            // TRACK_BLUE
            // 
            this.TRACK_BLUE.Location = new System.Drawing.Point(53, 245);
            this.TRACK_BLUE.Maximum = 255;
            this.TRACK_BLUE.Name = "TRACK_BLUE";
            this.TRACK_BLUE.Size = new System.Drawing.Size(426, 23);
            this.TRACK_BLUE.TabIndex = 3;
            this.TRACK_BLUE.ThumbColor = System.Drawing.Color.SteelBlue;
            this.TRACK_BLUE.Value = 120;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label1.Location = new System.Drawing.Point(57, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Color Picker";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label2.Location = new System.Drawing.Point(101, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(116, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "by: eSieNiKa";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label4.Location = new System.Drawing.Point(765, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "X";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // LBL_RED
            // 
            this.LBL_RED.AutoSize = true;
            this.LBL_RED.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LBL_RED.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_RED.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.LBL_RED.Location = new System.Drawing.Point(493, 152);
            this.LBL_RED.Name = "LBL_RED";
            this.LBL_RED.Size = new System.Drawing.Size(22, 25);
            this.LBL_RED.TabIndex = 8;
            this.LBL_RED.Text = "0";
            this.LBL_RED.Click += new System.EventHandler(this.label5_Click);
            // 
            // LBL_GREEN
            // 
            this.LBL_GREEN.AutoSize = true;
            this.LBL_GREEN.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LBL_GREEN.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_GREEN.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.LBL_GREEN.Location = new System.Drawing.Point(493, 197);
            this.LBL_GREEN.Name = "LBL_GREEN";
            this.LBL_GREEN.Size = new System.Drawing.Size(22, 25);
            this.LBL_GREEN.TabIndex = 9;
            this.LBL_GREEN.Text = "0";
            // 
            // LBL_BLUE
            // 
            this.LBL_BLUE.AutoSize = true;
            this.LBL_BLUE.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LBL_BLUE.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_BLUE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.LBL_BLUE.Location = new System.Drawing.Point(493, 243);
            this.LBL_BLUE.Name = "LBL_BLUE";
            this.LBL_BLUE.Size = new System.Drawing.Size(22, 25);
            this.LBL_BLUE.TabIndex = 10;
            this.LBL_BLUE.Text = "0";
            // 
            // LBL_RGB
            // 
            this.LBL_RGB.AutoSize = true;
            this.LBL_RGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LBL_RGB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBL_RGB.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_RGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.LBL_RGB.Location = new System.Drawing.Point(110, 319);
            this.LBL_RGB.Name = "LBL_RGB";
            this.LBL_RGB.Size = new System.Drawing.Size(60, 25);
            this.LBL_RGB.TabIndex = 11;
            this.LBL_RGB.Text = "0; 0 ;0";
            this.LBL_RGB.Click += new System.EventHandler(this.LBL_RGB_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label5.Location = new System.Drawing.Point(53, 319);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "RGB:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label3.Location = new System.Drawing.Point(53, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 25);
            this.label3.TabIndex = 13;
            this.label3.Text = "HEX: ";
            // 
            // LBL_HEX
            // 
            this.LBL_HEX.AutoSize = true;
            this.LBL_HEX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LBL_HEX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LBL_HEX.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_HEX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.LBL_HEX.Location = new System.Drawing.Point(111, 356);
            this.LBL_HEX.Name = "LBL_HEX";
            this.LBL_HEX.Size = new System.Drawing.Size(60, 25);
            this.LBL_HEX.TabIndex = 14;
            this.LBL_HEX.Text = "0; 0 ;0";
            this.LBL_HEX.Click += new System.EventHandler(this.LBL_HEX_Click);
            // 
            // LBL_CopiedRGB
            // 
            this.LBL_CopiedRGB.AutoSize = true;
            this.LBL_CopiedRGB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LBL_CopiedRGB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CopiedRGB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.LBL_CopiedRGB.Location = new System.Drawing.Point(24, 322);
            this.LBL_CopiedRGB.Name = "LBL_CopiedRGB";
            this.LBL_CopiedRGB.Size = new System.Drawing.Size(0, 21);
            this.LBL_CopiedRGB.TabIndex = 15;
            // 
            // LBL_CopiedHEX
            // 
            this.LBL_CopiedHEX.AutoSize = true;
            this.LBL_CopiedHEX.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.LBL_CopiedHEX.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LBL_CopiedHEX.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.LBL_CopiedHEX.Location = new System.Drawing.Point(24, 359);
            this.LBL_CopiedHEX.Name = "LBL_CopiedHEX";
            this.LBL_CopiedHEX.Size = new System.Drawing.Size(0, 21);
            this.LBL_CopiedHEX.TabIndex = 16;
            // 
            // guna2ShadowForm1
            // 
            this.guna2ShadowForm1.BorderRadius = 15;
            this.guna2ShadowForm1.TargetForm = this;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(100)))), ((int)(((byte)(100)))));
            this.label6.Location = new System.Drawing.Point(595, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(132, 21);
            this.label6.TabIndex = 17;
            this.label6.Text = "Github: snkfranco";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.LBL_CopiedHEX);
            this.Controls.Add(this.LBL_CopiedRGB);
            this.Controls.Add(this.LBL_HEX);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LBL_RGB);
            this.Controls.Add(this.LBL_BLUE);
            this.Controls.Add(this.LBL_GREEN);
            this.Controls.Add(this.LBL_RED);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TRACK_BLUE);
            this.Controls.Add(this.TRACK_GREEN);
            this.Controls.Add(this.TRACK_RED);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Color Picker by: eSieNiKa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse2;
        private Guna.UI2.WinForms.Guna2TrackBar TRACK_BLUE;
        private Guna.UI2.WinForms.Guna2TrackBar TRACK_GREEN;
        private Guna.UI2.WinForms.Guna2TrackBar TRACK_RED;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LBL_RED;
        private System.Windows.Forms.Label LBL_BLUE;
        private System.Windows.Forms.Label LBL_GREEN;
        private System.Windows.Forms.Label LBL_RGB;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LBL_HEX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LBL_CopiedRGB;
        private System.Windows.Forms.Label LBL_CopiedHEX;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private System.Windows.Forms.Label label6;
    }
}

