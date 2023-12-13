namespace InventoryManagementApp.User_Controls
{
    partial class Orders_UC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Orders_UC));
            ordersData = new Krypton.Toolkit.KryptonDataGridView();
            delete_Btn = new Krypton.Toolkit.KryptonButton();
            edit_Btn = new Krypton.Toolkit.KryptonButton();
            fromDate = new Krypton.Toolkit.KryptonDateTimePicker();
            toDate = new Krypton.Toolkit.KryptonDateTimePicker();
            searchButton = new Krypton.Toolkit.KryptonButton();
            productName_Label = new Label();
            label1 = new Label();
            dateCheck = new CheckBox();
            Search_Txt = new Krypton.Toolkit.KryptonTextBox();
            ((System.ComponentModel.ISupportInitialize)ordersData).BeginInit();
            SuspendLayout();
            // 
            // ordersData
            // 
            ordersData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ordersData.BorderStyle = BorderStyle.None;
            ordersData.ColumnHeadersHeight = 51;
            ordersData.ImeMode = ImeMode.On;
            ordersData.Location = new Point(0, 113);
            ordersData.Name = "ordersData";
            ordersData.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            ordersData.ReadOnly = true;
            ordersData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            ordersData.RowTemplate.DividerHeight = 3;
            ordersData.RowTemplate.Resizable = DataGridViewTriState.False;
            ordersData.Size = new Size(1375, 642);
            ordersData.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            ordersData.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ordersData.StateCommon.DataCell.Border.Rounding = 5F;
            ordersData.StateCommon.DataCell.Border.Width = 1;
            ordersData.StateCommon.DataCell.Content.Color1 = Color.FromArgb(64, 64, 64);
            ordersData.StateCommon.DataCell.Content.Font = new Font("Georgia", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ordersData.TabIndex = 2;
            // 
            // delete_Btn
            // 
            delete_Btn.Location = new Point(3, 16);
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
            delete_Btn.TabIndex = 20;
            delete_Btn.Values.ExtraText = "       ";
            delete_Btn.Values.Image = (Image)resources.GetObject("delete_Btn.Values.Image");
            delete_Btn.Values.Text = "წაშლა";
            delete_Btn.Click += delete_Btn_Click;
            // 
            // edit_Btn
            // 
            edit_Btn.Location = new Point(172, 16);
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
            edit_Btn.TabIndex = 19;
            edit_Btn.Values.ExtraText = "    ";
            edit_Btn.Values.Image = Properties.Resources.Edit_48;
            edit_Btn.Values.Text = "  რედაქტირება";
            edit_Btn.Click += edit_Btn_Click;
            // 
            // fromDate
            // 
            fromDate.AutoShift = true;
            fromDate.Format = DateTimePickerFormat.Short;
            fromDate.Location = new Point(920, 32);
            fromDate.Name = "fromDate";
            fromDate.Size = new Size(136, 39);
            fromDate.StateCommon.Back.Color1 = Color.White;
            fromDate.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            fromDate.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            fromDate.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            fromDate.StateCommon.Border.Rounding = 20F;
            fromDate.StateCommon.Border.Width = 1;
            fromDate.StateCommon.Content.Color1 = Color.Gray;
            fromDate.StateCommon.Content.Font = new Font("Segoe UI Symbol", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            fromDate.TabIndex = 21;
            // 
            // toDate
            // 
            toDate.AutoShift = true;
            toDate.Format = DateTimePickerFormat.Short;
            toDate.Location = new Point(1108, 32);
            toDate.Name = "toDate";
            toDate.Size = new Size(136, 39);
            toDate.StateCommon.Back.Color1 = Color.White;
            toDate.StateCommon.Border.Color1 = Color.FromArgb(224, 224, 224);
            toDate.StateCommon.Border.Color2 = Color.FromArgb(224, 224, 224);
            toDate.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            toDate.StateCommon.Border.Rounding = 20F;
            toDate.StateCommon.Border.Width = 1;
            toDate.StateCommon.Content.Color1 = Color.Gray;
            toDate.StateCommon.Content.Font = new Font("Segoe UI Symbol", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            toDate.TabIndex = 22;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(1308, 16);
            searchButton.Name = "searchButton";
            searchButton.OverrideDefault.Back.Color1 = Color.FromArgb(250, 252, 252);
            searchButton.OverrideDefault.Back.Color2 = Color.FromArgb(250, 252, 252);
            searchButton.OverrideDefault.Back.ColorAngle = 45F;
            searchButton.OverrideDefault.Border.Color1 = Color.FromArgb(8, 142, 254);
            searchButton.OverrideDefault.Border.Color2 = Color.FromArgb(8, 142, 254);
            searchButton.OverrideDefault.Border.ColorAngle = 45F;
            searchButton.OverrideDefault.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            searchButton.OverrideDefault.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            searchButton.OverrideDefault.Border.Rounding = 20F;
            searchButton.OverrideDefault.Border.Width = 2;
            searchButton.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            searchButton.Size = new Size(64, 70);
            searchButton.StateCommon.Back.Color1 = Color.FromArgb(250, 252, 252);
            searchButton.StateCommon.Back.Color2 = Color.FromArgb(250, 252, 252);
            searchButton.StateCommon.Back.ColorAngle = 45F;
            searchButton.StateCommon.Border.Color1 = Color.FromArgb(120, 120, 120);
            searchButton.StateCommon.Border.Color2 = Color.FromArgb(140, 150, 180);
            searchButton.StateCommon.Border.ColorAngle = 45F;
            searchButton.StateCommon.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            searchButton.StateCommon.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            searchButton.StateCommon.Border.Rounding = 22F;
            searchButton.StateCommon.Border.Width = 2;
            searchButton.StateCommon.Content.ShortText.Color1 = Color.FromArgb(228, 9, 60);
            searchButton.StateCommon.Content.ShortText.Font = new Font("Georgia", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            searchButton.StatePressed.Back.Color1 = Color.FromArgb(20, 145, 198);
            searchButton.StatePressed.Back.Color2 = Color.FromArgb(22, 121, 206);
            searchButton.StatePressed.Back.ColorAngle = 135F;
            searchButton.StatePressed.Border.Color1 = Color.FromArgb(20, 145, 198);
            searchButton.StatePressed.Border.Color2 = Color.FromArgb(22, 121, 206);
            searchButton.StatePressed.Border.ColorAngle = 135F;
            searchButton.StatePressed.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            searchButton.StatePressed.Border.Rounding = 20F;
            searchButton.StatePressed.Border.Width = 1;
            searchButton.StateTracking.Back.Color1 = Color.FromArgb(8, 142, 254);
            searchButton.StateTracking.Back.Color2 = Color.FromArgb(6, 174, 244);
            searchButton.StateTracking.Back.ColorAngle = 45F;
            searchButton.StateTracking.Border.Color1 = Color.FromArgb(6, 174, 244);
            searchButton.StateTracking.Border.Color2 = Color.FromArgb(8, 142, 254);
            searchButton.StateTracking.Border.ColorAngle = 45F;
            searchButton.StateTracking.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            searchButton.StateTracking.Border.GraphicsHint = Krypton.Toolkit.PaletteGraphicsHint.AntiAlias;
            searchButton.StateTracking.Border.Rounding = 20F;
            searchButton.StateTracking.Border.Width = 1;
            searchButton.StateTracking.Content.ShortText.Color1 = Color.White;
            searchButton.TabIndex = 23;
            searchButton.Values.ExtraText = "           ";
            searchButton.Values.Image = Properties.Resources.Search_40;
            searchButton.Values.Text = "";
            searchButton.Click += searchButton_Click;
            // 
            // productName_Label
            // 
            productName_Label.AutoSize = true;
            productName_Label.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            productName_Label.ForeColor = Color.FromArgb(64, 64, 64);
            productName_Label.Location = new Point(1051, 40);
            productName_Label.Name = "productName_Label";
            productName_Label.Size = new Size(51, 21);
            productName_Label.TabIndex = 38;
            productName_Label.Text = "-დან";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(64, 64, 64);
            label1.Location = new Point(1241, 40);
            label1.Name = "label1";
            label1.Size = new Size(51, 21);
            label1.TabIndex = 39;
            label1.Text = "-მდე";
            // 
            // dateCheck
            // 
            dateCheck.AutoSize = true;
            dateCheck.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dateCheck.Location = new Point(1188, 82);
            dateCheck.Name = "dateCheck";
            dateCheck.Size = new Size(104, 25);
            dateCheck.TabIndex = 40;
            dateCheck.Text = "გათიშვა";
            dateCheck.UseVisualStyleBackColor = true;
            dateCheck.CheckedChanged += dateCheck_CheckedChanged;
            // 
            // Search_Txt
            // 
            Search_Txt.Location = new Point(416, 32);
            Search_Txt.Multiline = true;
            Search_Txt.Name = "Search_Txt";
            Search_Txt.Size = new Size(453, 39);
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
            Search_Txt.TabIndex = 41;
            Search_Txt.Text = "ძებნა...";
            Search_Txt.TextChanged += Search_Txt_TextChanged;
            // 
            // Orders_UC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Search_Txt);
            Controls.Add(dateCheck);
            Controls.Add(label1);
            Controls.Add(productName_Label);
            Controls.Add(searchButton);
            Controls.Add(toDate);
            Controls.Add(fromDate);
            Controls.Add(delete_Btn);
            Controls.Add(edit_Btn);
            Controls.Add(ordersData);
            Name = "Orders_UC";
            Size = new Size(1375, 755);
            ((System.ComponentModel.ISupportInitialize)ordersData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView ordersData;
        private Krypton.Toolkit.KryptonButton delete_Btn;
        private Krypton.Toolkit.KryptonButton edit_Btn;
        private Krypton.Toolkit.KryptonDateTimePicker fromDate;
        private Krypton.Toolkit.KryptonDateTimePicker toDate;
        private Krypton.Toolkit.KryptonButton searchButton;
        private Label productName_Label;
        private Label label1;
        private CheckBox dateCheck;
        private Krypton.Toolkit.KryptonTextBox Search_Txt;
    }
}
