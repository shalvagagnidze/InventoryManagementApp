namespace InventoryManagementApp.User_Controls
{
    partial class Dashboard_UC
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.Charts.WinForms.ChartFont chartFont1 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont2 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont3 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont4 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid1 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick1 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont5 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid2 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick2 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont6 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid3 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.PointLabel pointLabel1 = new Guna.Charts.WinForms.PointLabel();
            Guna.Charts.WinForms.ChartFont chartFont7 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Tick tick3 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont8 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.LPoint lPoint1 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint2 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint3 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint4 = new Guna.Charts.WinForms.LPoint();
            Guna.Charts.WinForms.LPoint lPoint5 = new Guna.Charts.WinForms.LPoint();
            addProd_Label = new Label();
            packPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            packIcon = new PictureBox();
            packLabel = new Label();
            packText = new Label();
            shippedPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            shippingIcon = new PictureBox();
            shippingLabel = new Label();
            shippingText = new Label();
            deliveredPanel = new Guna.UI2.WinForms.Guna2GradientPanel();
            deliveredIcon = new PictureBox();
            deliveredLabel = new Label();
            deliveryText = new Label();
            gunaChart1 = new Guna.Charts.WinForms.GunaChart();
            gunaSplineAreaDataset1 = new Guna.Charts.WinForms.GunaSplineAreaDataset();
            packPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)packIcon).BeginInit();
            shippedPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)shippingIcon).BeginInit();
            deliveredPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)deliveredIcon).BeginInit();
            SuspendLayout();
            // 
            // addProd_Label
            // 
            addProd_Label.AutoSize = true;
            addProd_Label.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addProd_Label.ForeColor = Color.FromArgb(64, 64, 64);
            addProd_Label.Location = new Point(3, 9);
            addProd_Label.Name = "addProd_Label";
            addProd_Label.Size = new Size(320, 32);
            addProd_Label.TabIndex = 36;
            addProd_Label.Text = "შეკვეთების აქტივობა:";
            // 
            // packPanel
            // 
            packPanel.BorderRadius = 20;
            packPanel.Controls.Add(packIcon);
            packPanel.Controls.Add(packLabel);
            packPanel.Controls.Add(packText);
            packPanel.CustomizableEdges = customizableEdges1;
            packPanel.FillColor = Color.FromArgb(238, 39, 39);
            packPanel.FillColor2 = Color.FromArgb(238, 39, 39);
            packPanel.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            packPanel.Location = new Point(10, 70);
            packPanel.Name = "packPanel";
            packPanel.ShadowDecoration.CustomizableEdges = customizableEdges2;
            packPanel.Size = new Size(201, 134);
            packPanel.TabIndex = 37;
            // 
            // packIcon
            // 
            packIcon.BackColor = Color.FromArgb(238, 39, 39);
            packIcon.Image = Properties.Resources.Package_28;
            packIcon.Location = new Point(18, 91);
            packIcon.Name = "packIcon";
            packIcon.Size = new Size(28, 28);
            packIcon.SizeMode = PictureBoxSizeMode.AutoSize;
            packIcon.TabIndex = 39;
            packIcon.TabStop = false;
            // 
            // packLabel
            // 
            packLabel.AutoSize = true;
            packLabel.BackColor = Color.FromArgb(238, 39, 39);
            packLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            packLabel.ForeColor = Color.White;
            packLabel.ImageAlign = ContentAlignment.MiddleLeft;
            packLabel.Location = new Point(52, 91);
            packLabel.Name = "packLabel";
            packLabel.Size = new Size(108, 25);
            packLabel.TabIndex = 40;
            packLabel.Text = "მზადდება";
            // 
            // packText
            // 
            packText.BackColor = Color.FromArgb(238, 39, 39);
            packText.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            packText.ForeColor = Color.White;
            packText.Location = new Point(0, 28);
            packText.Name = "packText";
            packText.Size = new Size(198, 54);
            packText.TabIndex = 39;
            packText.Text = "0";
            packText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // shippedPanel
            // 
            shippedPanel.BorderRadius = 20;
            shippedPanel.Controls.Add(shippingIcon);
            shippedPanel.Controls.Add(shippingLabel);
            shippedPanel.Controls.Add(shippingText);
            shippedPanel.CustomizableEdges = customizableEdges3;
            shippedPanel.FillColor = Color.FromArgb(248, 137, 15);
            shippedPanel.FillColor2 = Color.FromArgb(248, 137, 15);
            shippedPanel.Location = new Point(267, 70);
            shippedPanel.Name = "shippedPanel";
            shippedPanel.ShadowDecoration.CustomizableEdges = customizableEdges4;
            shippedPanel.Size = new Size(201, 134);
            shippedPanel.TabIndex = 38;
            // 
            // shippingIcon
            // 
            shippingIcon.BackColor = Color.FromArgb(248, 137, 15);
            shippingIcon.Image = Properties.Resources.Shipping_28;
            shippingIcon.Location = new Point(28, 91);
            shippingIcon.Name = "shippingIcon";
            shippingIcon.Size = new Size(28, 28);
            shippingIcon.SizeMode = PictureBoxSizeMode.AutoSize;
            shippingIcon.TabIndex = 41;
            shippingIcon.TabStop = false;
            // 
            // shippingLabel
            // 
            shippingLabel.AutoSize = true;
            shippingLabel.BackColor = Color.FromArgb(248, 137, 15);
            shippingLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            shippingLabel.ForeColor = Color.White;
            shippingLabel.ImageAlign = ContentAlignment.MiddleLeft;
            shippingLabel.Location = new Point(65, 94);
            shippingLabel.Name = "shippingLabel";
            shippingLabel.Size = new Size(78, 25);
            shippingLabel.TabIndex = 42;
            shippingLabel.Text = "გზაშია";
            // 
            // shippingText
            // 
            shippingText.BackColor = Color.FromArgb(248, 137, 15);
            shippingText.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            shippingText.ForeColor = Color.White;
            shippingText.Location = new Point(0, 28);
            shippingText.Name = "shippingText";
            shippingText.Size = new Size(201, 54);
            shippingText.TabIndex = 40;
            shippingText.Text = "0";
            shippingText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // deliveredPanel
            // 
            deliveredPanel.BorderRadius = 20;
            deliveredPanel.Controls.Add(deliveredIcon);
            deliveredPanel.Controls.Add(deliveredLabel);
            deliveredPanel.Controls.Add(deliveryText);
            deliveredPanel.CustomizableEdges = customizableEdges5;
            deliveredPanel.FillColor = Color.FromArgb(29, 206, 61);
            deliveredPanel.FillColor2 = Color.FromArgb(29, 206, 61);
            deliveredPanel.Location = new Point(510, 70);
            deliveredPanel.Name = "deliveredPanel";
            deliveredPanel.ShadowDecoration.CustomizableEdges = customizableEdges6;
            deliveredPanel.Size = new Size(201, 134);
            deliveredPanel.TabIndex = 38;
            // 
            // deliveredIcon
            // 
            deliveredIcon.BackColor = Color.FromArgb(29, 206, 61);
            deliveredIcon.Image = Properties.Resources.Delivery_28;
            deliveredIcon.Location = new Point(13, 91);
            deliveredIcon.Name = "deliveredIcon";
            deliveredIcon.Size = new Size(28, 28);
            deliveredIcon.SizeMode = PictureBoxSizeMode.AutoSize;
            deliveredIcon.TabIndex = 41;
            deliveredIcon.TabStop = false;
            // 
            // deliveredLabel
            // 
            deliveredLabel.AutoSize = true;
            deliveredLabel.BackColor = Color.FromArgb(29, 206, 61);
            deliveredLabel.Font = new Font("Segoe UI", 8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 0);
            deliveredLabel.ForeColor = Color.White;
            deliveredLabel.ImageAlign = ContentAlignment.MiddleLeft;
            deliveredLabel.Location = new Point(47, 97);
            deliveredLabel.Name = "deliveredLabel";
            deliveredLabel.Size = new Size(135, 21);
            deliveredLabel.TabIndex = 42;
            deliveredLabel.Text = "მიწოდებულია";
            // 
            // deliveryText
            // 
            deliveryText.BackColor = Color.FromArgb(29, 206, 61);
            deliveryText.Font = new Font("Segoe UI", 20F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deliveryText.ForeColor = Color.White;
            deliveryText.Location = new Point(0, 28);
            deliveryText.Name = "deliveryText";
            deliveryText.Size = new Size(201, 54);
            deliveryText.TabIndex = 40;
            deliveryText.Text = "0";
            deliveryText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // gunaChart1
            // 
            chartFont1.FontName = "Arial";
            gunaChart1.Legend.LabelFont = chartFont1;
            gunaChart1.Location = new Point(28, 235);
            gunaChart1.Name = "gunaChart1";
            gunaChart1.Size = new Size(628, 390);
            gunaChart1.TabIndex = 39;
            chartFont2.FontName = "Arial";
            chartFont2.Size = 12;
            chartFont2.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            gunaChart1.Title.Font = chartFont2;
            chartFont3.FontName = "Arial";
            gunaChart1.Tooltips.BodyFont = chartFont3;
            chartFont4.FontName = "Arial";
            chartFont4.Size = 9;
            chartFont4.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            gunaChart1.Tooltips.TitleFont = chartFont4;
            gunaChart1.XAxes.GridLines = grid1;
            chartFont5.FontName = "Arial";
            tick1.Font = chartFont5;
            gunaChart1.XAxes.Ticks = tick1;
            gunaChart1.YAxes.GridLines = grid2;
            chartFont6.FontName = "Arial";
            tick2.Font = chartFont6;
            gunaChart1.YAxes.Ticks = tick2;
            gunaChart1.ZAxes.GridLines = grid3;
            chartFont7.FontName = "Arial";
            pointLabel1.Font = chartFont7;
            gunaChart1.ZAxes.PointLabels = pointLabel1;
            chartFont8.FontName = "Arial";
            tick3.Font = chartFont8;
            gunaChart1.ZAxes.Ticks = tick3;
            // 
            // gunaSplineAreaDataset1
            // 
            gunaSplineAreaDataset1.BorderColor = Color.Empty;
            lPoint1.Y = 0D;
            lPoint2.Y = 5D;
            lPoint3.Y = 10D;
            lPoint4.Y = 20D;
            lPoint5.Y = 50D;
            gunaSplineAreaDataset1.DataPoints.AddRange(new Guna.Charts.WinForms.LPoint[] { lPoint1, lPoint2, lPoint3, lPoint4, lPoint5 });
            gunaSplineAreaDataset1.FillColor = Color.Empty;
            gunaSplineAreaDataset1.Label = "SplineArea1";
            // 
            // Dashboard_UC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(gunaChart1);
            Controls.Add(deliveredPanel);
            Controls.Add(shippedPanel);
            Controls.Add(packPanel);
            Controls.Add(addProd_Label);
            Name = "Dashboard_UC";
            Size = new Size(1275, 655);
            packPanel.ResumeLayout(false);
            packPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)packIcon).EndInit();
            shippedPanel.ResumeLayout(false);
            shippedPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)shippingIcon).EndInit();
            deliveredPanel.ResumeLayout(false);
            deliveredPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)deliveredIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label addProd_Label;
        private Guna.UI2.WinForms.Guna2GradientPanel packPanel;
        private Guna.UI2.WinForms.Guna2GradientPanel shippedPanel;
        private Guna.UI2.WinForms.Guna2GradientPanel deliveredPanel;
        private Label packText;
        private Label shippingText;
        private Label deliveryText;
        private Label packLabel;
        private PictureBox packIcon;
        private PictureBox shippingIcon;
        private Label shippingLabel;
        private PictureBox deliveredIcon;
        private Label deliveredLabel;
        private Guna.Charts.WinForms.GunaChart gunaChart1;
        private Guna.Charts.WinForms.GunaSplineAreaDataset gunaSplineAreaDataset1;
    }
}
