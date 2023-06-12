using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Planlayıcı
{
    public partial class planekranı : Form
    {
        public planekranı()
        {
            InitializeComponent();
           
            Controls.Add(rchtxtNot);
        }
        DbTakvimProjeEntities db = new DbTakvimProjeEntities();
        public void SetSelectedDate(DateTime date)
        {
            dateTimePickergün.Value = date;
        }
        public void SetExplanation(string explanation)
        {

            rchtxtNot.Text = explanation;
        }

        public void SetEventtype(string eventtype)
        {

            cmbplan.SelectedItem = eventtype;
        }


        

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Secimekranı scm = new Secimekranı();
            scm.Show();
            this.Hide();
        }

       

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Secimekranı scm = new Secimekranı();
            scm.Show();
            this.Hide();
        }

     

        private void btnplanla_Click_1(object sender, EventArgs e)
        {
            Tbl_program tbl = new Tbl_program();
            tbl.Day = DateTime.ParseExact(dateTimePickergün.Value.ToString("yyyy-MM-dd"), "yyyy-MM-dd", CultureInfo.InvariantCulture);
            tbl.Starttime = DateTime.ParseExact(dateTimePickersaat.Value.ToString("HH:mm:ss"), "HH:mm:ss", CultureInfo.InvariantCulture);
            tbl.Explanation = rchtxtNot.Text;
            tbl.Eventtype = cmbplan.Text;
            db.Tbl_program.Add(tbl);
            db.SaveChanges();
            MessageBox.Show("YENİ PLAN KAYDI OLUŞTURULDU");
        }
    }

        
    }

