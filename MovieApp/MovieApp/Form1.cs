using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace MovieApp
{
    public partial class Form1 : Form
    {
        SqlConnection baglanti = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\Source\Repos\Movie\MovieApp\MovieApp\Database1.mdf;Integrated Security=True");
        SqlCommand komut;
        SqlDataAdapter da;

        public Form1()
        {
            InitializeComponent();
        }

        void kayitlari_al()
        {
            
            
        }

        void kayitlari_bas()
        {
            baglanti.Open();
            da = new SqlDataAdapter("Select * from Movies", baglanti);
            DataTable tablo = new DataTable();
            da.Fill(tablo);
            baglanti.Close();
        }

        void button1_Click(object sender, EventArgs e)
        {
            void openFileDialog1_FileOk(object sender, CancelEventArgs e)
            {
                if (File.Exists(""))
                {
                    kayitlari_al();
                }
            }
            
            kayitlari_bas();
        }

        
    }
}
