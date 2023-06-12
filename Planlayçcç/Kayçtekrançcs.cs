using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planlayıcı
{
    public partial class Kayıtekranıcs : Form
    {
        public Kayıtekranıcs()
        {
            InitializeComponent();
        }
        DbTakvimProjeEntities db = new DbTakvimProjeEntities();

        private void Kayıtekranıcs_Load(object sender, EventArgs e)
        {

        }

        public void button1_Click(object sender, EventArgs e)
        {
           
                Tbl_Users tb = new Tbl_Users();
                tb.Name = txtad.Text;
                tb.Surname = txtsoyad.Text;
                tb.Username = int.Parse(txtkulllaniciad.Text);
                tb.Password = int.Parse(txtsifre.Text);
                tb.TC = msktc.Text;
                tb.Telephone = msktelefon.Text;
                tb.Email = txtmail.Text;
                tb.Adrress = txtadres.Text;
                tb.Usertype = cmbtip.Text;
                db.Tbl_Users.Add(tb);
                db.SaveChanges();
                MessageBox.Show("YENİ KULLANICI KAYDI OLUŞTURULDU");






        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Loginekranı login = new Loginekranı();
            login.Show();
            this.Hide();

        }
    }
}
