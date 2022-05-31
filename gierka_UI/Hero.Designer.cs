namespace gierka_UI
{
    partial class Hero
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
            this.Klasa_list = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.IMIE_texBox = new System.Windows.Forms.TextBox();
            this.WAGA_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.WZROST_textBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.WIEK_textBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.save_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Klasa_list
            // 
            this.Klasa_list.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Klasa_list.Font = new System.Drawing.Font("NSimSun", 11.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.Klasa_list.FormattingEnabled = true;
            this.Klasa_list.ItemHeight = 15;
            this.Klasa_list.Location = new System.Drawing.Point(488, 116);
            this.Klasa_list.Name = "Klasa_list";
            this.Klasa_list.Size = new System.Drawing.Size(100, 94);
            this.Klasa_list.TabIndex = 0;
            this.Klasa_list.SelectedIndexChanged += new System.EventHandler(this.Klasa_list_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Font = new System.Drawing.Font("NSimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(121, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 21);
            this.label5.TabIndex = 2;
            this.label5.Text = "IMIE";
            // 
            // IMIE_texBox
            // 
            this.IMIE_texBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.IMIE_texBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.IMIE_texBox.Location = new System.Drawing.Point(65, 50);
            this.IMIE_texBox.Name = "IMIE_texBox";
            this.IMIE_texBox.Size = new System.Drawing.Size(173, 33);
            this.IMIE_texBox.TabIndex = 5;
            // 
            // WAGA_textBox
            // 
            this.WAGA_textBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.WAGA_textBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WAGA_textBox.Location = new System.Drawing.Point(65, 132);
            this.WAGA_textBox.Name = "WAGA_textBox";
            this.WAGA_textBox.Size = new System.Drawing.Size(173, 33);
            this.WAGA_textBox.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label2.Font = new System.Drawing.Font("NSimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(121, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 21);
            this.label2.TabIndex = 6;
            this.label2.Text = "WAGA";
            // 
            // WZROST_textBox
            // 
            this.WZROST_textBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.WZROST_textBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WZROST_textBox.Location = new System.Drawing.Point(303, 132);
            this.WZROST_textBox.Name = "WZROST_textBox";
            this.WZROST_textBox.Size = new System.Drawing.Size(173, 33);
            this.WZROST_textBox.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label3.Font = new System.Drawing.Font("NSimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(351, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 21);
            this.label3.TabIndex = 10;
            this.label3.Text = "WZROST";
            // 
            // WIEK_textBox
            // 
            this.WIEK_textBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.WIEK_textBox.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.WIEK_textBox.Location = new System.Drawing.Point(303, 50);
            this.WIEK_textBox.Name = "WIEK_textBox";
            this.WIEK_textBox.Size = new System.Drawing.Size(173, 33);
            this.WIEK_textBox.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label4.Font = new System.Drawing.Font("NSimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(364, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 21);
            this.label4.TabIndex = 8;
            this.label4.Text = "WIEK";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.label1.Font = new System.Drawing.Font("NSimSun", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(488, 81);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 21);
            this.label1.TabIndex = 10;
            this.label1.Text = "KLASA";
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(55, 202);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(75, 23);
            this.save_button.TabIndex = 12;
            this.save_button.Text = "SAVE";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // Hero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(600, 250);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.WZROST_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.WIEK_textBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.WAGA_textBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.IMIE_texBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Klasa_list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Hero";
            this.Text = "Hero";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListBox Klasa_list;
        private Label label5;
        private TextBox IMIE_texBox;
        private TextBox WAGA_textBox;
        private Label label2;
        private TextBox WZROST_textBox;
        private Label label3;
        private TextBox WIEK_textBox;
        private Label label4;
        private Label label1;
        private Button save_button;
    }
}