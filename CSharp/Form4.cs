using System;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CSharp
{
    public partial class Form4 : Form
    {

        public static SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=gestionAchatVente;Integrated Security=True;TrustServerCertificate=True");
        public static SqlCommand com = new SqlCommand("", con);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public Form4()
        {
            InitializeComponent();
        }

        private void labelEdit3_Click(object sender, EventArgs e)
        {

        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void foreverClose1_Click(object sender, EventArgs e)
        {
            var isF1Open = Application.OpenForms.OfType<LoginApp>().ToList();
            if (isF1Open.Count() != 0)
            {
                isF1Open.FirstOrDefault().Close();
            }
        }

        private void Quitter_Click(object sender, EventArgs e)
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBoxEdit1.Text == "" || textBoxEdit2.Text == "" || textBoxEdit3.Text == "" || textBoxEdit4.Text == "" || textBoxEdit5.Text == "")
                {
                    MessageBox.Show("Please Don't Let The Input Boxes Empty!");
                }
                else
                {
                    con.Open();
                    com.CommandText = "insert into Produits values(" + int.Parse(textBoxEdit1.Text) + ",'" + textBoxEdit2.Text + "','" + textBoxEdit3.Text + "'," + float.Parse(textBoxEdit4.Text) + "," + int.Parse(textBoxEdit5.Text) + ");";
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Succes");
                    textBoxEdit1.Text = "";
                    textBoxEdit2.Text = "";
                    textBoxEdit3.Text = "";
                    textBoxEdit4.Text = "";
                    textBoxEdit5.Text = "";
                    textBoxEdit1.Focus();
                }
            }
            catch (Exception a)
            {
                MessageBox.Show("Error : " + a.Message);
            }
        }

        private void Form4_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Rechercher_Click(object sender, EventArgs e)
        {
            con.Open();
            com.CommandText = "select * from Produits where ProduitID = " + int.Parse(textBoxEdit1.Text);
            SqlDataReader reader = com.ExecuteReader();
            if (!reader.HasRows)
            {
                con.Close();
                MessageBox.Show("There Is No Existing Data !");
            }
            else
            {
                while (reader.Read())
                {
                    textBoxEdit2.Text = reader[1].ToString();
                    textBoxEdit3.Text = reader[2].ToString();
                    textBoxEdit4.Text = reader[3].ToString();
                    textBoxEdit5.Text = reader[4].ToString();
                }
                con.Close();
                MessageBox.Show("Succes");
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                com.CommandText = "update Produits set Nom = '" + textBoxEdit2.Text + "', Description = '" + textBoxEdit3.Text + "', Prix = " + float.Parse(textBoxEdit4.Text) + ", QuantiteStock = " + int.Parse(textBoxEdit5.Text) + " where ProduitID = " + int.Parse(textBoxEdit1.Text) + ";";
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Succes");
                textBoxEdit1.Text = "";
                textBoxEdit2.Text = "";
                textBoxEdit3.Text = "";
                textBoxEdit4.Text = "";
                textBoxEdit5.Text = "";
                textBoxEdit1.Focus();
            }
            catch (Exception a)
            {
                MessageBox.Show("Error : " + a.Message);
                con.Close();
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                com.CommandText = "delete from Produits where ProduitID = " + int.Parse(textBoxEdit1.Text);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Succes");
                textBoxEdit1.Text = "";
                textBoxEdit2.Text = "";
                textBoxEdit3.Text = "";
                textBoxEdit4.Text = "";
                textBoxEdit5.Text = "";
                textBoxEdit1.Focus();
            }
            catch (Exception a)
            {
                MessageBox.Show("Error : " + a.Message);
            }
        }

        private void panel1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var isF3Open = Application.OpenForms.OfType<Form3>().ToList();
            if (isF3Open.Count != 0)
            {
                isF3Open.FirstOrDefault().Show();
                this.Close();
            }
            else
            {
                Form3 F3 = new Form3();
                F3.Show();
                this.Close();
            }
        }
    }
}