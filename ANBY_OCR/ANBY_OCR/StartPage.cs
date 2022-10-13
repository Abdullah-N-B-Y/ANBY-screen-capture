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

namespace ANBY_OCR
{
    public partial class StartPage : Form
    {
        Thread thread;
        public StartPage()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            thread = new Thread(OpenNewForm);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }
        public void OpenNewForm()
        {
            Application.Run(new LoginPage());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            thread = new Thread(OpenNewForm2);
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
            this.Close();
        }
        public void OpenNewForm2()
        {
            Application.Run(new RegisterPage());
        }
    }
}
