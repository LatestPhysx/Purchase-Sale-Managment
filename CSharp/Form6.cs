using System;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CSharp
{
    public partial class Form6 : Form
    {

        public static SqlConnection con = new SqlConnection("Data Source=localhost;Initial Catalog=gestionAchatVente;Integrated Security=True;TrustServerCertificate=True");
        public static SqlCommand com = new SqlCommand("", con);

        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();


        public Form6()
        {
            InitializeComponent();
        }

        private void labelEdit5_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {
            crownComboBox1.Height = 46;
            poisonDateTime1.Height = 46;
            try
            {
                con.Open();
                com.CommandText = "select ClientID from Clients";
                SqlDataReader reader = com.ExecuteReader();
                if (!reader.HasRows)
                {
                    con.Close();
                    MessageBox.Show("There Is No Registered Client !");
                }
                else
                {
                    while (reader.Read())
                    {
                        crownComboBox1.Items.Add(reader[0].ToString());
                    }
                    con.Close();
                }
            }
            catch (Exception a)
            {
                con.Close();
                MessageBox.Show("Error : " + a.Message);
            }
        }

        private void Form6_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxEdit1.Text) || string.IsNullOrEmpty(textBoxEdit3.Text) || crownComboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Make Sure To Put Correct Information !");
            }
            else
            {
                try
                {
                    con.Open();
                    com.CommandText = "insert into Commandes values(" + int.Parse(textBoxEdit1.Text) + ",'" + poisonDateTime1.Value.ToString("dd-MMMM-yyyy") + "'," + int.Parse(textBoxEdit3.Text) + "," + int.Parse(crownComboBox1.SelectedItem.ToString()) + ");";
                    com.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Succes");
                    textBoxEdit1.Text = "";
                    poisonDateTime1.Value = DateTime.Today;
                    textBoxEdit3.Text = "";
                    crownComboBox1.SelectedIndex = -1;
                    textBoxEdit1.Focus();
                }
                catch (Exception a)
                {
                    con.Close();
                    MessageBox.Show("Error : " + a.Message);
                }
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
            con.Open();
            com.CommandText = "select * from Commandes where CommandeID = " + int.Parse(textBoxEdit1.Text);
            SqlDataReader reader = com.ExecuteReader();
            if (!reader.HasRows)
            {
                con.Close();
                MessageBox.Show("There Is No Data !");
            }
            else
            {
                while (reader.Read())
                {
                    poisonDateTime1.Value = DateTime.Parse(reader[1].ToString());
                    textBoxEdit3.Text = reader[2].ToString();
                    crownComboBox1.SelectedItem = reader[3].ToString();
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
                com.CommandText = "update Commandes set DateCommande = '" + poisonDateTime1.Value.ToString("dd-MMMM-yyyy") + "', Total = " + int.Parse(textBoxEdit3.Text) + ", ClientID = " + int.Parse(crownComboBox1.SelectedItem.ToString()) + " where CommandeID = " + int.Parse(textBoxEdit1.Text);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Succes");
                textBoxEdit1.Text = "";
                poisonDateTime1.Value = DateTime.Today;
                textBoxEdit3.Text = "";
                crownComboBox1.SelectedIndex = -1;
                textBoxEdit1.Focus();
            }
            catch (Exception a)
            {
                con.Close();
                MessageBox.Show("Error : " + a.Message);
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

        private void Supprimer_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                com.CommandText = "delete from Commandes where CommandeID = " + int.Parse(textBoxEdit1.Text);
                com.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Succes");
                textBoxEdit1.Text = "";
                poisonDateTime1.Value = DateTime.Today;
                textBoxEdit3.Text = "";
                crownComboBox1.SelectedIndex = -1;
                textBoxEdit1.Focus();
            }
            catch (Exception a)
            {
                con.Close();
                MessageBox.Show("Error : " + a.Message);
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