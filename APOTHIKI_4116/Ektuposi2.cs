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
    public partial class Ektuposi2 : Form
    {
        public Ektuposi2()
        {
            InitializeComponent();
        }

        private void Ektuposi2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'APOTHIKI_4116DataSet5.APOTHIKH' table. You can move, or remove it, as needed.
            this.APOTHIKHTableAdapter.Fill(this.APOTHIKI_4116DataSet5.APOTHIKH);

            this.reportViewer1.RefreshReport();
        }
    }
}
