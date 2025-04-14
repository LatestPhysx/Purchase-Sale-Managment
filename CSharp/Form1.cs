using System;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CSharp
{
    public partial class LoginApp : Form
    {

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public static SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=gestionAchatVente;Integrated Security=True;TrustServerCertificate=True");
        public static SqlCommand com = new SqlCommand("", con);

        public LoginApp()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            checkBox1.AutoSize = false;
            checkBox1.Height = 40;
            textBoxEdit2.UseSystemPasswordChar = true;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void checkBox1_CheckedChanged(object sender)
        {
            if (!checkBox1.Checked)
            {
                textBoxEdit2.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxEdit2.UseSystemPasswordChar = false;
            }
        }

        private void Login_Click(object sender, EventArgs e)
        {
            con.Open();
            if (textBoxEdit1.Text == "" || textBoxEdit2.Text == "")
            {
                MessageBox.Show("Please Write Your Credentials");
            }
            else
            {
                com.CommandText = "select * from users where username COLLATE Latin1_General_CS_AS = '" + textBoxEdit1.Text + "' and password COLLATE Latin1_General_CS_AS = '" + textBoxEdit2.Text + "';";
                SqlDataReader reader = com.ExecuteReader();
                if (reader.HasRows)
                {
                    MessageBox.Show("Welcome !");
                    Form3 f3 = new Form3();
                    f3.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Please Check Your Crendentials And Log In Again !");
                }
            }
            con.Close();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Form2 F2 = new Form2();
            F2.Show();
            this.Hide();
        }

        private void labelEdit3_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEdit2_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelEdit2_Click(object sender, EventArgs e)
        {

        }

        private void labelEdit1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxEdit1_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Click(object sender, EventArgs e)
        {

        }

        private void foreverMinimize1_Click(object sender, EventArgs e)
        {

        }

        private void foreverClose1_Click(object sender, EventArgs e)
        {

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
