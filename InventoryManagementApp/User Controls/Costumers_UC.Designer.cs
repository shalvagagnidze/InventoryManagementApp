namespace InventoryManagementApp.User_Controls
{
    partial class Costumers_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Costumers_UC));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            search_Icon = new PictureBox();
            Search_Txt = new Krypton.Toolkit.KryptonTextBox();
            costumersData = new Krypton.Toolkit.KryptonDataGridView();
            downloadExel = new Krypton.Toolkit.KryptonButton();
            location = new Guna.UI2.WinForms.Guna2ComboBox();
            ((System.ComponentModel.ISupportInitialize)search_Icon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)costumersData).BeginInit();
            SuspendLayout();
            // 
            // search_Icon
            // 
            search_Icon.Image = Properties.Resources.Search_40;
            search_Icon.Location = new Point(3, 34);
            search_Icon.Name = "search_Icon";
            search_Icon.Size = new Size(55, 39);
            search_Icon.SizeMode = PictureBoxSizeMode.Zoom;
            search_Icon.TabIndex = 18;
            search_Icon.TabStop = false;
            // 
            // Search_Txt
            // 
            Search_Txt.Location = new Point(74, 34);
            Search_Txt.Multiline = true;
            Search_Txt.Name = "Search_Txt";
            Search_Txt.Size = new Size(560, 39);
            Search_Txt.StateCommon.Back.Color1 = Color.White;
            Search_Txt.StateCommon.Border.Color1 = Color.FromArgb(210, 210, 210);
            Search_Txt.StateCommon.Border.Color2 = Color.FromArgb(210, 210, 210);
            Search_Txt.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            Search_Txt.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            Search_Txt.StateCommon.Border.Rounding = 13F;
            Search_Txt.StateCommon.Border.Width = 1;
            Search_Txt.StateCommon.Content.Color1 = Color.Gray;
            Search_Txt.StateCommon.Content.Font = new Font("Georgia", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            Search_Txt.StateCommon.Content.Padding = new Padding(10, 0, 10, 7);
            Search_Txt.TabIndex = 17;
            Search_Txt.TextChanged += Search_Txt_TextChanged;
            // 
            // costumersData
            // 
            costumersData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            costumersData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            costumersData.BorderStyle = BorderStyle.None;
            costumersData.ColumnHeadersHeight = 51;
            costumersData.ImeMode = ImeMode.On;
            costumersData.Location = new Point(3, 120);
            costumersData.Name = "costumersData";
            costumersData.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            costumersData.ReadOnly = true;
            costumersData.RowHeadersWidth = 62;
            costumersData.RowTemplate.DividerHeight = 3;
            costumersData.RowTemplate.Resizable = DataGridViewTriState.False;
            costumersData.Size = new Size(1369, 632);
            costumersData.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            costumersData.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            costumersData.StateCommon.DataCell.Border.Rounding = 5F;
            costumersData.StateCommon.DataCell.Border.Width = 1;
            costumersData.StateCommon.DataCell.Content.Color1 = Color.FromArgb(64, 64, 64);
            costumersData.StateCommon.DataCell.Content.Font = new Font("Georgia", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            costumersData.TabIndex = 19;
            // 
            // downloadExel
            // 
            downloadExel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            downloadExel.Location = new Point(1108, 14);
            downloadExel.Name = "downloadExel";
            downloadExel.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            downloadExel.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            downloadExel.OverrideDefault.Back.ColorAngle = 45F;
            downloadExel.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            downloadExel.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            downloadExel.OverrideDefault.Border.ColorAngle = 45F;
            downloadExel.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            downloadExel.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            downloadExel.OverrideDefault.Border.Rounding = 20F;
            downloadExel.OverrideDefault.Border.Width = 2;
            downloadExel.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            downloadExel.Size = new Size(241, 72);
            downloadExel.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            downloadExel.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            downloadExel.StateCommon.Back.ColorAngle = 45F;
            downloadExel.StateCommon.Border.Color1 = Color.FromArgb(17, 151, 71);
            downloadExel.StateCommon.Border.Color2 = Color.FromArgb(17, 151, 71);
            downloadExel.StateCommon.Border.ColorAngle = 45F;
            downloadExel.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            downloadExel.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            downloadExel.StateCommon.Border.Rounding = 22F;
            downloadExel.StateCommon.Border.Width = 3;
            downloadExel.StateCommon.Content.ShortText.Color1 = Color.FromArgb(17, 151, 71);
            downloadExel.StateCommon.Content.ShortText.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            downloadExel.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            downloadExel.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            downloadExel.StatePressed.Back.ColorAngle = 135F;
            downloadExel.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            downloadExel.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            downloadExel.StatePressed.Border.ColorAngle = 135F;
            downloadExel.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            downloadExel.StatePressed.Border.Rounding = 20F;
            downloadExel.StatePressed.Border.Width = 1;
            downloadExel.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            downloadExel.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            downloadExel.StateTracking.Back.ColorAngle = 45F;
            downloadExel.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            downloadExel.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            downloadExel.StateTracking.Border.ColorAngle = 45F;
            downloadExel.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            downloadExel.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            downloadExel.StateTracking.Border.Rounding = 20F;
            downloadExel.StateTracking.Border.Width = 1;
            downloadExel.StateTracking.Content.ShortText.Color1 = Color.White;
            downloadExel.TabIndex = 20;
            downloadExel.Values.ExtraText = "  ";
            downloadExel.Values.Image = (Image)resources.GetObject("downloadExel.Values.Image");
            downloadExel.Values.Text = "  გადმოწერა";
            downloadExel.Click += downloadExel_Click;
            // 
            // location
            // 
            location.BackColor = Color.Transparent;
            location.BorderRadius = 5;
            location.CustomizableEdges = customizableEdges1;
            location.DrawMode = DrawMode.OwnerDrawFixed;
            location.DropDownStyle = ComboBoxStyle.DropDownList;
            location.FocusedColor = Color.FromArgb(94, 148, 255);
            location.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            location.Font = new Font("Segoe UI", 10F);
            location.ForeColor = Color.FromArgb(68, 88, 112);
            location.ItemHeight = 30;
            location.Location = new Point(730, 34);
            location.Name = "location";
            location.ShadowDecoration.CustomizableEdges = customizableEdges2;
            location.Size = new Size(255, 36);
            location.TabIndex = 21;
            location.SelectedIndexChanged += location_SelectedIndexChanged;
            // 
            // Costumers_UC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(location);
            Controls.Add(downloadExel);
            Controls.Add(costumersData);
            Controls.Add(search_Icon);
            Controls.Add(Search_Txt);
            Name = "Costumers_UC";
            Size = new Size(1375, 755);
            ((System.ComponentModel.ISupportInitialize)search_Icon).EndInit();
            ((System.ComponentModel.ISupportInitialize)costumersData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox search_Icon;
        private Krypton.Toolkit.KryptonTextBox Search_Txt;
        private Krypton.Toolkit.KryptonDataGridView costumersData;
        private Krypton.Toolkit.KryptonButton downloadExel;
        private Guna.UI2.WinForms.Guna2ComboBox location;
    }
}
