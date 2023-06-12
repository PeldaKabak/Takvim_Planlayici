using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planlayıcı
{
    public partial class Loginekranı : Form
    {
       
        public Loginekranı()
        {
            InitializeComponent();
        }
        DbTakvimProjeEntities db = new DbTakvimProjeEntities();

        private void Loginekranı_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int username = int.Parse(txtusername.Text);
            int password = int.Parse(txtpassword.Text);

            Tbl_Users kullanici = db.Tbl_Users.FirstOrDefault(x => x.Username == username && x.Password == password);
            if (kullanici != null)
            {
                string kullaniciAdi = txtusername.Text;

                Secimekranı sec = new Secimekranı();
                sec.KullaniciAdi = kullaniciAdi; // Kullanıcı adını Secimekranı formunun özelliğine aktar

                sec.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.");
            }
        }



        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Kayıtekranıcs kayıtekranı = new Kayıtekranıcs();
            kayıtekranı.Show();
            this.Hide();
        }
    }
}
