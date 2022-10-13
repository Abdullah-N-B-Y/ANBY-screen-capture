using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tesseract;

namespace ANBY_OCR
{
    public partial class Form1 : Form
    {
        Bitmap BM;
        TextScreen textscreen;
        private bool OpenBefor;
        public static bool DarkOn;
        Thread thread;
        public static bool b = false;
        //int a, b, c;
        public Form1()
        {
            InitializeComponent();
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (TextScreen.DarkOn)
            {
                DarkOn = true;
            }
            else
            {
                DarkOn = false;
            }
            if (OpenBefor)
            {
                textscreen.Close();
                BM = CA(pictureBox2);
                textscreen = new TextScreen();
                TesseractEngine engine = new TesseractEngine("./tessdata", "eng", EngineMode.Default);
                Page page = engine.Process(BM, PageSegMode.Auto);
                textscreen.textBox1.Text = page.GetText();
                textscreen.Show();
            }
            else
            {
                BM = CA(pictureBox2);
                textscreen = new TextScreen();
                TesseractEngine engine = new TesseractEngine("./tessdata", "eng", EngineMode.Default);
                Page page = engine.Process(BM, PageSegMode.Auto);
                textscreen.textBox1.Text = page.GetText();
                textscreen.Show();
                OpenBefor = true;
            }
        }
        private Bitmap CA(Control c)
        {
            Size size = c.ClientSize;
            Bitmap bitmap = new Bitmap(size.Width, size.Height);
            Graphics g;
            g = Graphics.FromImage(bitmap);
            g.CopyFromScreen(c.PointToScreen(new Point(0, 0)), new Point(0, 0), new Size(size.Width, size.Height));
            return bitmap;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

            {
                if (TextScreen.DarkOn)
                {
                    DarkOn = true;
                }
                else
                {
                    DarkOn = false;
                }
                if (OpenBefor)
                {
                    textscreen.Close();
                    BM = CA(pictureBox2);
                    textscreen = new TextScreen();
                    TesseractEngine engine = new TesseractEngine("./tessdata", "eng", EngineMode.Default);
                    Page page = engine.Process(BM, PageSegMode.Auto);
                    textscreen.textBox1.Text = page.GetText();
                    textscreen.Show();
                }
                else
                {
                    BM = CA(pictureBox2);
                    textscreen = new TextScreen();
                    TesseractEngine engine = new TesseractEngine("./tessdata", "eng", EngineMode.Default);
                    Page page = engine.Process(BM, PageSegMode.Auto);
                    textscreen.textBox1.Text = page.GetText();
                    textscreen.Show();
                    OpenBefor = true;
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (!b)
            {
                thread = new Thread(OpenNewForm);
                thread.SetApartmentState(ApartmentState.STA);
                thread.Start();
                this.Close();
                b = true;
            }
            
        }
        public void OpenNewForm()
        {
            Application.Run(new StartPage());
        }
    }
}
