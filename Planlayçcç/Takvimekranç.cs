using System;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Core.Objects;
using System.Data.Entity.Spatial;
using System.Linq;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace Planlayıcı
{
    public partial class Takvimekranı : Form
    {


        private string kullaniciAdi;


        private readonly DbTakvimProjeEntities _db = new DbTakvimProjeEntities();

        public Takvimekranı(string ad)
        {
            InitializeComponent();
            kullaniciAdi = ad;
        }

        private void Takvimekranı_Load(object sender, EventArgs e)
        {
            adı.Text = kullaniciAdi;
            var days = _db.Tbl_program.Select(p => p.Day).Distinct().ToList();
            cmbtarihler.DataSource = days;
           

        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Secimekranı scm = new Secimekranı();
            scm.Show();
            this.Hide();
        }

        private void cmbtarihler_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime selectedDate = (DateTime)cmbtarihler.SelectedItem;

           

            var degerler = _db.Tbl_program
                .Where(x => x.Day == selectedDate)
                .Select(x => new
                {
                    x.Explanation,
                    x.Eventtype,
                    x.Day,
                    x.Starttime
                })
                .ToList()
                .Select(x => new
                {
                    x.Explanation,
                    x.Eventtype,
                    x.Day,
                    StartTime = x.Starttime.HasValue ? new TimeSpan(x.Starttime.Value.Hour, x.Starttime.Value.Minute, x.Starttime.Value.Second) : (TimeSpan?)null
                });

            dataGridView1.DataSource = degerler.ToList();



        }




        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           

            // Seçilen satırın tarih değerini al
            DateTime date = (DateTime)dataGridView1.CurrentRow.Cells["Day"].Value;

            // Planlamaekranı formunu aç ve seçilen tarihi gönder
            planekranı planlamaekrani = new planekranı();
            planlamaekrani.SetSelectedDate(date);
            string explanation = dataGridView1.CurrentRow.Cells["Explanation"].Value.ToString();
            string eventtype = dataGridView1.CurrentRow.Cells["Eventtype"].Value.ToString();
            planlamaekrani.SetExplanation(explanation);
            planlamaekrani.SetEventtype(eventtype);
             planlamaekrani.Show();
            this.Hide();
           

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
   
    












