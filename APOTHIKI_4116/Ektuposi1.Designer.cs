namespace APOTHIKI_4116
{
    partial class Ektuposi1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.aPOTHIKI_4116DataSet2 = new APOTHIKI_4116.APOTHIKI_4116DataSet2();
            this.pELATHSBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pELATHSTableAdapter = new APOTHIKI_4116.APOTHIKI_4116DataSet2TableAdapters.PELATHSTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.aPOTHIKI_4116DataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pELATHSBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.DataBindings.Add(new System.Windows.Forms.Binding("Tag", this.pELATHSBindingSource, "KOD_PELATH", true));
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.pELATHSBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "APOTHIKI_4116.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(14, 15);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(2671, 750);
            this.reportViewer1.TabIndex = 0;
            // 
            // aPOTHIKI_4116DataSet2
            // 
            this.aPOTHIKI_4116DataSet2.DataSetName = "APOTHIKI_4116DataSet2";
            this.aPOTHIKI_4116DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pELATHSBindingSource
            // 
            this.pELATHSBindingSource.DataMember = "PELATHS";
            this.pELATHSBindingSource.DataSource = this.aPOTHIKI_4116DataSet2;
            // 
            // pELATHSTableAdapter
            // 
            this.pELATHSTableAdapter.ClearBeforeFill = true;
            // 
            // Ektuposi1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2697, 773);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Ektuposi1";
            this.Text = "Ektuposi1";
            this.Load += new System.EventHandler(this.Ektuposi1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.aPOTHIKI_4116DataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pELATHSBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private APOTHIKI_4116DataSet2 aPOTHIKI_4116DataSet2;
        private System.Windows.Forms.BindingSource pELATHSBindingSource;
        private APOTHIKI_4116DataSet2TableAdapters.PELATHSTableAdapter pELATHSTableAdapter;
    }
}