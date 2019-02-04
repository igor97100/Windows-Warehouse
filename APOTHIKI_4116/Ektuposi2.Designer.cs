namespace APOTHIKI_4116
{
    partial class Ektuposi2
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
            this.APOTHIKI_4116DataSet5 = new APOTHIKI_4116.APOTHIKI_4116DataSet5();
            this.APOTHIKHBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.APOTHIKHTableAdapter = new APOTHIKI_4116.APOTHIKI_4116DataSet5TableAdapters.APOTHIKHTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.APOTHIKI_4116DataSet5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.APOTHIKHBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet2";
            reportDataSource1.Value = this.APOTHIKHBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "APOTHIKI_4116.Report2.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, 14);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1420, 804);
            this.reportViewer1.TabIndex = 0;
            // 
            // APOTHIKI_4116DataSet5
            // 
            this.APOTHIKI_4116DataSet5.DataSetName = "APOTHIKI_4116DataSet5";
            this.APOTHIKI_4116DataSet5.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // APOTHIKHBindingSource
            // 
            this.APOTHIKHBindingSource.DataMember = "APOTHIKH";
            this.APOTHIKHBindingSource.DataSource = this.APOTHIKI_4116DataSet5;
            // 
            // APOTHIKHTableAdapter
            // 
            this.APOTHIKHTableAdapter.ClearBeforeFill = true;
            // 
            // Ektuposi2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1435, 828);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Ektuposi2";
            this.Text = "Ektuposi2";
            this.Load += new System.EventHandler(this.Ektuposi2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.APOTHIKI_4116DataSet5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.APOTHIKHBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource APOTHIKHBindingSource;
        private APOTHIKI_4116DataSet5 APOTHIKI_4116DataSet5;
        private APOTHIKI_4116DataSet5TableAdapters.APOTHIKHTableAdapter APOTHIKHTableAdapter;
    }
}