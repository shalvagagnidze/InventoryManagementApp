using System.Windows.Forms;

namespace InventoryManagementApp.User_Controls
{
    partial class Products_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Products_UC));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            productData = new Krypton.Toolkit.KryptonDataGridView();
            addProduct_Btn = new Krypton.Toolkit.KryptonButton();
            addCategory_Btn = new Krypton.Toolkit.KryptonButton();
            Search_Txt = new Krypton.Toolkit.KryptonTextBox();
            search_Icon = new PictureBox();
            edit_Btn = new Krypton.Toolkit.KryptonButton();
            delete_Btn = new Krypton.Toolkit.KryptonButton();
            addBrand_Btn = new Krypton.Toolkit.KryptonButton();
            panel1 = new Panel();
            download_Btn = new Guna.UI2.WinForms.Guna2ImageButton();
            comboBox = new Guna.UI2.WinForms.Guna2ComboBox();
            brokenProduct = new Guna.UI2.WinForms.Guna2ImageButton();
            ((System.ComponentModel.ISupportInitialize)productData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)search_Icon).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // productData
            // 
            productData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            productData.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            productData.BorderStyle = BorderStyle.None;
            productData.ColumnHeadersHeight = 51;
            productData.ImeMode = ImeMode.On;
            productData.Location = new Point(3, 200);
            productData.Name = "productData";
            productData.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            productData.ReadOnly = true;
            productData.RowHeadersWidth = 62;
            productData.RowTemplate.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            productData.RowTemplate.DividerHeight = 3;
            productData.RowTemplate.Resizable = DataGridViewTriState.False;
            productData.Size = new Size(1369, 552);
            productData.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            productData.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            productData.StateCommon.DataCell.Border.Rounding = 5F;
            productData.StateCommon.DataCell.Border.Width = 1;
            productData.StateCommon.DataCell.Content.Color1 = Color.FromArgb(64, 64, 64);
            productData.StateCommon.DataCell.Content.Font = new Font("Georgia", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productData.TabIndex = 1;
            // 
            // addProduct_Btn
            // 
            addProduct_Btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addProduct_Btn.Location = new Point(352, 14);
            addProduct_Btn.Name = "addProduct_Btn";
            addProduct_Btn.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            addProduct_Btn.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            addProduct_Btn.OverrideDefault.Back.ColorAngle = 45F;
            addProduct_Btn.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            addProduct_Btn.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            addProduct_Btn.OverrideDefault.Border.ColorAngle = 45F;
            addProduct_Btn.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            addProduct_Btn.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            addProduct_Btn.OverrideDefault.Border.Rounding = 20F;
            addProduct_Btn.OverrideDefault.Border.Width = 2;
            addProduct_Btn.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            addProduct_Btn.Size = new Size(322, 70);
            addProduct_Btn.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            addProduct_Btn.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            addProduct_Btn.StateCommon.Back.ColorAngle = 45F;
            addProduct_Btn.StateCommon.Border.Color1 = Color.FromArgb(40, 255, 68);
            addProduct_Btn.StateCommon.Border.Color2 = Color.FromArgb(19, 216, 45);
            addProduct_Btn.StateCommon.Border.ColorAngle = 45F;
            addProduct_Btn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            addProduct_Btn.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            addProduct_Btn.StateCommon.Border.Rounding = 22F;
            addProduct_Btn.StateCommon.Border.Width = 2;
            addProduct_Btn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(15, 189, 38);
            addProduct_Btn.StateCommon.Content.ShortText.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addProduct_Btn.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            addProduct_Btn.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            addProduct_Btn.StatePressed.Back.ColorAngle = 135F;
            addProduct_Btn.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            addProduct_Btn.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            addProduct_Btn.StatePressed.Border.ColorAngle = 135F;
            addProduct_Btn.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            addProduct_Btn.StatePressed.Border.Rounding = 20F;
            addProduct_Btn.StatePressed.Border.Width = 1;
            addProduct_Btn.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            addProduct_Btn.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            addProduct_Btn.StateTracking.Back.ColorAngle = 45F;
            addProduct_Btn.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            addProduct_Btn.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            addProduct_Btn.StateTracking.Border.ColorAngle = 45F;
            addProduct_Btn.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            addProduct_Btn.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            addProduct_Btn.StateTracking.Border.Rounding = 20F;
            addProduct_Btn.StateTracking.Border.Width = 1;
            addProduct_Btn.StateTracking.Content.ShortText.Color1 = Color.White;
            addProduct_Btn.TabIndex = 13;
            addProduct_Btn.Values.ExtraText = "  ";
            addProduct_Btn.Values.Image = Properties.Resources.Add_48;
            addProduct_Btn.Values.Text = "  პროდუქტის დამატება        ";
            addProduct_Btn.Click += addProduct_Btn_Click;
            // 
            // addCategory_Btn
            // 
            addCategory_Btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addCategory_Btn.Location = new Point(12, 14);
            addCategory_Btn.Name = "addCategory_Btn";
            addCategory_Btn.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            addCategory_Btn.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            addCategory_Btn.OverrideDefault.Back.ColorAngle = 45F;
            addCategory_Btn.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            addCategory_Btn.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            addCategory_Btn.OverrideDefault.Border.ColorAngle = 45F;
            addCategory_Btn.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            addCategory_Btn.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            addCategory_Btn.OverrideDefault.Border.Rounding = 20F;
            addCategory_Btn.OverrideDefault.Border.Width = 2;
            addCategory_Btn.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            addCategory_Btn.Size = new Size(327, 70);
            addCategory_Btn.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            addCategory_Btn.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            addCategory_Btn.StateCommon.Back.ColorAngle = 45F;
            addCategory_Btn.StateCommon.Border.Color1 = Color.FromArgb(249, 225, 10);
            addCategory_Btn.StateCommon.Border.Color2 = Color.FromArgb(245, 204, 43);
            addCategory_Btn.StateCommon.Border.ColorAngle = 45F;
            addCategory_Btn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            addCategory_Btn.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            addCategory_Btn.StateCommon.Border.Rounding = 22F;
            addCategory_Btn.StateCommon.Border.Width = 2;
            addCategory_Btn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(245, 204, 43);
            addCategory_Btn.StateCommon.Content.ShortText.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addCategory_Btn.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            addCategory_Btn.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            addCategory_Btn.StatePressed.Back.ColorAngle = 135F;
            addCategory_Btn.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            addCategory_Btn.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            addCategory_Btn.StatePressed.Border.ColorAngle = 135F;
            addCategory_Btn.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            addCategory_Btn.StatePressed.Border.Rounding = 20F;
            addCategory_Btn.StatePressed.Border.Width = 1;
            addCategory_Btn.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            addCategory_Btn.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            addCategory_Btn.StateTracking.Back.ColorAngle = 45F;
            addCategory_Btn.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            addCategory_Btn.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            addCategory_Btn.StateTracking.Border.ColorAngle = 45F;
            addCategory_Btn.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            addCategory_Btn.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            addCategory_Btn.StateTracking.Border.Rounding = 20F;
            addCategory_Btn.StateTracking.Border.Width = 1;
            addCategory_Btn.StateTracking.Content.ShortText.Color1 = Color.White;
            addCategory_Btn.TabIndex = 14;
            addCategory_Btn.Values.ExtraText = "  ";
            addCategory_Btn.Values.Image = Properties.Resources.Add_Orange_48;
            addCategory_Btn.Values.Text = "  კატეგორიის დამატება";
            addCategory_Btn.Click += addCategory_Btn_Click;
            // 
            // Search_Txt
            // 
            Search_Txt.Location = new Point(87, 32);
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
            Search_Txt.TabIndex = 15;
            Search_Txt.Text = "ძებნა...";
            Search_Txt.TextChanged += Search_Txt_TextChanged;
            Search_Txt.Click += Search_Txt_Click;
            // 
            // search_Icon
            // 
            search_Icon.Image = Properties.Resources.Search_40;
            search_Icon.Location = new Point(16, 32);
            search_Icon.Name = "search_Icon";
            search_Icon.Size = new Size(55, 39);
            search_Icon.SizeMode = PictureBoxSizeMode.Zoom;
            search_Icon.TabIndex = 16;
            search_Icon.TabStop = false;
            // 
            // edit_Btn
            // 
            edit_Btn.Location = new Point(170, 111);
            edit_Btn.Name = "edit_Btn";
            edit_Btn.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            edit_Btn.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            edit_Btn.OverrideDefault.Back.ColorAngle = 45F;
            edit_Btn.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            edit_Btn.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            edit_Btn.OverrideDefault.Border.ColorAngle = 45F;
            edit_Btn.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            edit_Btn.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            edit_Btn.OverrideDefault.Border.Rounding = 20F;
            edit_Btn.OverrideDefault.Border.Width = 2;
            edit_Btn.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            edit_Btn.Size = new Size(238, 70);
            edit_Btn.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            edit_Btn.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            edit_Btn.StateCommon.Back.ColorAngle = 45F;
            edit_Btn.StateCommon.Border.Color1 = Color.FromArgb(45, 255, 255);
            edit_Btn.StateCommon.Border.Color2 = Color.FromArgb(23, 222, 222);
            edit_Btn.StateCommon.Border.ColorAngle = 45F;
            edit_Btn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            edit_Btn.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            edit_Btn.StateCommon.Border.Rounding = 22F;
            edit_Btn.StateCommon.Border.Width = 2;
            edit_Btn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(14, 205, 205);
            edit_Btn.StateCommon.Content.ShortText.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            edit_Btn.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            edit_Btn.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            edit_Btn.StatePressed.Back.ColorAngle = 135F;
            edit_Btn.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            edit_Btn.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            edit_Btn.StatePressed.Border.ColorAngle = 135F;
            edit_Btn.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            edit_Btn.StatePressed.Border.Rounding = 20F;
            edit_Btn.StatePressed.Border.Width = 1;
            edit_Btn.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            edit_Btn.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            edit_Btn.StateTracking.Back.ColorAngle = 45F;
            edit_Btn.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            edit_Btn.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            edit_Btn.StateTracking.Border.ColorAngle = 45F;
            edit_Btn.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            edit_Btn.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            edit_Btn.StateTracking.Border.Rounding = 20F;
            edit_Btn.StateTracking.Border.Width = 1;
            edit_Btn.StateTracking.Content.ShortText.Color1 = Color.White;
            edit_Btn.TabIndex = 17;
            edit_Btn.Values.ExtraText = "    ";
            edit_Btn.Values.Image = Properties.Resources.Edit_48;
            edit_Btn.Values.Text = "  რედაქტირება";
            edit_Btn.Click += edit_Btn_Click;
            // 
            // delete_Btn
            // 
            delete_Btn.Location = new Point(1, 111);
            delete_Btn.Name = "delete_Btn";
            delete_Btn.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            delete_Btn.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            delete_Btn.OverrideDefault.Back.ColorAngle = 45F;
            delete_Btn.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            delete_Btn.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            delete_Btn.OverrideDefault.Border.ColorAngle = 45F;
            delete_Btn.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            delete_Btn.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            delete_Btn.OverrideDefault.Border.Rounding = 20F;
            delete_Btn.OverrideDefault.Border.Width = 2;
            delete_Btn.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            delete_Btn.Size = new Size(154, 70);
            delete_Btn.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            delete_Btn.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            delete_Btn.StateCommon.Back.ColorAngle = 45F;
            delete_Btn.StateCommon.Border.Color1 = Color.FromArgb(233, 19, 69);
            delete_Btn.StateCommon.Border.Color2 = Color.FromArgb(210, 13, 59);
            delete_Btn.StateCommon.Border.ColorAngle = 45F;
            delete_Btn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            delete_Btn.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            delete_Btn.StateCommon.Border.Rounding = 22F;
            delete_Btn.StateCommon.Border.Width = 2;
            delete_Btn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(228, 9, 60);
            delete_Btn.StateCommon.Content.ShortText.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            delete_Btn.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            delete_Btn.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            delete_Btn.StatePressed.Back.ColorAngle = 135F;
            delete_Btn.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            delete_Btn.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            delete_Btn.StatePressed.Border.ColorAngle = 135F;
            delete_Btn.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            delete_Btn.StatePressed.Border.Rounding = 20F;
            delete_Btn.StatePressed.Border.Width = 1;
            delete_Btn.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            delete_Btn.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            delete_Btn.StateTracking.Back.ColorAngle = 45F;
            delete_Btn.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            delete_Btn.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            delete_Btn.StateTracking.Border.ColorAngle = 45F;
            delete_Btn.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            delete_Btn.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            delete_Btn.StateTracking.Border.Rounding = 20F;
            delete_Btn.StateTracking.Border.Width = 1;
            delete_Btn.StateTracking.Content.ShortText.Color1 = Color.White;
            delete_Btn.TabIndex = 18;
            delete_Btn.Values.ExtraText = "       ";
            delete_Btn.Values.Image = (Image)resources.GetObject("delete_Btn.Values.Image");
            delete_Btn.Values.Text = "წაშლა";
            delete_Btn.Click += delete_Btn_Click;
            // 
            // addBrand_Btn
            // 
            addBrand_Btn.Location = new Point(420, 111);
            addBrand_Btn.Name = "addBrand_Btn";
            addBrand_Btn.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            addBrand_Btn.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            addBrand_Btn.OverrideDefault.Back.ColorAngle = 45F;
            addBrand_Btn.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            addBrand_Btn.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            addBrand_Btn.OverrideDefault.Border.ColorAngle = 45F;
            addBrand_Btn.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            addBrand_Btn.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            addBrand_Btn.OverrideDefault.Border.Rounding = 20F;
            addBrand_Btn.OverrideDefault.Border.Width = 2;
            addBrand_Btn.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            addBrand_Btn.Size = new Size(287, 70);
            addBrand_Btn.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            addBrand_Btn.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            addBrand_Btn.StateCommon.Back.ColorAngle = 45F;
            addBrand_Btn.StateCommon.Border.Color1 = Color.FromArgb(175, 76, 160);
            addBrand_Btn.StateCommon.Border.Color2 = Color.FromArgb(160, 50, 100);
            addBrand_Btn.StateCommon.Border.ColorAngle = 45F;
            addBrand_Btn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            addBrand_Btn.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            addBrand_Btn.StateCommon.Border.Rounding = 22F;
            addBrand_Btn.StateCommon.Border.Width = 2;
            addBrand_Btn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(160, 50, 100);
            addBrand_Btn.StateCommon.Content.ShortText.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBrand_Btn.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            addBrand_Btn.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            addBrand_Btn.StatePressed.Back.ColorAngle = 135F;
            addBrand_Btn.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            addBrand_Btn.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            addBrand_Btn.StatePressed.Border.ColorAngle = 135F;
            addBrand_Btn.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            addBrand_Btn.StatePressed.Border.Rounding = 20F;
            addBrand_Btn.StatePressed.Border.Width = 1;
            addBrand_Btn.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            addBrand_Btn.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            addBrand_Btn.StateTracking.Back.ColorAngle = 45F;
            addBrand_Btn.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            addBrand_Btn.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            addBrand_Btn.StateTracking.Border.ColorAngle = 45F;
            addBrand_Btn.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            addBrand_Btn.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            addBrand_Btn.StateTracking.Border.Rounding = 20F;
            addBrand_Btn.StateTracking.Border.Width = 1;
            addBrand_Btn.StateTracking.Content.ShortText.Color1 = Color.White;
            addBrand_Btn.TabIndex = 19;
            addBrand_Btn.Values.ExtraText = "  ";
            addBrand_Btn.Values.Image = Properties.Resources.Add_Purple_48;
            addBrand_Btn.Values.Text = "  ბრენდის დამატება";
            addBrand_Btn.Click += addBrand_Btn_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(addProduct_Btn);
            panel1.Controls.Add(addCategory_Btn);
            panel1.Location = new Point(694, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(678, 102);
            panel1.TabIndex = 20;
            // 
            // download_Btn
            // 
            download_Btn.CheckedState.ImageSize = new Size(64, 64);
            download_Btn.HoverState.ImageSize = new Size(64, 64);
            download_Btn.Image = Properties.Resources.Download_48;
            download_Btn.ImageOffset = new Point(0, 0);
            download_Btn.ImageRotate = 0F;
            download_Btn.ImageSize = new Size(48, 48);
            download_Btn.Location = new Point(722, 121);
            download_Btn.Name = "download_Btn";
            download_Btn.PressedState.ImageSize = new Size(64, 64);
            download_Btn.ShadowDecoration.CustomizableEdges = customizableEdges1;
            download_Btn.Size = new Size(50, 56);
            download_Btn.TabIndex = 25;
            download_Btn.Click += download_Btn_Click;
            // 
            // comboBox
            // 
            comboBox.AutoRoundedCorners = true;
            comboBox.BackColor = Color.Transparent;
            comboBox.BorderColor = Color.FromArgb(2, 79, 196);
            comboBox.BorderRadius = 19;
            comboBox.BorderThickness = 2;
            comboBox.CustomizableEdges = customizableEdges2;
            comboBox.DrawMode = DrawMode.OwnerDrawFixed;
            comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox.FocusedColor = Color.FromArgb(94, 148, 255);
            comboBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            comboBox.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox.ForeColor = Color.FromArgb(2, 79, 196);
            comboBox.ItemHeight = 35;
            comboBox.Items.AddRange(new object[] { "პროდუქტი", "კატეგორია", "ბრენდი" });
            comboBox.ItemsAppearance.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox.ItemsAppearance.ForeColor = Color.FromArgb(2, 79, 196);
            comboBox.Location = new Point(1130, 130);
            comboBox.Name = "comboBox";
            comboBox.ShadowDecoration.CustomizableEdges = customizableEdges3;
            comboBox.Size = new Size(242, 41);
            comboBox.StartIndex = 0;
            comboBox.TabIndex = 26;
            comboBox.TextAlign = HorizontalAlignment.Center;
            comboBox.SelectedIndexChanged += comboBox_SelectedIndexChanged;
            // 
            // brokenProduct
            // 
            brokenProduct.CheckedState.ImageSize = new Size(64, 64);
            brokenProduct.HoverState.ImageSize = new Size(64, 64);
            brokenProduct.Image = Properties.Resources.Broken_36;
            brokenProduct.ImageOffset = new Point(0, 0);
            brokenProduct.ImageRotate = 0F;
            brokenProduct.ImageSize = new Size(48, 48);
            brokenProduct.Location = new Point(798, 121);
            brokenProduct.Name = "brokenProduct";
            brokenProduct.PressedState.ImageSize = new Size(64, 64);
            brokenProduct.ShadowDecoration.CustomizableEdges = customizableEdges4;
            brokenProduct.Size = new Size(50, 56);
            brokenProduct.TabIndex = 27;
            brokenProduct.Click += brokenProduct_Click;
            // 
            // Products_UC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 252, 252);
            Controls.Add(brokenProduct);
            Controls.Add(comboBox);
            Controls.Add(download_Btn);
            Controls.Add(panel1);
            Controls.Add(addBrand_Btn);
            Controls.Add(delete_Btn);
            Controls.Add(edit_Btn);
            Controls.Add(search_Icon);
            Controls.Add(Search_Txt);
            Controls.Add(productData);
            Name = "Products_UC";
            Size = new Size(1375, 755);
            Load += Products_UC_Load;
            ((System.ComponentModel.ISupportInitialize)productData).EndInit();
            ((System.ComponentModel.ISupportInitialize)search_Icon).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Krypton.Toolkit.KryptonDataGridView productData;
        private Krypton.Toolkit.KryptonButton addProduct_Btn;
        private Krypton.Toolkit.KryptonButton addCategory_Btn;
        private Krypton.Toolkit.KryptonTextBox Search_Txt;
        private PictureBox search_Icon;
        private Krypton.Toolkit.KryptonButton addBrand_Btn;
        private Krypton.Toolkit.KryptonButton delete_Btn;
        private Krypton.Toolkit.KryptonButton edit_Btn;
        private Panel panel1;
        private Guna.UI2.WinForms.Guna2ImageButton download_Btn;
        private Guna.UI2.WinForms.Guna2ComboBox comboBox;
        private Guna.UI2.WinForms.Guna2ImageButton brokenProduct;
    }
}
