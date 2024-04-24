using Guna.Charts.WinForms;
using Krypton.Toolkit;

namespace InventoryManagementApp.UI
{
    partial class Broken_Product
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            kryptonCustomPaletteBase1 = new KryptonCustomPaletteBase(components);
            Save_Btn = new KryptonButton();
            BrokenNumeric = new Guna.UI2.WinForms.Guna2NumericUpDown();
            prod_Label = new Label();
            prodName_Label = new Label();
            amount_Label = new Label();
            Desc_Label = new Label();
            label4 = new Label();
            brokenDesc_Txt = new KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)BrokenNumeric).BeginInit();
            SuspendLayout();
            // 
            // kryptonCustomPaletteBase1
            // 
            kryptonCustomPaletteBase1.BaseFont = new Font("Segoe UI", 9F);
            kryptonCustomPaletteBase1.BaseFontSize = 9F;
            kryptonCustomPaletteBase1.BasePaletteType = BasePaletteType.Custom;
            kryptonCustomPaletteBase1.ButtonSpecs.FormClose.Image = Properties.Resources.Red_28;
            kryptonCustomPaletteBase1.ButtonSpecs.FormClose.ImageStates.ImagePressed = Properties.Resources.Red_24;
            kryptonCustomPaletteBase1.ButtonSpecs.FormClose.ImageStates.ImageTracking = Properties.Resources.Red_24;
            kryptonCustomPaletteBase1.ButtonSpecs.FormMax.Image = Properties.Resources.Orange_28;
            kryptonCustomPaletteBase1.ButtonSpecs.FormMax.ImageStates.ImagePressed = Properties.Resources.Orange_24;
            kryptonCustomPaletteBase1.ButtonSpecs.FormMax.ImageStates.ImageTracking = Properties.Resources.Orange_24;
            kryptonCustomPaletteBase1.ButtonSpecs.FormMin.Image = Properties.Resources.Green_28;
            kryptonCustomPaletteBase1.ButtonSpecs.FormMin.ImageStates.ImagePressed = Properties.Resources.Green_24;
            kryptonCustomPaletteBase1.ButtonSpecs.FormMin.ImageStates.ImageTracking = Properties.Resources.Green_24;
            kryptonCustomPaletteBase1.ButtonSpecs.FormRestore.Image = Properties.Resources.Orange_28;
            kryptonCustomPaletteBase1.ButtonSpecs.FormRestore.ImageStates.ImagePressed = Properties.Resources.Orange_24;
            kryptonCustomPaletteBase1.ButtonSpecs.FormRestore.ImageStates.ImageTracking = Properties.Resources.Orange_24;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateNormal.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateNormal.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateNormal.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateNormal.Border.Width = 0;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StatePressed.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StatePressed.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StatePressed.Border.Width = 0;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateTracking.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateTracking.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonForm.StateTracking.Border.Width = 0;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonFormClose.StatePressed.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonFormClose.StatePressed.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonFormClose.StatePressed.Border.Color1 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonFormClose.StatePressed.Border.Color2 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonFormClose.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonFormClose.StateTracking.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonFormClose.StateTracking.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.ButtonStyles.ButtonFormClose.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.ButtonStyles.ButtonFormClose.StateTracking.Border.Width = 0;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateActive.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateActive.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateActive.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateActive.Border.GraphicsHint = PaletteGraphicsHint.None;
            kryptonCustomPaletteBase1.FormStyles.FormMain.StateActive.Border.Rounding = 12F;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.ButtonEdgeInset = 10;
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Content.Padding = new Padding(10, -1, -1, -1);
            kryptonCustomPaletteBase1.HeaderStyles.HeaderForm.StateCommon.Content.ShortText.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            kryptonCustomPaletteBase1.ThemeName = "";
            kryptonCustomPaletteBase1.UseKryptonFileDialogs = true;
            // 
            // Save_Btn
            // 
            Save_Btn.Location = new Point(468, 396);
            Save_Btn.Name = "Save_Btn";
            Save_Btn.OverrideDefault.Back.Color1 = Color.FromArgb(6, 174, 244);
            Save_Btn.OverrideDefault.Back.Color2 = Color.FromArgb(8, 142, 254);
            Save_Btn.OverrideDefault.Back.ColorAngle = 45F;
            Save_Btn.OverrideDefault.Border.Color1 = Color.FromArgb(6, 174, 244);
            Save_Btn.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            Save_Btn.OverrideDefault.Border.ColorAngle = 45F;
            Save_Btn.OverrideDefault.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            Save_Btn.OverrideDefault.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            Save_Btn.OverrideDefault.Border.Rounding = 20F;
            Save_Btn.OverrideDefault.Border.Width = 1;
            Save_Btn.PaletteMode = PaletteMode.ProfessionalSystem;
            Save_Btn.Size = new Size(160, 52);
            Save_Btn.StateCommon.Back.Color1 = Color.FromArgb(6, 174, 244);
            Save_Btn.StateCommon.Back.Color2 = Color.FromArgb(8, 142, 254);
            Save_Btn.StateCommon.Back.ColorAngle = 45F;
            Save_Btn.StateCommon.Border.Color1 = Color.FromArgb(6, 174, 244);
            Save_Btn.StateCommon.Border.Color2 = Color.FromArgb(8, 142, 254);
            Save_Btn.StateCommon.Border.ColorAngle = 45F;
            Save_Btn.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            Save_Btn.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            Save_Btn.StateCommon.Border.Rounding = 20F;
            Save_Btn.StateCommon.Border.Width = 1;
            Save_Btn.StateCommon.Content.ShortText.Color1 = Color.White;
            Save_Btn.StateCommon.Content.ShortText.Color2 = Color.White;
            Save_Btn.StateCommon.Content.ShortText.Font = new Font("Georgia", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Save_Btn.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            Save_Btn.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            Save_Btn.StatePressed.Back.ColorAngle = 135F;
            Save_Btn.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            Save_Btn.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            Save_Btn.StatePressed.Border.ColorAngle = 135F;
            Save_Btn.StatePressed.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            Save_Btn.StatePressed.Border.Rounding = 20F;
            Save_Btn.StatePressed.Border.Width = 1;
            Save_Btn.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            Save_Btn.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            Save_Btn.StateTracking.Back.ColorAngle = 45F;
            Save_Btn.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            Save_Btn.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            Save_Btn.StateTracking.Border.ColorAngle = 45F;
            Save_Btn.StateTracking.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            Save_Btn.StateTracking.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            Save_Btn.StateTracking.Border.Rounding = 20F;
            Save_Btn.StateTracking.Border.Width = 1;
            Save_Btn.TabIndex = 6;
            Save_Btn.Values.Text = "შენახვა";
            Save_Btn.Click += Save_Btn_Click;
            // 
            // BrokenNumeric
            // 
            BrokenNumeric.BackColor = Color.Transparent;
            BrokenNumeric.BorderRadius = 5;
            BrokenNumeric.CustomizableEdges = customizableEdges5;
            BrokenNumeric.Font = new Font("Segoe UI", 9F);
            BrokenNumeric.Location = new Point(463, 194);
            BrokenNumeric.Margin = new Padding(4, 5, 4, 5);
            BrokenNumeric.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            BrokenNumeric.Name = "BrokenNumeric";
            BrokenNumeric.ShadowDecoration.CustomizableEdges = customizableEdges6;
            BrokenNumeric.Size = new Size(103, 34);
            BrokenNumeric.TabIndex = 11;
            // 
            // prod_Label
            // 
            prod_Label.AutoSize = true;
            prod_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prod_Label.ForeColor = Color.FromArgb(64, 64, 64);
            prod_Label.Location = new Point(12, 152);
            prod_Label.Name = "prod_Label";
            prod_Label.Size = new Size(135, 25);
            prod_Label.TabIndex = 67;
            prod_Label.Text = "პროდუქტი: ";
            // 
            // prodName_Label
            // 
            prodName_Label.AutoSize = true;
            prodName_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prodName_Label.ForeColor = Color.FromArgb(64, 64, 64);
            prodName_Label.Location = new Point(168, 152);
            prodName_Label.Name = "prodName_Label";
            prodName_Label.Size = new Size(138, 25);
            prodName_Label.TabIndex = 68;
            prodName_Label.Text = "დასახელება";
            // 
            // amount_Label
            // 
            amount_Label.AutoSize = true;
            amount_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amount_Label.ForeColor = Color.FromArgb(64, 64, 64);
            amount_Label.Location = new Point(12, 197);
            amount_Label.Name = "amount_Label";
            amount_Label.Size = new Size(424, 25);
            amount_Label.TabIndex = 69;
            amount_Label.Text = "დაზიანებული პროდუქციის რაოდენობა:";
            // 
            // Desc_Label
            // 
            Desc_Label.AutoSize = true;
            Desc_Label.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Desc_Label.ForeColor = Color.FromArgb(64, 64, 64);
            Desc_Label.Location = new Point(12, 248);
            Desc_Label.Name = "Desc_Label";
            Desc_Label.Size = new Size(227, 25);
            Desc_Label.TabIndex = 70;
            Desc_Label.Text = "დაზიანების აღწერა: ";
            // 
            // label4
            // 
            label4.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(64, 64, 64);
            label4.Location = new Point(-10, 25);
            label4.Name = "label4";
            label4.Size = new Size(651, 87);
            label4.TabIndex = 71;
            label4.Text = "დაზიანებული პროდუქტების \r\nაღრიცხვა";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // brokenDesc_Txt
            // 
            brokenDesc_Txt.Location = new Point(12, 297);
            brokenDesc_Txt.Multiline = true;
            brokenDesc_Txt.Name = "brokenDesc_Txt";
            brokenDesc_Txt.Size = new Size(616, 57);
            brokenDesc_Txt.StateCommon.Back.Color1 = Color.White;
            brokenDesc_Txt.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            brokenDesc_Txt.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            brokenDesc_Txt.StateCommon.Border.DrawBorders = PaletteDrawBorders.Top | PaletteDrawBorders.Bottom | PaletteDrawBorders.Left | PaletteDrawBorders.Right;
            brokenDesc_Txt.StateCommon.Border.GraphicsHint = PaletteGraphicsHint.AntiAlias;
            brokenDesc_Txt.StateCommon.Border.Rounding = 20F;
            brokenDesc_Txt.StateCommon.Border.Width = 1;
            brokenDesc_Txt.StateCommon.Content.Color1 = Color.Gray;
            brokenDesc_Txt.StateCommon.Content.Font = new Font("Georgia", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            brokenDesc_Txt.StateCommon.Content.Padding = new Padding(10, 0, 20, 20);
            brokenDesc_Txt.TabIndex = 72;
            // 
            // Broken_Product
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 252, 252);
            ClientSize = new Size(630, 473);
            Controls.Add(brokenDesc_Txt);
            Controls.Add(label4);
            Controls.Add(Desc_Label);
            Controls.Add(amount_Label);
            Controls.Add(prodName_Label);
            Controls.Add(prod_Label);
            Controls.Add(BrokenNumeric);
            Controls.Add(Save_Btn);
            Name = "Broken_Product";
            Palette = kryptonCustomPaletteBase1;
            PaletteMode = PaletteMode.Custom;
            ShowIcon = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "ჯანი - მარაგების მენეჯმენტი";
            Load += Broken_Product_Load;
            ((System.ComponentModel.ISupportInitialize)BrokenNumeric).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonCustomPaletteBase kryptonCustomPaletteBase1;
        private Krypton.Toolkit.KryptonButton Save_Btn;
        private Guna.UI2.WinForms.Guna2NumericUpDown BrokenNumeric;
        private Label prod_Label;
        private Label prodName_Label;
        private Label amount_Label;
        private Label Desc_Label;
        private Label label4;
        private KryptonTextBox brokenDesc_Txt;
    }
}