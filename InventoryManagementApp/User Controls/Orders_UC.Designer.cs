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
            ordersData = new Krypton.Toolkit.KryptonDataGridView();
            ((System.ComponentModel.ISupportInitialize)ordersData).BeginInit();
            SuspendLayout();
            // 
            // ordersData
            // 
            ordersData.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ordersData.BorderStyle = BorderStyle.None;
            ordersData.ColumnHeadersHeight = 51;
            ordersData.ImeMode = ImeMode.On;
            ordersData.Location = new Point(0, 148);
            ordersData.Name = "ordersData";
            ordersData.PaletteMode = Krypton.Toolkit.PaletteMode.ProfessionalSystem;
            ordersData.ReadOnly = true;
            ordersData.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            ordersData.RowTemplate.DividerHeight = 3;
            ordersData.RowTemplate.Resizable = DataGridViewTriState.False;
            ordersData.Size = new Size(1275, 507);
            ordersData.StateCommon.BackStyle = Krypton.Toolkit.PaletteBackStyle.GridBackgroundList;
            ordersData.StateCommon.DataCell.Border.DrawBorders = Krypton.Toolkit.PaletteDrawBorders.Top | Krypton.Toolkit.PaletteDrawBorders.Bottom | Krypton.Toolkit.PaletteDrawBorders.Left | Krypton.Toolkit.PaletteDrawBorders.Right;
            ordersData.StateCommon.DataCell.Border.Rounding = 5F;
            ordersData.StateCommon.DataCell.Border.Width = 1;
            ordersData.StateCommon.DataCell.Content.Color1 = Color.FromArgb(64, 64, 64);
            ordersData.StateCommon.DataCell.Content.Font = new Font("Georgia", 8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ordersData.TabIndex = 2;
            // 
            // Orders_UC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ordersData);
            Name = "Orders_UC";
            Size = new Size(1275, 655);
            ((System.ComponentModel.ISupportInitialize)ordersData).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Krypton.Toolkit.KryptonDataGridView ordersData;
    }
}
