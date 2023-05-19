using Parti_Secim_Anketi.DataAccess;
using Parti_Secim_Anketi.Entities;

namespace Parti_Secim_Anketi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DistrictDal _districtDal = new DistrictDal();
        private void btn_oy_Click(object sender, EventArgs f)
        {
            decimal a = decimal.Parse(textBox1.Text);
            decimal b = decimal.Parse(textBox2.Text);
            decimal c = decimal.Parse(textBox3.Text);
            decimal d = decimal.Parse(textBox4.Text);
            decimal e = decimal.Parse(textBox5.Text);

            decimal toplam = a + b + c + d + e;

            decimal y�zdeA = 100 * a / toplam;
            decimal y�zdeB = 100 * b / toplam;
            decimal y�zdeC = 100 * c / toplam;
            decimal y�zdeD = 100 * d / toplam;
            decimal y�zdeE = 100 * e / toplam;


            _districtDal.Add(new District
            {
                Ilce = tbx_ilce.Text,
                AParti = y�zdeA,
                BParti = y�zdeB,
                CParti = y�zdeC,
                DParti = y�zdeD,
                EParti = y�zdeE
            });
            MessageBox.Show("��lem Ba�ar�yla Ger�ekle�ti!");
        }

        private void btn_grafikler_Click(object sender, EventArgs e)
        {
            Grafikler gra = new Grafikler();
            gra.Show();
        }

        private void btn_cikis_Click(object sender, EventArgs e)
        {
            DialogResult choice = MessageBox.Show("Uygulamay� Kapatmak �stedi�inize Emin Misiniz?", "��k�� Yap", MessageBoxButtons.YesNo);
            if (choice == DialogResult.Yes)
            {
                this.Close();
            }

        }
    }
}