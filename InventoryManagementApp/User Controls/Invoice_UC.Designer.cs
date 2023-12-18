namespace InventoryManagementApp.User_Controls
{
    partial class Invoice_UC
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            label1 = new Label();
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(544, 300);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 0;
            label1.Text = "Invoice";
            // 
            // chart1
            // 
            chartArea3.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea3);
            chart1.ImeMode = ImeMode.NoControl;
            legend3.Name = "Legend1";
            chart1.Legends.Add(legend3);
            chart1.Location = new Point(272, 93);
            chart1.Name = "chart1";
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            chart1.Series.Add(series3);
            chart1.Size = new Size(450, 450);
            chart1.TabIndex = 1;
            chart1.Text = "chart1";
            // 
            // Invoice_UC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(chart1);
            Controls.Add(label1);
            Name = "Invoice_UC";
            Size = new Size(1275, 655);
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}
