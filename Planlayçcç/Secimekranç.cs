using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Planlayıcı
{
    public partial class Secimekranı : Form
    {
        public string KullaniciAdi { get; set; }
        private string kullaniciAdi;
        public Secimekranı()
        {
            InitializeComponent();
            
        }
        

        private void btnplanlama_Click(object sender, EventArgs e)
        {
            
            planekranı pln = new planekranı();
            pln.Show();
           this.Hide();
        }

        private void btnlisteleme_Click(object sender, EventArgs e)
        {  
            string kullaniciAdi = KullaniciAdi;        
            Takvimekranı tkvm = new Takvimekranı(kullaniciAdi);
            tkvm.Show();
            this.Hide();
        }

        private void Secimekranı_Load(object sender, EventArgs e)
        {

        }
    }
}
