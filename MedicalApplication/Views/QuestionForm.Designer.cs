﻿
namespace MedicalApplication.Views
{
    partial class QuestionForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuestionForm));
            this.CloseButton = new System.Windows.Forms.Button();
            this.TopMenu = new System.Windows.Forms.Panel();
            this.TopContentPanel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.MenuImages = new System.Windows.Forms.ImageList(this.components);
            this.TopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // CloseButton
            // 
            this.CloseButton.AutoSize = true;
            this.CloseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CloseButton.FlatAppearance.BorderSize = 0;
            this.CloseButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CloseButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.CloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CloseButton.Location = new System.Drawing.Point(606, 431);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(109, 38);
            this.CloseButton.TabIndex = 24;
            this.CloseButton.Text = "Закрыть";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // TopMenu
            // 
            this.TopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(193)))), ((int)(((byte)(230)))));
            this.TopMenu.Controls.Add(this.TopContentPanel);
            this.TopMenu.Controls.Add(this.CancelButton);
            this.TopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Size = new System.Drawing.Size(800, 100);
            this.TopMenu.TabIndex = 12;
            // 
            // TopContentPanel
            // 
            this.TopContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopContentPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopContentPanel.Location = new System.Drawing.Point(0, 0);
            this.TopContentPanel.Name = "TopContentPanel";
            this.TopContentPanel.Size = new System.Drawing.Size(725, 100);
            this.TopContentPanel.TabIndex = 5;
            this.TopContentPanel.Text = "Информация";
            this.TopContentPanel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CancelButton
            // 
            this.CancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.CancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.CancelButton.FlatAppearance.BorderSize = 0;
            this.CancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(193)))), ((int)(((byte)(230)))));
            this.CancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(193)))), ((int)(((byte)(230)))));
            this.CancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CancelButton.ImageKey = "Close.png";
            this.CancelButton.ImageList = this.MenuImages;
            this.CancelButton.Location = new System.Drawing.Point(725, 0);
            this.CancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 100);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // MenuImages
            // 
            this.MenuImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("MenuImages.ImageStream")));
            this.MenuImages.TransparentColor = System.Drawing.Color.Transparent;
            this.MenuImages.Images.SetKeyName(0, "Menu.png");
            this.MenuImages.Images.SetKeyName(1, "Search.png");
            this.MenuImages.Images.SetKeyName(2, "Close.png");
            this.MenuImages.Images.SetKeyName(3, "Minus.png");
            this.MenuImages.Images.SetKeyName(4, "Book.png");
            this.MenuImages.Images.SetKeyName(5, "Doctor.png");
            this.MenuImages.Images.SetKeyName(6, "Ilness.png");
            this.MenuImages.Images.SetKeyName(7, "Recording.png");
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.TopMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuestionForm";
            this.Text = "QuestionForm";
            this.TopMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel TopMenu;
        private System.Windows.Forms.Label TopContentPanel;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.ImageList MenuImages;
    }
}