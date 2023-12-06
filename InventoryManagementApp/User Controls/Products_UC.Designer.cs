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
            productData = new Krypton.Toolkit.KryptonDataGridView();
            addProduct_Btn = new Krypton.Toolkit.KryptonButton();
            addCategory_Btn = new Krypton.Toolkit.KryptonButton();
            Search_Txt = new Krypton.Toolkit.KryptonTextBox();
            search_Icon = new PictureBox();
            edit_Btn = new Krypton.Toolkit.KryptonButton();
            delete_Btn = new Krypton.Toolkit.KryptonButton();
            addBrand_Btn = new Krypton.Toolkit.KryptonButton();
            panel1 = new Panel();
            sortProd_Btn = new Krypton.Toolkit.KryptonButton();
            panel2 = new Panel();
            sortBrand_Btn = new Krypton.Toolkit.KryptonButton();
            sortCat_Btn = new Krypton.Toolkit.KryptonButton();
            sort_Btn = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)productData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)search_Icon).BeginInit();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // productData
            // 
            productData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            productData.BorderStyle = BorderStyle.None;
            productData.ColumnHeadersHeight = 51;
            productData.ImeMode = ImeMode.On;
            productData.Location = new Point(3, 200);
            productData.Name = "productData";
            productData.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            productData.ReadOnly = true;
            productData.RowHeadersWidth = 62;
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
            // sortProd_Btn
            // 
            sortProd_Btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            sortProd_Btn.Location = new Point(350, 8);
            sortProd_Btn.Name = "sortProd_Btn";
            sortProd_Btn.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            sortProd_Btn.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            sortProd_Btn.OverrideDefault.Back.ColorAngle = 45F;
            sortProd_Btn.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            sortProd_Btn.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            sortProd_Btn.OverrideDefault.Border.ColorAngle = 45F;
            sortProd_Btn.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            sortProd_Btn.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            sortProd_Btn.OverrideDefault.Border.Rounding = 20F;
            sortProd_Btn.OverrideDefault.Border.Width = 2;
            sortProd_Btn.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            sortProd_Btn.Size = new Size(165, 39);
            sortProd_Btn.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            sortProd_Btn.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            sortProd_Btn.StateCommon.Back.ColorAngle = 45F;
            sortProd_Btn.StateCommon.Border.Color1 = Color.FromArgb(249, 225, 10);
            sortProd_Btn.StateCommon.Border.Color2 = Color.FromArgb(245, 204, 43);
            sortProd_Btn.StateCommon.Border.ColorAngle = 45F;
            sortProd_Btn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            sortProd_Btn.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            sortProd_Btn.StateCommon.Border.Rounding = 7F;
            sortProd_Btn.StateCommon.Border.Width = 2;
            sortProd_Btn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(245, 204, 43);
            sortProd_Btn.StateCommon.Content.ShortText.Font = new Font("Georgia", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sortProd_Btn.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            sortProd_Btn.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            sortProd_Btn.StatePressed.Back.ColorAngle = 135F;
            sortProd_Btn.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            sortProd_Btn.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            sortProd_Btn.StatePressed.Border.ColorAngle = 135F;
            sortProd_Btn.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            sortProd_Btn.StatePressed.Border.Rounding = 20F;
            sortProd_Btn.StatePressed.Border.Width = 1;
            sortProd_Btn.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            sortProd_Btn.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            sortProd_Btn.StateTracking.Back.ColorAngle = 45F;
            sortProd_Btn.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            sortProd_Btn.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            sortProd_Btn.StateTracking.Border.ColorAngle = 45F;
            sortProd_Btn.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            sortProd_Btn.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            sortProd_Btn.StateTracking.Border.Rounding = 20F;
            sortProd_Btn.StateTracking.Border.Width = 1;
            sortProd_Btn.StateTracking.Content.ShortText.Color1 = Color.White;
            sortProd_Btn.TabIndex = 21;
            sortProd_Btn.Values.ExtraText = "  ";
            sortProd_Btn.Values.Text = "  პროდუქტი";
            sortProd_Btn.Click += sortProd_Btn_Click_1;
            // 
            // panel2
            // 
            panel2.Controls.Add(sortBrand_Btn);
            panel2.Controls.Add(sortProd_Btn);
            panel2.Controls.Add(sortCat_Btn);
            panel2.Location = new Point(795, 130);
            panel2.Name = "panel2";
            panel2.Size = new Size(518, 58);
            panel2.TabIndex = 22;
            // 
            // sortBrand_Btn
            // 
            sortBrand_Btn.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            sortBrand_Btn.Location = new Point(8, 8);
            sortBrand_Btn.Name = "sortBrand_Btn";
            sortBrand_Btn.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            sortBrand_Btn.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            sortBrand_Btn.OverrideDefault.Back.ColorAngle = 45F;
            sortBrand_Btn.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            sortBrand_Btn.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            sortBrand_Btn.OverrideDefault.Border.ColorAngle = 45F;
            sortBrand_Btn.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            sortBrand_Btn.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            sortBrand_Btn.OverrideDefault.Border.Rounding = 20F;
            sortBrand_Btn.OverrideDefault.Border.Width = 2;
            sortBrand_Btn.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            sortBrand_Btn.Size = new Size(165, 39);
            sortBrand_Btn.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            sortBrand_Btn.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            sortBrand_Btn.StateCommon.Back.ColorAngle = 45F;
            sortBrand_Btn.StateCommon.Border.Color1 = Color.FromArgb(249, 225, 10);
            sortBrand_Btn.StateCommon.Border.Color2 = Color.FromArgb(245, 204, 43);
            sortBrand_Btn.StateCommon.Border.ColorAngle = 45F;
            sortBrand_Btn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            sortBrand_Btn.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            sortBrand_Btn.StateCommon.Border.Rounding = 7F;
            sortBrand_Btn.StateCommon.Border.Width = 2;
            sortBrand_Btn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(245, 204, 43);
            sortBrand_Btn.StateCommon.Content.ShortText.Font = new Font("Georgia", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sortBrand_Btn.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            sortBrand_Btn.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            sortBrand_Btn.StatePressed.Back.ColorAngle = 135F;
            sortBrand_Btn.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            sortBrand_Btn.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            sortBrand_Btn.StatePressed.Border.ColorAngle = 135F;
            sortBrand_Btn.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            sortBrand_Btn.StatePressed.Border.Rounding = 20F;
            sortBrand_Btn.StatePressed.Border.Width = 1;
            sortBrand_Btn.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            sortBrand_Btn.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            sortBrand_Btn.StateTracking.Back.ColorAngle = 45F;
            sortBrand_Btn.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            sortBrand_Btn.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            sortBrand_Btn.StateTracking.Border.ColorAngle = 45F;
            sortBrand_Btn.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            sortBrand_Btn.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            sortBrand_Btn.StateTracking.Border.Rounding = 20F;
            sortBrand_Btn.StateTracking.Border.Width = 1;
            sortBrand_Btn.StateTracking.Content.ShortText.Color1 = Color.White;
            sortBrand_Btn.TabIndex = 24;
            sortBrand_Btn.Values.ExtraText = "          ";
            sortBrand_Btn.Values.Text = "   ბრენდი";
            sortBrand_Btn.Click += sortBrand_Btn_Click;
            // 
            // sortCat_Btn
            // 
            sortCat_Btn.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            sortCat_Btn.Location = new Point(179, 8);
            sortCat_Btn.Name = "sortCat_Btn";
            sortCat_Btn.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            sortCat_Btn.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            sortCat_Btn.OverrideDefault.Back.ColorAngle = 45F;
            sortCat_Btn.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            sortCat_Btn.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            sortCat_Btn.OverrideDefault.Border.ColorAngle = 45F;
            sortCat_Btn.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            sortCat_Btn.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            sortCat_Btn.OverrideDefault.Border.Rounding = 20F;
            sortCat_Btn.OverrideDefault.Border.Width = 2;
            sortCat_Btn.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            sortCat_Btn.Size = new Size(165, 39);
            sortCat_Btn.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            sortCat_Btn.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            sortCat_Btn.StateCommon.Back.ColorAngle = 45F;
            sortCat_Btn.StateCommon.Border.Color1 = Color.FromArgb(249, 225, 10);
            sortCat_Btn.StateCommon.Border.Color2 = Color.FromArgb(245, 204, 43);
            sortCat_Btn.StateCommon.Border.ColorAngle = 45F;
            sortCat_Btn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            sortCat_Btn.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            sortCat_Btn.StateCommon.Border.Rounding = 7F;
            sortCat_Btn.StateCommon.Border.Width = 2;
            sortCat_Btn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(245, 204, 43);
            sortCat_Btn.StateCommon.Content.ShortText.Font = new Font("Georgia", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sortCat_Btn.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            sortCat_Btn.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            sortCat_Btn.StatePressed.Back.ColorAngle = 135F;
            sortCat_Btn.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            sortCat_Btn.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            sortCat_Btn.StatePressed.Border.ColorAngle = 135F;
            sortCat_Btn.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            sortCat_Btn.StatePressed.Border.Rounding = 20F;
            sortCat_Btn.StatePressed.Border.Width = 1;
            sortCat_Btn.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            sortCat_Btn.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            sortCat_Btn.StateTracking.Back.ColorAngle = 45F;
            sortCat_Btn.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            sortCat_Btn.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            sortCat_Btn.StateTracking.Border.ColorAngle = 45F;
            sortCat_Btn.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            sortCat_Btn.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            sortCat_Btn.StateTracking.Border.Rounding = 20F;
            sortCat_Btn.StateTracking.Border.Width = 1;
            sortCat_Btn.StateTracking.Content.ShortText.Color1 = Color.White;
            sortCat_Btn.TabIndex = 23;
            sortCat_Btn.Values.ExtraText = "  ";
            sortCat_Btn.Values.Text = "  კატეგორია";
            sortCat_Btn.Click += sortCat_Btn_Click;
            // 
            // sort_Btn
            // 
            sort_Btn.Location = new Point(1319, 132);
            sort_Btn.Name = "sort_Btn";
            sort_Btn.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            sort_Btn.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            sort_Btn.OverrideDefault.Back.ColorAngle = 45F;
            sort_Btn.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            sort_Btn.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            sort_Btn.OverrideDefault.Border.ColorAngle = 45F;
            sort_Btn.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            sort_Btn.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            sort_Btn.OverrideDefault.Border.Rounding = 20F;
            sort_Btn.OverrideDefault.Border.Width = 2;
            sort_Btn.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            sort_Btn.Size = new Size(53, 45);
            sort_Btn.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            sort_Btn.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            sort_Btn.StateCommon.Back.ColorAngle = 45F;
            sort_Btn.StateCommon.Border.Color1 = Color.FromArgb(233, 19, 69);
            sort_Btn.StateCommon.Border.Color2 = Color.FromArgb(210, 13, 59);
            sort_Btn.StateCommon.Border.ColorAngle = 45F;
            sort_Btn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            sort_Btn.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            sort_Btn.StateCommon.Border.Rounding = 22F;
            sort_Btn.StateCommon.Border.Width = 2;
            sort_Btn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(228, 9, 60);
            sort_Btn.StateCommon.Content.ShortText.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sort_Btn.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            sort_Btn.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            sort_Btn.StatePressed.Back.ColorAngle = 135F;
            sort_Btn.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            sort_Btn.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            sort_Btn.StatePressed.Border.ColorAngle = 135F;
            sort_Btn.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            sort_Btn.StatePressed.Border.Rounding = 20F;
            sort_Btn.StatePressed.Border.Width = 1;
            sort_Btn.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            sort_Btn.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            sort_Btn.StateTracking.Back.ColorAngle = 45F;
            sort_Btn.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            sort_Btn.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            sort_Btn.StateTracking.Border.ColorAngle = 45F;
            sort_Btn.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            sort_Btn.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            sort_Btn.StateTracking.Border.Rounding = 20F;
            sort_Btn.StateTracking.Border.Width = 1;
            sort_Btn.StateTracking.Content.ShortText.Color1 = Color.White;
            sort_Btn.TabIndex = 23;
            sort_Btn.Values.ExtraText = "       ";
            sort_Btn.Values.Image = (Image)resources.GetObject("sort_Btn.Values.Image");
            sort_Btn.Values.Text = "";
            sort_Btn.Click += sort_Btn_Click;
            // 
            // Products_UC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(250, 252, 252);
            Controls.Add(sort_Btn);
            Controls.Add(panel2);
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
            panel2.ResumeLayout(false);
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
        private Krypton.Toolkit.KryptonButton sortProd_Btn;
        private Panel panel2;
        private Krypton.Toolkit.KryptonButton sortBrand_Btn;
        private Krypton.Toolkit.KryptonButton sortCat_Btn;
        private Krypton.Toolkit.KryptonButton sort_Btn;
    }
}
