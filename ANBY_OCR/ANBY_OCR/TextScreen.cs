using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ANBY_OCR
{
    public partial class TextScreen : Form
    {
        public static bool DarkOn;
        public TextScreen()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

       
       

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            float f = textBox1.Font.Size;
            f += 2.0f;
            textBox1.Font = new Font(textBox1.Font.Name, f, textBox1.Font.Style, textBox1.Font.Unit);

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            float f = textBox1.Font.Size;
            f -= 2.0f;
            textBox1.Font = new Font(textBox1.Font.Name, f, textBox1.Font.Style, textBox1.Font.Unit);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (!DarkOn)
            {
                textBox1.BackColor = Color.Black;
                textBox1.ForeColor = Color.White;
                pictureBox5.Image = Properties.Resources.don;
                DarkOn = true;

            }
            else 
            {
                textBox1.BackColor = Color.LightGray;
                textBox1.ForeColor = Color.Black;
                pictureBox5.Image = Properties.Resources.df;
                DarkOn = false;
            }
        }

        private void TextScreen_Load(object sender, EventArgs e)
        {
            if (Form1.DarkOn)
            {
                textBox1.BackColor = Color.Black;
                textBox1.ForeColor = Color.White;
                pictureBox5.Image = Properties.Resources.don;
                DarkOn = true;

            }
            else
            {
                textBox1.BackColor = Color.LightGray;
                textBox1.ForeColor = Color.Black;
                pictureBox5.Image = Properties.Resources.df;
                DarkOn = false;
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }
    }
}
