using Parti_Secim_Anketi.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parti_Secim_Anketi
{
    public partial class Grafikler : Form
    {
        public Grafikler()
        {
            InitializeComponent();
        }
        DistrictDal _districtDal = new DistrictDal();
        private void Grafikler_Load(object sender, EventArgs e)
        {
            var all = _districtDal.GetAll();
            foreach (var item in all)
            {
                comboBox1.Items.Add(item.Ilce);
            }

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = _districtDal.GetByDistrict(comboBox1.Text.ToString());

            progressBarA.Value = (int)item.AParti.Value;
            progressBarB.Value = (int)item.BParti.Value;
            progressBarC.Value = (int)item.CParti.Value;
            progressBarD.Value = (int)item.DParti.Value;
            progressBarE.Value = (int)item.EParti.Value;

            lbl_a.Text = String.Format("%{0}", item.AParti.Value.ToString());
            lbl_b.Text = String.Format("%{0}", item.BParti.Value.ToString());
            lbl_c.Text = String.Format("%{0}", item.CParti.Value.ToString());
            lbl_d.Text = String.Format("%{0}", item.DParti.Value.ToString());
            lbl_e.Text = String.Format("%{0}", item.EParti.Value.ToString());
        }
    }
}
