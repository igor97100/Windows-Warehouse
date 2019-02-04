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

namespace APOTHIKI_4116
{
    public partial class FormIstorikoApothikis : Form
    {
        SqlConnection connection;
        SqlDataAdapter DataAdapter1, DataAdaper2;
        DataSet Dataset1, Dataset2;
        BindingSource BindingSource1, BindingSourcec2;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDataSet();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public FormIstorikoApothikis()
        {
            InitializeComponent();
            //fillDataSet();

            connection = new SqlConnection("Data Source=DESKTOP-4Q41NMN;Initial Catalog=APOTHIKI_4116;Integrated Security=True");
            connection.Open();

            DataAdapter1 = new SqlDataAdapter("Select * from APOTHIKH", connection);
            DataTable dt1 = new DataTable();
            DataAdapter1.Fill(dt1);
            comboBox1.DataSource = dt1;
            comboBox1.DisplayMember = "EIDOS";


        }
        public void fillDataSet()
        {
            DataAdaper2 = new SqlDataAdapter("SELECT dbo.APOTHIKH.EIDOS, " +
                "dbo.PROIONTA_PARAGELIAS.POSOTHTA,dbo.APOTHIKH.TIMH_POLHSHS,dbo.APOTHIKH.FPA, " +
                "dbo.PARAGELIA.HMER_PARAGELIAS, dbo.PARAGELIA.TROPOS_PLHROMHS, dbo.PARAGELIA.TOPOS_PARADOSHS, " +
                "dbo.PELATHS.EPONYMIA FROM dbo.PELATHS " +
                "INNER JOIN dbo.PARAGELIA ON dbo.PELATHS.KOD_PELATH = dbo.PARAGELIA.K_PEL" +
                " INNER JOIN dbo.PROIONTA_PARAGELIAS ON dbo.PARAGELIA.KOD_PAR = dbo.PROIONTA_PARAGELIAS.K_PAR " +
                "INNER JOIN dbo.APOTHIKH ON dbo.PROIONTA_PARAGELIAS.K_E = dbo.APOTHIKH.KE  " +
                "WHERE (dbo.APOTHIKH.EIDOS = '" + comboBox1.Text.ToString() + "')", connection);
            Dataset2 = new DataSet();
            DataAdaper2.Fill(Dataset2);
            BindingSourcec2 = new BindingSource();
            DataTable dt = new DataTable();
            BindingSourcec2.DataSource = Dataset2.Tables[0].DefaultView;
            dataGridView1.DataSource = BindingSourcec2;

            
            float sunolikoPoso = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                float timh;
                float posothta;
                float fpa;

                try
                {
                    timh = float.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    posothta = float.Parse(dataGridView1.Rows[i].Cells[2].Value.ToString());
                    fpa = float.Parse(dataGridView1.Rows[i].Cells[4].Value.ToString());

                    dataGridView1.Rows[i].Cells[0].Value = (timh * posothta + timh * posothta * fpa / 100).ToString();
                    sunolikoPoso += (timh * posothta + timh * posothta * fpa / 100);
                }
                catch (System.Exception e)
                {

                }
                label4.Text = sunolikoPoso.ToString();
                double posoXwrisFpa = ((float)sunolikoPoso / 1.24);
                label6.Text = posoXwrisFpa.ToString();
                label8.Text = (sunolikoPoso - posoXwrisFpa).ToString();
            }
            
        }

        private void FormIstorikoApothikis_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            dataGridView1.Columns.Add("TelikoPosoParagelias", "Teliko Poso Paragelias");
        }
    }
}
