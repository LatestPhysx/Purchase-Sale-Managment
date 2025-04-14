using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CSharp
{
    public partial class Form3 : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public Form3()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var isF1Open = Application.OpenForms.OfType<LoginApp>().ToList();
            if (isF1Open.Count() != 0)
            {
                isF1Open.FirstOrDefault().Close();
                this.Close();
            }
            else
            {
                this.Close();
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            var isF10Open = Application.OpenForms.OfType<Form10>().ToList();
            if (isF10Open.Count() != 0)
            {
                isF10Open.FirstOrDefault().Show();
                this.Close();
            }
            else
            {
                Form10 F10 = new Form10();
                F10.Show();
                this.Close();
            }
        }

        private void foreverClose1_Click(object sender, EventArgs e)
        {
            var isF1Open = Application.OpenForms.OfType<LoginApp>().ToList();
            if (isF1Open.Count() != 0)
            {
                isF1Open.FirstOrDefault().Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var isF4Open = Application.OpenForms.OfType<Form4>().ToList();
            if (isF4Open.Count() != 0)
            {
                isF4Open.FirstOrDefault().Show();
                this.Close();
            }
            else
            {
                Form4 F4 = new Form4();
                F4.Show();
                this.Close();
            }

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void Form3_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var isF5Open = Application.OpenForms.OfType<Form5>().ToList();
            if (isF5Open.Count() != 0)
            {
                isF5Open.FirstOrDefault().Show();
                this.Close();
            }
            else
            {
                Form5 F5 = new Form5();
                F5.Show();
                this.Close();
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var isF6Open = Application.OpenForms.OfType<Form6>().ToList();
            if (isF6Open.Count() != 0)
            {
                isF6Open.FirstOrDefault().Show();
                this.Close();
            }
            else
            {
                Form6 F6 = new Form6();
                F6.Show();
                this.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var isF7Open = Application.OpenForms.OfType<Form7>().ToList();
            if (isF7Open.Count() != 0)
            {
                isF7Open.FirstOrDefault().Show();
                this.Close();
            }
            else
            {
                Form7 F7 = new Form7();
                F7.Show();
                this.Close();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var isF8Open = Application.OpenForms.OfType<Form8>().ToList();
            if (isF8Open.Count() != 0)
            {
                isF8Open.FirstOrDefault().Show();
                this.Close();
            }
            else
            {
                Form8 F8 = new Form8();
                F8.Show();
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var isF9Open = Application.OpenForms.OfType<Form9>().ToList();
            if (isF9Open.Count() != 0)
            {
                isF9Open.FirstOrDefault().Show();
                this.Close();
            }
            else
            {
                Form9 F9 = new Form9();
                F9.Show();
                this.Close();
            }
        }
    }
}
