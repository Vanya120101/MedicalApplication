
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
            this.MyCancelButton = new System.Windows.Forms.Button();
            this.MenuImages = new System.Windows.Forms.ImageList(this.components);
            this.InformationLabel = new System.Windows.Forms.Label();
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
            this.CloseButton.Click += new System.EventHandler(this.CloseButton_Click);
            // 
            // TopMenu
            // 
            this.TopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(193)))), ((int)(((byte)(230)))));
            this.TopMenu.Controls.Add(this.TopContentPanel);
            this.TopMenu.Controls.Add(this.MyCancelButton);
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
            this.TopContentPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopMenu_MouseDown);
            this.TopContentPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopMenu_MouseMove);
            // 
            // MyCancelButton
            // 
            this.MyCancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MyCancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MyCancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.MyCancelButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MyCancelButton.FlatAppearance.BorderSize = 0;
            this.MyCancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(193)))), ((int)(((byte)(230)))));
            this.MyCancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(193)))), ((int)(((byte)(230)))));
            this.MyCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MyCancelButton.ImageKey = "Close.png";
            this.MyCancelButton.ImageList = this.MenuImages;
            this.MyCancelButton.Location = new System.Drawing.Point(725, 0);
            this.MyCancelButton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MyCancelButton.Name = "MyCancelButton";
            this.MyCancelButton.Size = new System.Drawing.Size(75, 100);
            this.MyCancelButton.TabIndex = 4;
            this.MyCancelButton.UseVisualStyleBackColor = true;
            this.MyCancelButton.Click += new System.EventHandler(this.CancelButton_Click);
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
            // InformationLabel
            // 
            this.InformationLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InformationLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.InformationLabel.Location = new System.Drawing.Point(0, 100);
            this.InformationLabel.Name = "InformationLabel";
            this.InformationLabel.Size = new System.Drawing.Size(800, 400);
            this.InformationLabel.TabIndex = 25;
            // 
            // QuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.InformationLabel);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.TopMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "QuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "QuestionForm";
            this.TopMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Panel TopMenu;
        private System.Windows.Forms.Label TopContentPanel;
        private System.Windows.Forms.Button MyCancelButton;
        private System.Windows.Forms.ImageList MenuImages;
        private System.Windows.Forms.Label InformationLabel;
    }
}