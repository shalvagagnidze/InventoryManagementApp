﻿namespace InventoryManagementApp.User_Controls
{
    partial class Settings_UC
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
            label1 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(507, 291);
            label1.Name = "label1";
            label1.Size = new Size(76, 25);
            label1.TabIndex = 1;
            label1.Text = "Settings";
            // 
            // Settings_UC
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label1);
            Name = "Settings_UC";
            Size = new Size(1275, 655);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
    }
}