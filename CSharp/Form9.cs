using System;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CSharp
{
    public partial class Form9 : Form
    {

        public static SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=gestionAchatVente;Integrated Security=True;TrustServerCertificate=True");
        public static SqlCommand com = new SqlCommand("", con);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public Form9()
        {
            InitializeComponent();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Form9_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Form9_Load(object sender, EventArgs e)
        {
            con.Open();
            com.CommandText = "select FournisseurID from Fournisseurs";
            SqlDataReader reader = com.ExecuteReader();
            if (!reader.HasRows)
            {
                con.Close();
                MessageBox.Show("There Is No Fournisseurs !");
            }
            else
            {
                while (reader.Read())
                {
                    crownComboBox1.Items.Add(reader[0].ToString());
                }
                con.Close();
            }
            textBoxEdit1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                com.CommandText = "insert into Achats values(" + int.Parse(textBoxEdit1.Text) + "," + int.Parse(textBoxEdit2.Text) + "," + float.Parse(textBoxEdit3.Text) + ",'" + poisonDateTime1.Value.ToString("dd-MM-yyyy") + "'," + int.Parse(crownComboBox1.SelectedItem.ToString()) + ");";
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Succes !");
                textBoxEdit1.Text = "";
                textBoxEdit2.Text = "";
                textBoxEdit3.Text = "";
                poisonDateTime1.Value = DateTime.Today;
                crownComboBox1.SelectedIndex = -1;
                textBoxEdit1.Focus();
            }
            catch (Exception Err)
            {
                MessageBox.Show("Error : " + Err.Message);
            }
        }

        private void Rechercher_Click(object sender, EventArgs e)
        {
            con.Open();
            com.CommandText = "select * from Achats where AchatID = " + int.Parse(textBoxEdit1.Text) + ";";
            SqlDataReader reader = com.ExecuteReader();
            if (!reader.HasRows)
            {
                con.Close();
                MessageBox.Show("There Is No Data");
            }
            else
            {
                con.Close();
                MessageBox.Show("Succes, There Is Data !");
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                com.CommandText = "update Achats set AchatID = " + int.Parse(textBoxEdit1.Text) + " , Quantite = " + int.Parse(textBoxEdit2.Text) + " , PrixAchat = " + float.Parse(textBoxEdit3.Text) + " , DateAchat = '" + poisonDateTime1.Value.ToString() + "' , FournisseurID = " + int.Parse(crownComboBox1.SelectedItem.ToString()) + " where AchatID = " + int.Parse(textBoxEdit1.Text) + ";";
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Succes !");
                textBoxEdit1.Text = "";
                textBoxEdit2.Text = "";
                textBoxEdit3.Text = "";
                poisonDateTime1.Value = DateTime.Today;
                crownComboBox1.SelectedIndex = -1;
                textBoxEdit1.Focus();
            }
            catch (Exception Err)
            {
                MessageBox.Show("Error : " + Err.Message);
            }
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                com.CommandText = "delete from Achats where AchatID = " + int.Parse(textBoxEdit1.Text) + ";";
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Succes !");
                textBoxEdit1.Text = "";
                textBoxEdit2.Text = "";
                textBoxEdit3.Text = "";
                poisonDateTime1.Value = DateTime.Today;
                crownComboBox1.SelectedIndex = -1;
                textBoxEdit1.Focus();
            }
            catch (Exception Err)
            {
                MessageBox.Show("Error : " + Err.Message);
            }
        }

        private void Quitter_Click(object sender, EventArgs e)
        {
            var isF1Open = Application.OpenForms.OfType<LoginApp>().ToList();
            if (isF1Open.Count() != 0)
            {
                isF1Open.FirstOrDefault().Close();
            }
            else
            {
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
