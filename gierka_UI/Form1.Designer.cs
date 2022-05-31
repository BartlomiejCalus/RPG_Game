namespace gierka_UI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.hero_panel = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tarcza_check = new System.Windows.Forms.CheckBox();
            this.magia_check = new System.Windows.Forms.CheckBox();
            this.widzenie_Check = new System.Windows.Forms.CheckBox();
            this.Wiek_label = new System.Windows.Forms.Label();
            this.Waga_label = new System.Windows.Forms.Label();
            this.Wzrost_label = new System.Windows.Forms.Label();
            this.IMIE_label = new System.Windows.Forms.Label();
            this.Klasa_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.stats_panel = new System.Windows.Forms.Panel();
            this.AGIL_panel = new System.Windows.Forms.Panel();
            this.AGIL_label = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.POWER_panel = new System.Windows.Forms.Panel();
            this.POWER_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.INTEL_panel = new System.Windows.Forms.Panel();
            this.INTEL_label = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.HP_panel = new System.Windows.Forms.Panel();
            this.HP_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.action_panel = new System.Windows.Forms.Panel();
            this.Fab = new System.Windows.Forms.TextBox();
            this.answer_panel = new System.Windows.Forms.Panel();
            this.Action_2 = new System.Windows.Forms.Button();
            this.Acion_1 = new System.Windows.Forms.Button();
            this.LoadGAME_button = new System.Windows.Forms.Button();
            this.HERO_button = new System.Windows.Forms.Button();
            this.SATART_button = new System.Windows.Forms.Button();
            this.hero_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.stats_panel.SuspendLayout();
            this.AGIL_panel.SuspendLayout();
            this.POWER_panel.SuspendLayout();
            this.INTEL_panel.SuspendLayout();
            this.HP_panel.SuspendLayout();
            this.panel3.SuspendLayout();
            this.action_panel.SuspendLayout();
            this.answer_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // hero_panel
            // 
            this.hero_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.hero_panel.Controls.Add(this.checkBox1);
            this.hero_panel.Controls.Add(this.pictureBox1);
            this.hero_panel.Controls.Add(this.tarcza_check);
            this.hero_panel.Controls.Add(this.magia_check);
            this.hero_panel.Controls.Add(this.widzenie_Check);
            this.hero_panel.Controls.Add(this.Wiek_label);
            this.hero_panel.Controls.Add(this.Waga_label);
            this.hero_panel.Controls.Add(this.Wzrost_label);
            this.hero_panel.Controls.Add(this.IMIE_label);
            this.hero_panel.Controls.Add(this.Klasa_label);
            this.hero_panel.Controls.Add(this.label2);
            this.hero_panel.Dock = System.Windows.Forms.DockStyle.Right;
            this.hero_panel.Location = new System.Drawing.Point(600, 0);
            this.hero_panel.Name = "hero_panel";
            this.hero_panel.Size = new System.Drawing.Size(200, 450);
            this.hero_panel.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.checkBox1.Font = new System.Drawing.Font("Rockwell", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.checkBox1.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.checkBox1.Location = new System.Drawing.Point(3, 380);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(119, 42);
            this.checkBox1.TabIndex = 4;
            this.checkBox1.Text = "AUTO SAVE";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(11, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // tarcza_check
            // 
            this.tarcza_check.AutoSize = true;
            this.tarcza_check.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.tarcza_check.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.tarcza_check.Location = new System.Drawing.Point(11, 209);
            this.tarcza_check.Name = "tarcza_check";
            this.tarcza_check.Size = new System.Drawing.Size(58, 19);
            this.tarcza_check.TabIndex = 2;
            this.tarcza_check.Text = "Tarcza";
            this.tarcza_check.UseVisualStyleBackColor = false;
            // 
            // magia_check
            // 
            this.magia_check.AutoSize = true;
            this.magia_check.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.magia_check.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.magia_check.Location = new System.Drawing.Point(11, 184);
            this.magia_check.Name = "magia_check";
            this.magia_check.Size = new System.Drawing.Size(59, 19);
            this.magia_check.TabIndex = 2;
            this.magia_check.Text = "Magia";
            this.magia_check.UseVisualStyleBackColor = false;
            // 
            // widzenie_Check
            // 
            this.widzenie_Check.AutoSize = true;
            this.widzenie_Check.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.widzenie_Check.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.widzenie_Check.Location = new System.Drawing.Point(11, 159);
            this.widzenie_Check.Name = "widzenie_Check";
            this.widzenie_Check.Size = new System.Drawing.Size(143, 19);
            this.widzenie_Check.TabIndex = 2;
            this.widzenie_Check.Text = "Widzenie w ciemności";
            this.widzenie_Check.UseVisualStyleBackColor = false;
            // 
            // Wiek_label
            // 
            this.Wiek_label.AutoSize = true;
            this.Wiek_label.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Wiek_label.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Wiek_label.Location = new System.Drawing.Point(96, 78);
            this.Wiek_label.Name = "Wiek_label";
            this.Wiek_label.Size = new System.Drawing.Size(46, 19);
            this.Wiek_label.TabIndex = 1;
            this.Wiek_label.Text = "WIEK";
            this.Wiek_label.Click += new System.EventHandler(this.Klasa_label_Click);
            // 
            // Waga_label
            // 
            this.Waga_label.AutoSize = true;
            this.Waga_label.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Waga_label.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Waga_label.Location = new System.Drawing.Point(96, 59);
            this.Waga_label.Name = "Waga_label";
            this.Waga_label.Size = new System.Drawing.Size(59, 19);
            this.Waga_label.TabIndex = 1;
            this.Waga_label.Text = "WAGA";
            this.Waga_label.Click += new System.EventHandler(this.Klasa_label_Click);
            // 
            // Wzrost_label
            // 
            this.Wzrost_label.AutoSize = true;
            this.Wzrost_label.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Wzrost_label.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Wzrost_label.Location = new System.Drawing.Point(96, 40);
            this.Wzrost_label.Name = "Wzrost_label";
            this.Wzrost_label.Size = new System.Drawing.Size(67, 19);
            this.Wzrost_label.TabIndex = 1;
            this.Wzrost_label.Text = "WZROST";
            this.Wzrost_label.Click += new System.EventHandler(this.Klasa_label_Click);
            // 
            // IMIE_label
            // 
            this.IMIE_label.AutoSize = true;
            this.IMIE_label.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.IMIE_label.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.IMIE_label.Location = new System.Drawing.Point(96, 21);
            this.IMIE_label.Name = "IMIE_label";
            this.IMIE_label.Size = new System.Drawing.Size(37, 19);
            this.IMIE_label.TabIndex = 1;
            this.IMIE_label.Text = "IMIE";
            this.IMIE_label.Click += new System.EventHandler(this.Klasa_label_Click);
            // 
            // Klasa_label
            // 
            this.Klasa_label.AutoSize = true;
            this.Klasa_label.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Klasa_label.Font = new System.Drawing.Font("Poor Richard", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Klasa_label.Location = new System.Drawing.Point(6, 122);
            this.Klasa_label.Name = "Klasa_label";
            this.Klasa_label.Size = new System.Drawing.Size(58, 19);
            this.Klasa_label.TabIndex = 1;
            this.Klasa_label.Text = "KLASA";
            this.Klasa_label.Click += new System.EventHandler(this.Klasa_label_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(52, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "label2";
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Poor Richard", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exit_button.Location = new System.Drawing.Point(542, 4);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(50, 20);
            this.exit_button.TabIndex = 5;
            this.exit_button.Text = "EXIT";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // stats_panel
            // 
            this.stats_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.stats_panel.Controls.Add(this.AGIL_panel);
            this.stats_panel.Controls.Add(this.POWER_panel);
            this.stats_panel.Controls.Add(this.INTEL_panel);
            this.stats_panel.Controls.Add(this.HP_panel);
            this.stats_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.stats_panel.Location = new System.Drawing.Point(0, 0);
            this.stats_panel.Name = "stats_panel";
            this.stats_panel.Size = new System.Drawing.Size(600, 100);
            this.stats_panel.TabIndex = 1;
            // 
            // AGIL_panel
            // 
            this.AGIL_panel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.AGIL_panel.Controls.Add(this.AGIL_label);
            this.AGIL_panel.Controls.Add(this.label8);
            this.AGIL_panel.Location = new System.Drawing.Point(290, 15);
            this.AGIL_panel.Name = "AGIL_panel";
            this.AGIL_panel.Size = new System.Drawing.Size(70, 70);
            this.AGIL_panel.TabIndex = 3;
            // 
            // AGIL_label
            // 
            this.AGIL_label.AutoSize = true;
            this.AGIL_label.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AGIL_label.Location = new System.Drawing.Point(0, 40);
            this.AGIL_label.Name = "AGIL_label";
            this.AGIL_label.Size = new System.Drawing.Size(27, 18);
            this.AGIL_label.TabIndex = 1;
            this.AGIL_label.Text = "50";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Top;
            this.label8.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(0, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(72, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "AGILITY";
            // 
            // POWER_panel
            // 
            this.POWER_panel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.POWER_panel.Controls.Add(this.POWER_label);
            this.POWER_panel.Controls.Add(this.label6);
            this.POWER_panel.Location = new System.Drawing.Point(110, 15);
            this.POWER_panel.Name = "POWER_panel";
            this.POWER_panel.Size = new System.Drawing.Size(70, 70);
            this.POWER_panel.TabIndex = 2;
            // 
            // POWER_label
            // 
            this.POWER_label.AutoSize = true;
            this.POWER_label.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.POWER_label.Location = new System.Drawing.Point(0, 40);
            this.POWER_label.Name = "POWER_label";
            this.POWER_label.Size = new System.Drawing.Size(26, 18);
            this.POWER_label.TabIndex = 1;
            this.POWER_label.Text = "20";
            this.POWER_label.Click += new System.EventHandler(this.POWER_label_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Top;
            this.label6.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(0, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "POWER";
            // 
            // INTEL_panel
            // 
            this.INTEL_panel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.INTEL_panel.Controls.Add(this.INTEL_label);
            this.INTEL_panel.Controls.Add(this.label4);
            this.INTEL_panel.Location = new System.Drawing.Point(200, 15);
            this.INTEL_panel.Name = "INTEL_panel";
            this.INTEL_panel.Size = new System.Drawing.Size(70, 70);
            this.INTEL_panel.TabIndex = 1;
            // 
            // INTEL_label
            // 
            this.INTEL_label.AutoSize = true;
            this.INTEL_label.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.INTEL_label.Location = new System.Drawing.Point(0, 40);
            this.INTEL_label.Name = "INTEL_label";
            this.INTEL_label.Size = new System.Drawing.Size(25, 18);
            this.INTEL_label.TabIndex = 1;
            this.INTEL_label.Text = "10";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Top;
            this.label4.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "INTEL";
            // 
            // HP_panel
            // 
            this.HP_panel.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.HP_panel.Controls.Add(this.HP_label);
            this.HP_panel.Controls.Add(this.label1);
            this.HP_panel.Location = new System.Drawing.Point(20, 15);
            this.HP_panel.Name = "HP_panel";
            this.HP_panel.Size = new System.Drawing.Size(70, 70);
            this.HP_panel.TabIndex = 0;
            // 
            // HP_label
            // 
            this.HP_label.AutoSize = true;
            this.HP_label.Font = new System.Drawing.Font("Showcard Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.HP_label.Location = new System.Drawing.Point(0, 40);
            this.HP_label.Name = "HP_label";
            this.HP_label.Size = new System.Drawing.Size(35, 18);
            this.HP_label.TabIndex = 1;
            this.HP_label.Text = "100";
            this.HP_label.Click += new System.EventHandler(this.HP_label_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Showcard Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "HP";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.action_panel);
            this.panel3.Controls.Add(this.answer_panel);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(600, 350);
            this.panel3.TabIndex = 2;
            // 
            // action_panel
            // 
            this.action_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.action_panel.Controls.Add(this.Fab);
            this.action_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.action_panel.Location = new System.Drawing.Point(0, 0);
            this.action_panel.Name = "action_panel";
            this.action_panel.Size = new System.Drawing.Size(600, 250);
            this.action_panel.TabIndex = 2;
            this.action_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.action_panel_Paint);
            // 
            // Fab
            // 
            this.Fab.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Fab.Font = new System.Drawing.Font("MS Gothic", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Fab.Location = new System.Drawing.Point(20, 20);
            this.Fab.Multiline = true;
            this.Fab.Name = "Fab";
            this.Fab.Size = new System.Drawing.Size(560, 210);
            this.Fab.TabIndex = 1;
            this.Fab.TextChanged += new System.EventHandler(this.Fab_TextChanged);
            // 
            // answer_panel
            // 
            this.answer_panel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.answer_panel.Controls.Add(this.Action_2);
            this.answer_panel.Controls.Add(this.Acion_1);
            this.answer_panel.Controls.Add(this.exit_button);
            this.answer_panel.Controls.Add(this.LoadGAME_button);
            this.answer_panel.Controls.Add(this.HERO_button);
            this.answer_panel.Controls.Add(this.SATART_button);
            this.answer_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.answer_panel.Location = new System.Drawing.Point(0, 250);
            this.answer_panel.Name = "answer_panel";
            this.answer_panel.Size = new System.Drawing.Size(600, 100);
            this.answer_panel.TabIndex = 1;
            // 
            // Action_2
            // 
            this.Action_2.Location = new System.Drawing.Point(353, 30);
            this.Action_2.Name = "Action_2";
            this.Action_2.Size = new System.Drawing.Size(100, 40);
            this.Action_2.TabIndex = 6;
            this.Action_2.Text = "button1";
            this.Action_2.UseVisualStyleBackColor = true;
            this.Action_2.Click += new System.EventHandler(this.Action_2_Click);
            // 
            // Acion_1
            // 
            this.Acion_1.Location = new System.Drawing.Point(236, 30);
            this.Acion_1.Name = "Acion_1";
            this.Acion_1.Size = new System.Drawing.Size(100, 40);
            this.Acion_1.TabIndex = 6;
            this.Acion_1.Text = "button1";
            this.Acion_1.UseVisualStyleBackColor = true;
            this.Acion_1.Click += new System.EventHandler(this.Acion_1_Click);
            // 
            // LoadGAME_button
            // 
            this.LoadGAME_button.Location = new System.Drawing.Point(26, 22);
            this.LoadGAME_button.Name = "LoadGAME_button";
            this.LoadGAME_button.Size = new System.Drawing.Size(64, 64);
            this.LoadGAME_button.TabIndex = 5;
            this.LoadGAME_button.Text = "LOAD SAVE";
            this.LoadGAME_button.UseVisualStyleBackColor = true;
            this.LoadGAME_button.Click += new System.EventHandler(this.LoadGAME_button_Click);
            // 
            // HERO_button
            // 
            this.HERO_button.Location = new System.Drawing.Point(20, 63);
            this.HERO_button.Name = "HERO_button";
            this.HERO_button.Size = new System.Drawing.Size(75, 23);
            this.HERO_button.TabIndex = 4;
            this.HERO_button.Text = "HERO";
            this.HERO_button.UseVisualStyleBackColor = true;
            this.HERO_button.Click += new System.EventHandler(this.HERO_button_Click);
            // 
            // SATART_button
            // 
            this.SATART_button.Location = new System.Drawing.Point(20, 18);
            this.SATART_button.Name = "SATART_button";
            this.SATART_button.Size = new System.Drawing.Size(75, 23);
            this.SATART_button.TabIndex = 1;
            this.SATART_button.Text = "START";
            this.SATART_button.UseVisualStyleBackColor = true;
            this.SATART_button.Click += new System.EventHandler(this.SATART_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.stats_panel);
            this.Controls.Add(this.hero_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "\"\"";
            this.hero_panel.ResumeLayout(false);
            this.hero_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.stats_panel.ResumeLayout(false);
            this.AGIL_panel.ResumeLayout(false);
            this.AGIL_panel.PerformLayout();
            this.POWER_panel.ResumeLayout(false);
            this.POWER_panel.PerformLayout();
            this.INTEL_panel.ResumeLayout(false);
            this.INTEL_panel.PerformLayout();
            this.HP_panel.ResumeLayout(false);
            this.HP_panel.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.action_panel.ResumeLayout(false);
            this.action_panel.PerformLayout();
            this.answer_panel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel hero_panel;
        private Panel stats_panel;
        private Panel AGIL_panel;
        private Label AGIL_label;
        private Label label8;
        private Panel POWER_panel;
        private Label POWER_label;
        private Label label6;
        private Panel INTEL_panel;
        private Label INTEL_label;
        private Label label4;
        private Panel HP_panel;
        private Label HP_label;
        private Label label1;
        private Panel panel3;
        private Panel action_panel;
        private Panel answer_panel;
        private Button SATART_button;
        private Label label2;
        private TextBox Fab;
        private Label Klasa_label;
        private CheckBox tarcza_check;
        private CheckBox magia_check;
        private CheckBox widzenie_Check;
        private PictureBox pictureBox1;
        private Label IMIE_label;
        private Label Wiek_label;
        private Label Waga_label;
        private Label Wzrost_label;
        private Button HERO_button;
        private CheckBox checkBox1;
        private Button LoadGAME_button;
        private Button exit_button;
        private Button Acion_1;
        private Button Action_2;
    }
}