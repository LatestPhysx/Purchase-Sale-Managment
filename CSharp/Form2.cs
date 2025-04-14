using System;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CSharp
{
    public partial class Form2 : Form
    {



        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public static SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=gestionAchatVente;Integrated Security=True;TrustServerCertificate=True");
        public static SqlCommand com = new SqlCommand("", con);

        public Form2()
        {
            InitializeComponent();
        }

        private void Login_Click(object sender, EventArgs e)
        {
            var isF1Open = Application.OpenForms.OfType<LoginApp>().ToList();
            if (isF1Open.Count() != 0)
            {
                isF1Open.FirstOrDefault().Show();
                this.Close();
            }
            else
            {
                LoginApp F1 = new LoginApp();
                F1.Show();
                this.Close();
            }
        }



        private void checkBox1_CheckedChanged(object sender)
        {
            if (!checkBox1.Checked)
            {
                textBoxEdit3.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxEdit3.UseSystemPasswordChar = false;
                textBoxEdit3.UseSystemPasswordChar = false;
            }
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            textBoxEdit3.UseSystemPasswordChar = true;
        }

        private void Register_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                com.CommandText = "insert into users values('" + textBoxEdit1.Text + "','" + textBoxEdit2.Text + "','" + textBoxEdit3.Text + "');";
                com.ExecuteNonQuery();
                MessageBox.Show("Succes");
                var isF1Open = Application.OpenForms.OfType<LoginApp>().ToList();
                if (isF1Open.Count() != 0)
                {
                    isF1Open.FirstOrDefault().Show();
                }
                else
                {
                    LoginApp F1 = new LoginApp();
                    F1.Show();
                }
                textBoxEdit1.Text = "";
                textBoxEdit2.Text = "";
                textBoxEdit3.Text = "";
                textBoxEdit1.Focus();
                this.Close();
            }
            catch (Exception a)
            {
                MessageBox.Show("Error : " + a.Message);
            }
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
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

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
    }
}