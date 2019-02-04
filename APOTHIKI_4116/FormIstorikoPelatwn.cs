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
    public partial class FormIstorikoPelatwn : Form
    {
        SqlConnection connection;
        SqlDataAdapter DataAdapter1, DataAdaper2;
        DataSet Dataset1, Dataset2;
        BindingSource BindingSource1, BindingSourcec2;

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            fillDataSet();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        public void fillDataSet()
        {
            DataAdaper2 = new SqlDataAdapter("SELECT dbo.PELATHS.EPONYMIA," +
                " dbo.PELATHS.AFM, dbo.PROIONTA_PARAGELIAS.POSOTHTA," +
                " dbo.APOTHIKH.EIDOS, dbo.APOTHIKH.TIMH_POLHSHS," +
                " dbo.APOTHIKH.FPA FROM dbo.PELATHS " +
                "INNER JOIN dbo.PARAGELIA ON dbo.PELATHS.KOD_PELATH = dbo.PARAGELIA.K_PEL " +
                "INNER JOIN dbo.PROIONTA_PARAGELIAS ON dbo.PARAGELIA.KOD_PAR = dbo.PROIONTA_PARAGELIAS.K_PAR " +
                "INNER JOIN dbo.APOTHIKH ON dbo.PROIONTA_PARAGELIAS.K_E = dbo.APOTHIKH.KE " +
                "WHERE (dbo.PELATHS.EPONYMIA = '" + comboBox1.Text.ToString() + "')" , connection);
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
                    timh = float.Parse(dataGridView1.Rows[i].Cells[5].Value.ToString());
                    posothta = float.Parse(dataGridView1.Rows[i].Cells[3].Value.ToString());
                    fpa = float.Parse(dataGridView1.Rows[i].Cells[6].Value.ToString());

                    dataGridView1.Rows[i].Cells[0].Value = (timh*posothta + timh * posothta * fpa / 100).ToString();
                    sunolikoPoso += (timh * posothta + timh * posothta * fpa / 100);
                }
                catch (System.Exception e)
                {
                    
                }
                label12.Text = sunolikoPoso.ToString();
                double posoXwrisFpa = ((float)sunolikoPoso / 1.24);
                label10.Text = posoXwrisFpa.ToString();
                label8.Text = (sunolikoPoso - posoXwrisFpa).ToString();
            }
        }
        public FormIstorikoPelatwn()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=DESKTOP-4Q41NMN;Initial Catalog=APOTHIKI_4116;Integrated Security=True");
            connection.Open();

            DataAdapter1 = new SqlDataAdapter("Select * from PELATHS", connection);
            DataTable dt1 = new DataTable();
            DataAdapter1.Fill(dt1);
            comboBox1.DataSource = dt1;
            comboBox1.DisplayMember = "EPONYMIA";
        }
        private void FormIstorikoPelatwn_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            dataGridView1.Columns.Add("TelikoPoso", "Teliko Poso ");
        }
    }
}
