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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Invoice_UC));
            costumerInfo_Label = new Label();
            costumerName_Label = new Label();
            costumerName_Txt = new Krypton.Toolkit.KryptonTextBox();
            costumerID_Label = new Label();
            costumerId_Txt = new Krypton.Toolkit.KryptonTextBox();
            adress_Label = new Label();
            adress_Txt = new Krypton.Toolkit.KryptonTextBox();
            email_Label = new Label();
            email_Txt = new Krypton.Toolkit.KryptonTextBox();
            phoneNum_Label = new Label();
            phoneNum_Txt = new Krypton.Toolkit.KryptonTextBox();
            price_Label = new Label();
            price_Txt = new Krypton.Toolkit.KryptonTextBox();
            prodName_Label = new Label();
            prodName_Txt = new Krypton.Toolkit.KryptonTextBox();
            amount_Label = new Label();
            amount_Txt = new Krypton.Toolkit.KryptonTextBox();
            date_Label = new Label();
            date_Txt = new Guna.UI2.WinForms.Guna2DateTimePicker();
            dateCheckBox = new CheckBox();
            invoiceData = new Krypton.Toolkit.KryptonDataGridView();
            addProd_btn = new Krypton.Toolkit.KryptonButton();
            save_Btn = new Krypton.Toolkit.KryptonButton();
            addProd_Label = new Label();
            ((System.ComponentModel.ISupportInitialize)invoiceData).BeginInit();
            SuspendLayout();
            // 
            // costumerInfo_Label
            // 
            costumerInfo_Label.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            costumerInfo_Label.ForeColor = Color.FromArgb(64, 64, 64);
            costumerInfo_Label.Location = new Point(0, 11);
            costumerInfo_Label.Name = "costumerInfo_Label";
            costumerInfo_Label.Size = new Size(1375, 48);
            costumerInfo_Label.TabIndex = 36;
            costumerInfo_Label.Text = "მიმღების ინფორმაცია";
            costumerInfo_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // costumerName_Label
            // 
            costumerName_Label.AutoSize = true;
            costumerName_Label.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            costumerName_Label.ForeColor = Color.FromArgb(64, 64, 64);
            costumerName_Label.Location = new Point(41, 81);
            costumerName_Label.Name = "costumerName_Label";
            costumerName_Label.Size = new Size(269, 28);
            costumerName_Label.TabIndex = 39;
            costumerName_Label.Text = "მიმღების დასახელება:";
            // 
            // costumerName_Txt
            // 
            costumerName_Txt.Location = new Point(316, 81);
            costumerName_Txt.Name = "costumerName_Txt";
            costumerName_Txt.Size = new Size(325, 35);
            costumerName_Txt.StateCommon.Back.Color1 = Color.White;
            costumerName_Txt.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            costumerName_Txt.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            costumerName_Txt.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            costumerName_Txt.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            costumerName_Txt.StateCommon.Border.Rounding = 20F;
            costumerName_Txt.StateCommon.Border.Width = 1;
            costumerName_Txt.StateCommon.Content.Color1 = Color.Gray;
            costumerName_Txt.StateCommon.Content.Font = new Font("Georgia", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            costumerName_Txt.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            costumerName_Txt.TabIndex = 38;
            costumerName_Txt.Text = "შეიყვანეთ თქვენი გვარი";
            // 
            // costumerID_Label
            // 
            costumerID_Label.AutoSize = true;
            costumerID_Label.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            costumerID_Label.ForeColor = Color.FromArgb(64, 64, 64);
            costumerID_Label.Location = new Point(789, 81);
            costumerID_Label.Name = "costumerID_Label";
            costumerID_Label.Size = new Size(294, 28);
            costumerID_Label.TabIndex = 41;
            costumerID_Label.Text = "საიდენტიფიკაციო კოდი:";
            // 
            // costumerId_Txt
            // 
            costumerId_Txt.Location = new Point(1089, 81);
            costumerId_Txt.Name = "costumerId_Txt";
            costumerId_Txt.Size = new Size(200, 35);
            costumerId_Txt.StateCommon.Back.Color1 = Color.White;
            costumerId_Txt.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            costumerId_Txt.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            costumerId_Txt.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            costumerId_Txt.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            costumerId_Txt.StateCommon.Border.Rounding = 20F;
            costumerId_Txt.StateCommon.Border.Width = 1;
            costumerId_Txt.StateCommon.Content.Color1 = Color.Gray;
            costumerId_Txt.StateCommon.Content.Font = new Font("Georgia", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            costumerId_Txt.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            costumerId_Txt.TabIndex = 40;
            costumerId_Txt.Text = "შეიყვანეთ თქვენი გვარი";
            // 
            // adress_Label
            // 
            adress_Label.AutoSize = true;
            adress_Label.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            adress_Label.ForeColor = Color.FromArgb(64, 64, 64);
            adress_Label.Location = new Point(41, 152);
            adress_Label.Name = "adress_Label";
            adress_Label.Size = new Size(141, 28);
            adress_Label.TabIndex = 43;
            adress_Label.Text = "მისამართი:";
            // 
            // adress_Txt
            // 
            adress_Txt.Location = new Point(188, 152);
            adress_Txt.Name = "adress_Txt";
            adress_Txt.Size = new Size(1101, 35);
            adress_Txt.StateCommon.Back.Color1 = Color.White;
            adress_Txt.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            adress_Txt.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            adress_Txt.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            adress_Txt.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            adress_Txt.StateCommon.Border.Rounding = 20F;
            adress_Txt.StateCommon.Border.Width = 1;
            adress_Txt.StateCommon.Content.Color1 = Color.Gray;
            adress_Txt.StateCommon.Content.Font = new Font("Georgia", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            adress_Txt.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            adress_Txt.TabIndex = 42;
            adress_Txt.Text = "შეიყვანეთ თქვენი გვარი";
            // 
            // email_Label
            // 
            email_Label.AutoSize = true;
            email_Label.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            email_Label.ForeColor = Color.FromArgb(64, 64, 64);
            email_Label.Location = new Point(792, 216);
            email_Label.Name = "email_Label";
            email_Label.Size = new Size(138, 28);
            email_Label.TabIndex = 45;
            email_Label.Text = "ელ-ფოსტა:";
            // 
            // email_Txt
            // 
            email_Txt.Location = new Point(939, 216);
            email_Txt.Name = "email_Txt";
            email_Txt.Size = new Size(350, 35);
            email_Txt.StateCommon.Back.Color1 = Color.White;
            email_Txt.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            email_Txt.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            email_Txt.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            email_Txt.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            email_Txt.StateCommon.Border.Rounding = 20F;
            email_Txt.StateCommon.Border.Width = 1;
            email_Txt.StateCommon.Content.Color1 = Color.Gray;
            email_Txt.StateCommon.Content.Font = new Font("Georgia", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            email_Txt.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            email_Txt.TabIndex = 44;
            email_Txt.Text = "შეიყვანეთ თქვენი გვარი";
            // 
            // phoneNum_Label
            // 
            phoneNum_Label.AutoSize = true;
            phoneNum_Label.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            phoneNum_Label.ForeColor = Color.FromArgb(64, 64, 64);
            phoneNum_Label.Location = new Point(38, 216);
            phoneNum_Label.Name = "phoneNum_Label";
            phoneNum_Label.Size = new Size(249, 28);
            phoneNum_Label.TabIndex = 47;
            phoneNum_Label.Text = "ტელეფონის ნომერი:";
            // 
            // phoneNum_Txt
            // 
            phoneNum_Txt.Location = new Point(293, 216);
            phoneNum_Txt.Name = "phoneNum_Txt";
            phoneNum_Txt.Size = new Size(348, 35);
            phoneNum_Txt.StateCommon.Back.Color1 = Color.White;
            phoneNum_Txt.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            phoneNum_Txt.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            phoneNum_Txt.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            phoneNum_Txt.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            phoneNum_Txt.StateCommon.Border.Rounding = 20F;
            phoneNum_Txt.StateCommon.Border.Width = 1;
            phoneNum_Txt.StateCommon.Content.Color1 = Color.Gray;
            phoneNum_Txt.StateCommon.Content.Font = new Font("Georgia", 9F, FontStyle.Italic, GraphicsUnit.Point, 0);
            phoneNum_Txt.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            phoneNum_Txt.TabIndex = 46;
            phoneNum_Txt.Text = "შეიყვანეთ თქვენი გვარი";
            // 
            // price_Label
            // 
            price_Label.AutoSize = true;
            price_Label.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            price_Label.ForeColor = Color.FromArgb(64, 64, 64);
            price_Label.Location = new Point(35, 427);
            price_Label.Name = "price_Label";
            price_Label.Size = new Size(73, 28);
            price_Label.TabIndex = 52;
            price_Label.Text = "ფასი:";
            // 
            // price_Txt
            // 
            price_Txt.Location = new Point(114, 424);
            price_Txt.Name = "price_Txt";
            price_Txt.Size = new Size(221, 38);
            price_Txt.StateCommon.Back.Color1 = Color.White;
            price_Txt.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            price_Txt.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            price_Txt.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            price_Txt.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            price_Txt.StateCommon.Border.Rounding = 20F;
            price_Txt.StateCommon.Border.Width = 1;
            price_Txt.StateCommon.Content.Color1 = Color.Gray;
            price_Txt.StateCommon.Content.Font = new Font("Georgia", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            price_Txt.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            price_Txt.TabIndex = 51;
            price_Txt.Text = "შეიყვანეთ თქვენი გვარი";
            // 
            // prodName_Label
            // 
            prodName_Label.AutoSize = true;
            prodName_Label.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            prodName_Label.ForeColor = Color.FromArgb(64, 64, 64);
            prodName_Label.Location = new Point(35, 345);
            prodName_Label.Name = "prodName_Label";
            prodName_Label.Size = new Size(300, 28);
            prodName_Label.TabIndex = 50;
            prodName_Label.Text = "პროდუქტის დასახელება:";
            // 
            // prodName_Txt
            // 
            prodName_Txt.Location = new Point(341, 342);
            prodName_Txt.Name = "prodName_Txt";
            prodName_Txt.Size = new Size(327, 38);
            prodName_Txt.StateCommon.Back.Color1 = Color.White;
            prodName_Txt.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            prodName_Txt.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            prodName_Txt.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            prodName_Txt.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            prodName_Txt.StateCommon.Border.Rounding = 20F;
            prodName_Txt.StateCommon.Border.Width = 1;
            prodName_Txt.StateCommon.Content.Color1 = Color.Gray;
            prodName_Txt.StateCommon.Content.Font = new Font("Georgia", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            prodName_Txt.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            prodName_Txt.TabIndex = 49;
            prodName_Txt.Text = "შეიყვანეთ თქვენი გვარი";
            // 
            // amount_Label
            // 
            amount_Label.AutoSize = true;
            amount_Label.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            amount_Label.ForeColor = Color.FromArgb(64, 64, 64);
            amount_Label.Location = new Point(360, 424);
            amount_Label.Name = "amount_Label";
            amount_Label.Size = new Size(148, 28);
            amount_Label.TabIndex = 54;
            amount_Label.Text = "რაოდენობა:";
            // 
            // amount_Txt
            // 
            amount_Txt.Location = new Point(518, 421);
            amount_Txt.Name = "amount_Txt";
            amount_Txt.Size = new Size(279, 38);
            amount_Txt.StateCommon.Back.Color1 = Color.White;
            amount_Txt.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            amount_Txt.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            amount_Txt.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            amount_Txt.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            amount_Txt.StateCommon.Border.Rounding = 20F;
            amount_Txt.StateCommon.Border.Width = 1;
            amount_Txt.StateCommon.Content.Color1 = Color.Gray;
            amount_Txt.StateCommon.Content.Font = new Font("Georgia", 10F, FontStyle.Italic, GraphicsUnit.Point, 0);
            amount_Txt.StateCommon.Content.Padding = new Padding(10, 0, 10, 0);
            amount_Txt.TabIndex = 53;
            amount_Txt.Text = "შეიყვანეთ თქვენი გვარი";
            // 
            // date_Label
            // 
            date_Label.AutoSize = true;
            date_Label.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            date_Label.ForeColor = Color.FromArgb(64, 64, 64);
            date_Label.Location = new Point(736, 348);
            date_Label.Name = "date_Label";
            date_Label.Size = new Size(108, 28);
            date_Label.TabIndex = 55;
            date_Label.Text = "თარიღი:";
            // 
            // date_Txt
            // 
            date_Txt.BackColor = SystemColors.Control;
            date_Txt.BorderRadius = 10;
            date_Txt.Checked = true;
            date_Txt.CustomizableEdges = customizableEdges3;
            date_Txt.FillColor = Color.FromArgb(250, 250, 252);
            date_Txt.Font = new Font("Segoe UI", 9F);
            date_Txt.Format = DateTimePickerFormat.Long;
            date_Txt.Location = new Point(850, 342);
            date_Txt.MaxDate = new DateTime(9998, 12, 31, 0, 0, 0, 0);
            date_Txt.MinDate = new DateTime(1753, 1, 1, 0, 0, 0, 0);
            date_Txt.Name = "date_Txt";
            date_Txt.ShadowDecoration.CustomizableEdges = customizableEdges4;
            date_Txt.Size = new Size(289, 44);
            date_Txt.TabIndex = 56;
            date_Txt.Value = new DateTime(2023, 12, 25, 21, 31, 54, 904);
            // 
            // dateCheckBox
            // 
            dateCheckBox.AutoSize = true;
            dateCheckBox.Location = new Point(1156, 351);
            dateCheckBox.Name = "dateCheckBox";
            dateCheckBox.Size = new Size(208, 29);
            dateCheckBox.TabIndex = 57;
            dateCheckBox.Text = "დღევანდელი დღე";
            dateCheckBox.UseVisualStyleBackColor = true;
            // 
            // invoiceData
            // 
            invoiceData.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            invoiceData.BorderStyle = BorderStyle.None;
            invoiceData.ColumnHeadersHeight = 51;
            invoiceData.ImeMode = ImeMode.On;
            invoiceData.Location = new Point(30, 468);
            invoiceData.Name = "invoiceData";
            invoiceData.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            invoiceData.ReadOnly = true;
            invoiceData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            invoiceData.RowTemplate.DividerHeight = 3;
            invoiceData.RowTemplate.Resizable = DataGridViewTriState.False;
            invoiceData.Size = new Size(1323, 197);
            invoiceData.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            invoiceData.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            invoiceData.StateCommon.DataCell.Border.Rounding = 5F;
            invoiceData.StateCommon.DataCell.Border.Width = 1;
            invoiceData.StateCommon.DataCell.Content.Color1 = Color.FromArgb(64, 64, 64);
            invoiceData.StateCommon.DataCell.Content.Font = new Font("Georgia", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            invoiceData.TabIndex = 58;
            // 
            // addProd_btn
            // 
            addProd_btn.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            addProd_btn.Location = new Point(850, 410);
            addProd_btn.Name = "addProd_btn";
            addProd_btn.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            addProd_btn.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            addProd_btn.OverrideDefault.Back.ColorAngle = 45F;
            addProd_btn.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            addProd_btn.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            addProd_btn.OverrideDefault.Border.ColorAngle = 45F;
            addProd_btn.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            addProd_btn.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            addProd_btn.OverrideDefault.Border.Rounding = 20F;
            addProd_btn.OverrideDefault.Border.Width = 2;
            addProd_btn.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            addProd_btn.Size = new Size(197, 49);
            addProd_btn.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            addProd_btn.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            addProd_btn.StateCommon.Back.ColorAngle = 45F;
            addProd_btn.StateCommon.Border.Color1 = Color.FromArgb(40, 255, 68);
            addProd_btn.StateCommon.Border.Color2 = Color.FromArgb(19, 216, 45);
            addProd_btn.StateCommon.Border.ColorAngle = 45F;
            addProd_btn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            addProd_btn.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            addProd_btn.StateCommon.Border.Rounding = 22F;
            addProd_btn.StateCommon.Border.Width = 2;
            addProd_btn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(15, 189, 38);
            addProd_btn.StateCommon.Content.ShortText.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addProd_btn.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            addProd_btn.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            addProd_btn.StatePressed.Back.ColorAngle = 135F;
            addProd_btn.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            addProd_btn.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            addProd_btn.StatePressed.Border.ColorAngle = 135F;
            addProd_btn.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            addProd_btn.StatePressed.Border.Rounding = 20F;
            addProd_btn.StatePressed.Border.Width = 1;
            addProd_btn.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            addProd_btn.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            addProd_btn.StateTracking.Back.ColorAngle = 45F;
            addProd_btn.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            addProd_btn.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            addProd_btn.StateTracking.Border.ColorAngle = 45F;
            addProd_btn.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            addProd_btn.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            addProd_btn.StateTracking.Border.Rounding = 20F;
            addProd_btn.StateTracking.Border.Width = 1;
            addProd_btn.StateTracking.Content.ShortText.Color1 = Color.White;
            addProd_btn.TabIndex = 59;
            addProd_btn.Values.ExtraText = "  ";
            addProd_btn.Values.Text = "  დამატება        ";
            addProd_btn.Click += addProd_btn_Click;
            // 
            // save_Btn
            // 
            save_Btn.Location = new Point(1156, 671);
            save_Btn.Name = "save_Btn";
            save_Btn.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            save_Btn.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            save_Btn.OverrideDefault.Back.ColorAngle = 45F;
            save_Btn.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            save_Btn.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            save_Btn.OverrideDefault.Border.ColorAngle = 45F;
            save_Btn.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            save_Btn.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            save_Btn.OverrideDefault.Border.Rounding = 20F;
            save_Btn.OverrideDefault.Border.Width = 2;
            save_Btn.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            save_Btn.Size = new Size(197, 70);
            save_Btn.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            save_Btn.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            save_Btn.StateCommon.Back.ColorAngle = 45F;
            save_Btn.StateCommon.Border.Color1 = Color.FromArgb(8, 142, 255);
            save_Btn.StateCommon.Border.Color2 = Color.FromArgb(6, 170, 242);
            save_Btn.StateCommon.Border.ColorAngle = 45F;
            save_Btn.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            save_Btn.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            save_Btn.StateCommon.Border.Rounding = 22F;
            save_Btn.StateCommon.Border.Width = 2;
            save_Btn.StateCommon.Content.ShortText.Color1 = Color.FromArgb(8, 142, 255);
            save_Btn.StateCommon.Content.ShortText.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            save_Btn.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            save_Btn.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            save_Btn.StatePressed.Back.ColorAngle = 135F;
            save_Btn.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            save_Btn.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            save_Btn.StatePressed.Border.ColorAngle = 135F;
            save_Btn.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            save_Btn.StatePressed.Border.Rounding = 20F;
            save_Btn.StatePressed.Border.Width = 1;
            save_Btn.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            save_Btn.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            save_Btn.StateTracking.Back.ColorAngle = 45F;
            save_Btn.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            save_Btn.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            save_Btn.StateTracking.Border.ColorAngle = 45F;
            save_Btn.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            save_Btn.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            save_Btn.StateTracking.Border.Rounding = 20F;
            save_Btn.StateTracking.Border.Width = 1;
            save_Btn.StateTracking.Content.ShortText.Color1 = Color.White;
            save_Btn.TabIndex = 60;
            save_Btn.Values.ExtraText = "  ";
            save_Btn.Values.Image = (Image)resources.GetObject("save_Btn.Values.Image");
            save_Btn.Values.Text = "  შენახვა";
            save_Btn.Click += save_Btn_Click;
            // 
            // addProd_Label
            // 
            addProd_Label.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addProd_Label.ForeColor = Color.FromArgb(64, 64, 64);
            addProd_Label.Location = new Point(3, 271);
            addProd_Label.Name = "addProd_Label";
            addProd_Label.Size = new Size(1375, 48);
            addProd_Label.TabIndex = 61;
            addProd_Label.Text = "პროდუქტის დამატება";
            addProd_Label.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Invoice_UC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(addProd_Label);
            Controls.Add(save_Btn);
            Controls.Add(addProd_btn);
            Controls.Add(invoiceData);
            Controls.Add(dateCheckBox);
            Controls.Add(date_Txt);
            Controls.Add(date_Label);
            Controls.Add(amount_Label);
            Controls.Add(amount_Txt);
            Controls.Add(price_Label);
            Controls.Add(price_Txt);
            Controls.Add(prodName_Label);
            Controls.Add(prodName_Txt);
            Controls.Add(phoneNum_Label);
            Controls.Add(phoneNum_Txt);
            Controls.Add(email_Label);
            Controls.Add(email_Txt);
            Controls.Add(adress_Label);
            Controls.Add(adress_Txt);
            Controls.Add(costumerID_Label);
            Controls.Add(costumerId_Txt);
            Controls.Add(costumerName_Label);
            Controls.Add(costumerName_Txt);
            Controls.Add(costumerInfo_Label);
            Name = "Invoice_UC";
            Size = new Size(1375, 755);
            ((System.ComponentModel.ISupportInitialize)invoiceData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label costumerInfo_Label;
        private Label costumerName_Label;
        private Krypton.Toolkit.KryptonTextBox costumerName_Txt;
        private Label costumerID_Label;
        private Krypton.Toolkit.KryptonTextBox costumerId_Txt;
        private Label adress_Label;
        private Krypton.Toolkit.KryptonTextBox adress_Txt;
        private Label email_Label;
        private Krypton.Toolkit.KryptonTextBox email_Txt;
        private Label phoneNum_Label;
        private Krypton.Toolkit.KryptonTextBox phoneNum_Txt;
        private Label price_Label;
        private Krypton.Toolkit.KryptonTextBox price_Txt;
        private Label prodName_Label;
        private Krypton.Toolkit.KryptonTextBox prodName_Txt;
        private Label amount_Label;
        private Krypton.Toolkit.KryptonTextBox amount_Txt;
        private Label date_Label;
        private Guna.UI2.WinForms.Guna2DateTimePicker date_Txt;
        private CheckBox dateCheckBox;
        private Krypton.Toolkit.KryptonDataGridView invoiceData;
        private Krypton.Toolkit.KryptonButton addProd_btn;
        private Krypton.Toolkit.KryptonButton save_Btn;
        private Label addProd_Label;
    }
}
