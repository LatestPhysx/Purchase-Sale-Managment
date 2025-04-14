using System;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CSharp
{
    public partial class Form7 : Form
    {
        public static SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=gestionAchatVente;Integrated Security=True;TrustServerCertificate=True");
        public static SqlCommand com = new SqlCommand("", con);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            con.Open();
            com.CommandText = "select CommandeID from Commandes";
            SqlDataReader reader = com.ExecuteReader();
            if (!reader.HasRows)
            {
                con.Close();
                MessageBox.Show("There Is No Command !");
            }
            else
            {
                while (reader.Read())
                {
                    crownComboBox1.Items.Add(reader[0].ToString());
                }
                con.Close();
            }
            con.Open();
            com.CommandText = "select ProduitID from Produits";
            SqlDataReader reader2 = com.ExecuteReader();
            if (!reader2.HasRows)
            {
                con.Close();
                MessageBox.Show("There Is No Produit !");
            }
            else
            {
                while (reader2.Read())
                {
                    crownComboBox2.Items.Add(reader2[0].ToString());
                }
                con.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                com.CommandText = "insert into LigneCommande values(" + int.Parse(textBoxEdit1.Text) + "," + int.Parse(textBoxEdit2.Text) + "," + float.Parse(textBoxEdit3.Text) + "," + int.Parse(crownComboBox1.SelectedItem.ToString()) + "," + int.Parse(crownComboBox2.SelectedItem.ToString()) + ")";
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Succes");
                textBoxEdit1.Text = "";
                textBoxEdit2.Text = "";
                textBoxEdit3.Text = "";
                crownComboBox1.SelectedIndex = -1;
                crownComboBox2.SelectedIndex = -1;
                textBoxEdit1.Focus();
            }
            catch (Exception Err)
            {
                MessageBox.Show("Error : " + Err.Message);
            }
        }

        private void Form7_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
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

        private void foreverClose1_Click(object sender, EventArgs e)
        {
            var isF1Open = Application.OpenForms.OfType<LoginApp>().ToList();
            if (isF1Open.Count() != 0)
            {
                isF1Open.FirstOrDefault().Close();
            }
        }

        private void Rechercher_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                com.CommandText = "select * from LigneCommande where LigneID = " + int.Parse(textBoxEdit1.Text) + ";";
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
            catch (Exception Err)
            {
                con.Close();
                MessageBox.Show("Error : " + Err.Message);
            }
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                com.CommandText = "update LigneCommande set LigneID = " + int.Parse(textBoxEdit1.Text) + " , Quantite = " + int.Parse(textBoxEdit2.Text) + " , PrixUnitaire = " + float.Parse(textBoxEdit3.Text) + " , CommandeID = " + int.Parse(crownComboBox1.SelectedItem.ToString()) + " , ProduitID = " + int.Parse(crownComboBox2.SelectedItem.ToString()) + " where LigneID = " + int.Parse(textBoxEdit1.Text) + ";";
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Succes");
                textBoxEdit1.Text = "";
                textBoxEdit2.Text = "";
                textBoxEdit3.Text = "";
                crownComboBox1.SelectedIndex = -1;
                crownComboBox2.SelectedIndex = -1;
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
                com.CommandText = "delete from LigneCommande where LigneID = " + int.Parse(textBoxEdit1.Text) + ";";
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Succes");
                textBoxEdit1.Text = "";
                textBoxEdit2.Text = "";
                textBoxEdit3.Text = "";
                crownComboBox1.SelectedIndex = -1;
                crownComboBox2.SelectedIndex = -1;
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