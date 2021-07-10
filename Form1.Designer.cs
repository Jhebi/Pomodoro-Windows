
namespace Pomodoro_Windows
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.Quitbtn2 = new System.Windows.Forms.Button();
            this.Pause = new System.Windows.Forms.Button();
            this.Backbtn = new System.Windows.Forms.Button();
            this.Timer = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Quitbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Startbtn = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackgroundImage = global::Pomodoro_Windows.Properties.Resources.Red_Tomato;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Controls.Add(this.Quitbtn2);
            this.panel2.Controls.Add(this.Pause);
            this.panel2.Controls.Add(this.Backbtn);
            this.panel2.Controls.Add(this.Timer);
            this.panel2.Location = new System.Drawing.Point(12, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 231);
            this.panel2.TabIndex = 7;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            this.panel2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseMove);
            this.panel2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseUp);
            // 
            // Quitbtn2
            // 
            this.Quitbtn2.BackColor = System.Drawing.Color.Orange;
            this.Quitbtn2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Quitbtn2.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quitbtn2.Location = new System.Drawing.Point(173, 156);
            this.Quitbtn2.Name = "Quitbtn2";
            this.Quitbtn2.Size = new System.Drawing.Size(58, 23);
            this.Quitbtn2.TabIndex = 3;
            this.Quitbtn2.Text = "Quit";
            this.Quitbtn2.UseVisualStyleBackColor = false;
            this.Quitbtn2.Click += new System.EventHandler(this.Quitbtn2_Click);
            // 
            // Pause
            // 
            this.Pause.BackColor = System.Drawing.Color.Orange;
            this.Pause.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Pause.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Pause.Location = new System.Drawing.Point(109, 156);
            this.Pause.Name = "Pause";
            this.Pause.Size = new System.Drawing.Size(58, 23);
            this.Pause.TabIndex = 2;
            this.Pause.Text = "Start";
            this.Pause.UseVisualStyleBackColor = false;
            this.Pause.Click += new System.EventHandler(this.Pause_Click);
            // 
            // Backbtn
            // 
            this.Backbtn.BackColor = System.Drawing.Color.Orange;
            this.Backbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Backbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Backbtn.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.Location = new System.Drawing.Point(44, 156);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(59, 23);
            this.Backbtn.TabIndex = 1;
            this.Backbtn.Text = "Back";
            this.Backbtn.UseVisualStyleBackColor = false;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // Timer
            // 
            this.Timer.AutoSize = true;
            this.Timer.BackColor = System.Drawing.Color.White;
            this.Timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Timer.Location = new System.Drawing.Point(82, 103);
            this.Timer.Name = "Timer";
            this.Timer.Size = new System.Drawing.Size(117, 42);
            this.Timer.TabIndex = 0;
            this.Timer.Text = "00:00";
            this.Timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = global::Pomodoro_Windows.Properties.Resources.Gray_Tomato;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.numericUpDown1);
            this.panel1.Controls.Add(this.Quitbtn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Startbtn);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.numericUpDown2);
            this.panel1.Location = new System.Drawing.Point(291, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(273, 231);
            this.panel1.TabIndex = 6;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            this.panel1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseUp);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Increment = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown1.Location = new System.Drawing.Point(163, 106);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown1.TabIndex = 2;
            this.numericUpDown1.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // Quitbtn
            // 
            this.Quitbtn.BackColor = System.Drawing.Color.LightGray;
            this.Quitbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Quitbtn.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Quitbtn.Location = new System.Drawing.Point(152, 156);
            this.Quitbtn.Name = "Quitbtn";
            this.Quitbtn.Size = new System.Drawing.Size(75, 23);
            this.Quitbtn.TabIndex = 5;
            this.Quitbtn.Text = "Quit";
            this.Quitbtn.UseVisualStyleBackColor = false;
            this.Quitbtn.Click += new System.EventHandler(this.Quitbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Copperplate Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(69, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 14);
            this.label1.TabIndex = 0;
            this.label1.Text = "Work time";
            // 
            // Startbtn
            // 
            this.Startbtn.BackColor = System.Drawing.Color.LightGray;
            this.Startbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Startbtn.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Startbtn.Location = new System.Drawing.Point(54, 156);
            this.Startbtn.Name = "Startbtn";
            this.Startbtn.Size = new System.Drawing.Size(75, 23);
            this.Startbtn.TabIndex = 4;
            this.Startbtn.Text = "Start";
            this.Startbtn.UseVisualStyleBackColor = false;
            this.Startbtn.Click += new System.EventHandler(this.Startbtn_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Copperplate Gothic Light", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Rest Time";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(163, 128);
            this.numericUpDown2.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numericUpDown2.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(41, 20);
            this.numericUpDown2.TabIndex = 3;
            this.numericUpDown2.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(577, 255);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Pomodoro windows";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button Startbtn;
        private System.Windows.Forms.Button Quitbtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button Quitbtn2;
        private System.Windows.Forms.Button Pause;
        private System.Windows.Forms.Button Backbtn;
        private System.Windows.Forms.Label Timer;
    }
}

