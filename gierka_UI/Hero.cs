using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gierka_UI
{
    
    public partial class Hero : Form
    {
        string path = @"MyHero.txt";
        StreamWriter sw;
    
        public Hero()
        {
            InitializeComponent();
            Klasa_list.Items.Add(("Wojownik"));
            Klasa_list.Items.Add(("Mag"));
            Klasa_list.Items.Add(("Ninja"));

            if (!File.Exists(path))
            {
                sw = File.CreateText(path);
            }
            else
            {
                sw = new StreamWriter(path);
            }
           
        }

        private void Klasa_list_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void save_button_Click(object sender, EventArgs e)
        {
            if (WIEK_textBox.Text != "" && WAGA_textBox.Text != "" && WZROST_textBox.Text != "" && Klasa_list.Text != "") 
            {
               
                sw.WriteLine(IMIE_texBox.Text);
                sw.WriteLine(Klasa_list.Text);
                sw.WriteLine(WZROST_textBox.Text);
                sw.WriteLine(WAGA_textBox.Text);
                sw.WriteLine(WIEK_textBox.Text);
                sw.Close();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Uzupełnij wszystkie pola","",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
    }
}
