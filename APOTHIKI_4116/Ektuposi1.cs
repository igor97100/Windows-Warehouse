using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APOTHIKI_4116
{
    public partial class Ektuposi1 : Form
    {
        public Ektuposi1()
        {
            InitializeComponent();
        }

        private void Ektuposi1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aPOTHIKI_4116DataSet2.PELATHS' table. You can move, or remove it, as needed.
            this.pELATHSTableAdapter.Fill(this.aPOTHIKI_4116DataSet2.PELATHS);

            this.reportViewer1.RefreshReport();
        }
    }
}
