
namespace Client
{
    partial class coinGraphForm
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.ct_Price = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.lbl_coinName = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.ct_Price)).BeginInit();
            this.SuspendLayout();
            // 
            // ct_Price
            // 
            chartArea2.Name = "ChartArea1";
            this.ct_Price.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.ct_Price.Legends.Add(legend2);
            this.ct_Price.Location = new System.Drawing.Point(23, 63);
            this.ct_Price.Name = "ct_Price";
            this.ct_Price.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Grayscale;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "coin_Price";
            this.ct_Price.Series.Add(series2);
            this.ct_Price.Size = new System.Drawing.Size(754, 364);
            this.ct_Price.TabIndex = 0;
            // 
            // lbl_coinName
            // 
            this.lbl_coinName.AutoSize = true;
            this.lbl_coinName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lbl_coinName.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.lbl_coinName.Location = new System.Drawing.Point(23, 29);
            this.lbl_coinName.Name = "lbl_coinName";
            this.lbl_coinName.Size = new System.Drawing.Size(111, 25);
            this.lbl_coinName.TabIndex = 1;
            this.lbl_coinName.Text = "metroLabel1";
            // 
            // coinGraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbl_coinName);
            this.Controls.Add(this.ct_Price);
            this.MaximizeBox = false;
            this.Name = "coinGraphForm";
            this.Resizable = false;
            this.Load += new System.EventHandler(this.coinGraphForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ct_Price)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart ct_Price;
        private MetroFramework.Controls.MetroLabel lbl_coinName;
    }
}