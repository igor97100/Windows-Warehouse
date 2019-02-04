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
using System.IO;

namespace APOTHIKI_4116
    
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        FormIstorikoPelatwn frmIsoriko;
        FormIstorikoApothikis frmApothiki;
        Ektuposi1 frmEktuposi1;
        Ektuposi2 frmEktuposi2;

        public Form1()
        {
            InitializeComponent();
            connection = new SqlConnection("Data Source=DESKTOP-4Q41NMN;Initial Catalog=APOTHIKI_4116;Integrated Security=True");
            connection.Open();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label32_Click(object sender, EventArgs e)
        {

        }

        private void label28_Click(object sender, EventArgs e)
        {

        }

        private void label29_Click(object sender, EventArgs e)
        {

        }

        private void label30_Click(object sender, EventArgs e)
        {

        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void textBox27_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox31_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox35_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'aPOTHIKI_4116DataSet2.PELATHS' table. You can move, or remove it, as needed.
            this.pELATHSTableAdapter.Fill(this.aPOTHIKI_4116DataSet1.PELATHS);
            // TODO: This line of code loads data into the 'aPOTHIKI_4116DataSet5.APOTHIKH' table. You can move, or remove it, as needed.
            this.aPOTHIKHTableAdapter1.Fill(this.aPOTHIKI_4116DataSet5.APOTHIKH);
            // TODO: This line of code loads data into the 'aPOTHIKI_4116DataSet3.PARAGELIA' table. You can move, or remove it, as needed.
            this.pARAGELIATableAdapter1.Fill(this.aPOTHIKI_4116DataSet3.PARAGELIA);
            // TODO: This line of code loads data into the 'aPOTHIKI_4116DataSet2.PROIONTA_PARAGELIAS' table. You can move, or remove it, as needed.
            this.pROIONTA_PARAGELIASTableAdapter.Fill(this.aPOTHIKI_4116DataSet2.PROIONTA_PARAGELIAS);
            // TODO: This line of code loads data into the 'aPOTHIKI_4116DataSet2.APOTHIKH' table. You can move, or remove it, as needed.
            this.aPOTHIKHTableAdapter.Fill(this.aPOTHIKI_4116DataSet2.APOTHIKH);
            // TODO: This line of code loads data into the 'aPOTHIKI_4116DataSet2.PELATHS' table. You can move, or remove it, as needed.
            this.pELATHSTableAdapter1.Fill(this.aPOTHIKI_4116DataSet2.PELATHS);
            refreshImagePelath();
            refreshImageApothiki();



            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.pELATHSBindingSource3.EndEdit();
                this.pELATHSTableAdapter1.Update(this.aPOTHIKI_4116DataSet2.PELATHS);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {
            refreshImageApothiki();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.aPOTHIKHBindingSource2.EndEdit();
                this.aPOTHIKHTableAdapter1.Update(this.aPOTHIKI_4116DataSet5.APOTHIKH);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.pARAGELIABindingSource3.EndEdit();
                this.pARAGELIATableAdapter1.Update(this.aPOTHIKI_4116DataSet3.PARAGELIA);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.pROIONTAPARAGELIASBindingSource.EndEdit();
                this.pROIONTA_PARAGELIASTableAdapter.Update(this.aPOTHIKI_4116DataSet2.PROIONTA_PARAGELIAS);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmIsoriko = new FormIstorikoPelatwn();
            frmIsoriko.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmApothiki = new FormIstorikoApothikis();
            frmApothiki.Show();
        }
        public void refreshImagePelath()
        {
            String photoPath = textBox16.Text.Trim();
            if (photoPath != null && File.Exists(photoPath))
            {
                pictureBox1.Image = Image.FromFile(photoPath);
            }
            else
            {
                pictureBox1.Image = Image.FromFile(@"C:/Users/Igor/Desktop/Sign-Error-icon.png");
            }
        }
        public void refreshImageApothiki()
        {
            String photoPath = textBox1.Text.Trim();
            if (photoPath != null && File.Exists(photoPath))
            {
                pictureBox2.Image = Image.FromFile(photoPath);
            }
            else
            {
                pictureBox2.Image = Image.FromFile(@"C:/Users/Igor/Desktop/Sign-Error-icon.png");
            }
        }
        public void refreshImageApothiki(object sender, EventArgs e)
        {
            String photoPath = textBox1.Text.Trim();
            if (photoPath != null && File.Exists(photoPath))
            {
                pictureBox2.Image = Image.FromFile(photoPath);
            }
            else
            {
                pictureBox2.Image = Image.FromFile(@"C:/Users/Igor/Desktop/Sign-Error-icon.png");
            }
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String openPath;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openPath = openFileDialog1.InitialDirectory +openFileDialog1.FileName;
                textBox16.Text = openPath;
                pictureBox1.Image = Image.FromFile(openPath);

                try
                {
                    this.Validate();
                    this.pELATHSBindingSource2.EndEdit();
                    this.pELATHSTableAdapter1.Update(this.aPOTHIKI_4116DataSet2.PELATHS);
                    MessageBox.Show("Update successful");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Update failed");
                }

            }
        }
        private void bindingNavigator1_RefreshItems_1(object sender, EventArgs e)
        {
            refreshImagePelath();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            String openPath;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openPath = openFileDialog1.InitialDirectory + openFileDialog1.FileName;
                textBox1.Text = openPath;
                pictureBox2.Image = Image.FromFile(openPath);

                try
                {
                    this.Validate();
                    this.aPOTHIKHBindingSource2.EndEdit();
                    this.aPOTHIKHTableAdapter1.Update(this.aPOTHIKI_4116DataSet5.APOTHIKH);
                    MessageBox.Show("Update successful");
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show("Update failed");
                }

            }
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void bindingNavigator2_RefreshItems(object sender, EventArgs e)
        {
            refreshImageApothiki();
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.pELATHSBindingSource3.EndEdit();
                this.pELATHSTableAdapter1.Update(this.aPOTHIKI_4116DataSet2.PELATHS);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            
        }

        private void bindingNavigatorDeleteItem1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.aPOTHIKHBindingSource2.EndEdit();
                this.aPOTHIKHTableAdapter1.Update(this.aPOTHIKI_4116DataSet5.APOTHIKH);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void bindingNavigatorDeleteItem2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.pARAGELIABindingSource3.EndEdit();
                this.pARAGELIATableAdapter1.Update(this.aPOTHIKI_4116DataSet3.PARAGELIA);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }

        private void bindingNavigatorDeleteItem3_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.pROIONTAPARAGELIASBindingSource.EndEdit();
                this.pROIONTA_PARAGELIASTableAdapter.Update(this.aPOTHIKI_4116DataSet2.PROIONTA_PARAGELIAS);
                MessageBox.Show("Update successful");
            }
            catch (System.Exception ex)
            {
                MessageBox.Show("Update failed");
            }
        }
    }
}
