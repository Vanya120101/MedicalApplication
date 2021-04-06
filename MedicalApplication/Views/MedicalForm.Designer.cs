
namespace MedicalApplication.Views
{
    partial class MedicalForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicalForm));
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.LeftMenu = new System.Windows.Forms.Panel();
            this.SelectedIndicator = new System.Windows.Forms.Panel();
            this.StatisticsButton = new System.Windows.Forms.Button();
            this.MenuImages = new System.Windows.Forms.ImageList(this.components);
            this.RecordingButton = new System.Windows.Forms.Button();
            this.PatientsButton = new System.Windows.Forms.Button();
            this.DoctorsButton = new System.Windows.Forms.Button();
            this.TopMenu = new System.Windows.Forms.Panel();
            this.MinimizeButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.ButtonMenu = new System.Windows.Forms.Button();
            this.QuestionButton = new System.Windows.Forms.Button();
            this.LeftMenu.SuspendLayout();
            this.TopMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // ContentPanel
            // 
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ContentPanel.ForeColor = System.Drawing.Color.Black;
            this.ContentPanel.Location = new System.Drawing.Point(300, 81);
            this.ContentPanel.Margin = new System.Windows.Forms.Padding(2);
            this.ContentPanel.MinimumSize = new System.Drawing.Size(416, 329);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(500, 369);
            this.ContentPanel.TabIndex = 5;
            // 
            // LeftMenu
            // 
            this.LeftMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.LeftMenu.Controls.Add(this.SelectedIndicator);
            this.LeftMenu.Controls.Add(this.StatisticsButton);
            this.LeftMenu.Controls.Add(this.RecordingButton);
            this.LeftMenu.Controls.Add(this.PatientsButton);
            this.LeftMenu.Controls.Add(this.DoctorsButton);
            this.LeftMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftMenu.ForeColor = System.Drawing.Color.Coral;
            this.LeftMenu.Location = new System.Drawing.Point(0, 81);
            this.LeftMenu.Margin = new System.Windows.Forms.Padding(2);
            this.LeftMenu.Name = "LeftMenu";
            this.LeftMenu.Size = new System.Drawing.Size(300, 369);
            this.LeftMenu.TabIndex = 3;
            // 
            // SelectedIndicator
            // 
            this.SelectedIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(193)))), ((int)(((byte)(230)))));
            this.SelectedIndicator.Location = new System.Drawing.Point(0, 0);
            this.SelectedIndicator.Margin = new System.Windows.Forms.Padding(2);
            this.SelectedIndicator.Name = "SelectedIndicator";
            this.SelectedIndicator.Size = new System.Drawing.Size(4, 65);
            this.SelectedIndicator.TabIndex = 2;
            // 
            // StatisticsButton
            // 
            this.StatisticsButton.AutoSize = true;
            this.StatisticsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.StatisticsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.StatisticsButton.FlatAppearance.BorderSize = 0;
            this.StatisticsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.StatisticsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.StatisticsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatisticsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.StatisticsButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.StatisticsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StatisticsButton.ImageKey = "Book.png";
            this.StatisticsButton.ImageList = this.MenuImages;
            this.StatisticsButton.Location = new System.Drawing.Point(0, 195);
            this.StatisticsButton.Margin = new System.Windows.Forms.Padding(0);
            this.StatisticsButton.Name = "StatisticsButton";
            this.StatisticsButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.StatisticsButton.Size = new System.Drawing.Size(300, 65);
            this.StatisticsButton.TabIndex = 3;
            this.StatisticsButton.Text = "Статистика";
            this.StatisticsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.StatisticsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.StatisticsButton.UseVisualStyleBackColor = true;
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
            // RecordingButton
            // 
            this.RecordingButton.AutoSize = true;
            this.RecordingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecordingButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.RecordingButton.FlatAppearance.BorderSize = 0;
            this.RecordingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.RecordingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.RecordingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecordingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecordingButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.RecordingButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RecordingButton.ImageKey = "Recording.png";
            this.RecordingButton.ImageList = this.MenuImages;
            this.RecordingButton.Location = new System.Drawing.Point(0, 130);
            this.RecordingButton.Margin = new System.Windows.Forms.Padding(0);
            this.RecordingButton.Name = "RecordingButton";
            this.RecordingButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.RecordingButton.Size = new System.Drawing.Size(300, 65);
            this.RecordingButton.TabIndex = 2;
            this.RecordingButton.Text = "Записи";
            this.RecordingButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RecordingButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.RecordingButton.UseVisualStyleBackColor = true;
            // 
            // PatientsButton
            // 
            this.PatientsButton.AutoSize = true;
            this.PatientsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PatientsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.PatientsButton.FlatAppearance.BorderSize = 0;
            this.PatientsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.PatientsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.PatientsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatientsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatientsButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PatientsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PatientsButton.ImageKey = "Ilness.png";
            this.PatientsButton.ImageList = this.MenuImages;
            this.PatientsButton.Location = new System.Drawing.Point(0, 65);
            this.PatientsButton.Margin = new System.Windows.Forms.Padding(0);
            this.PatientsButton.Name = "PatientsButton";
            this.PatientsButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.PatientsButton.Size = new System.Drawing.Size(300, 65);
            this.PatientsButton.TabIndex = 1;
            this.PatientsButton.Text = "Пациенты";
            this.PatientsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.PatientsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.PatientsButton.UseVisualStyleBackColor = true;
            // 
            // DoctorsButton
            // 
            this.DoctorsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoctorsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.DoctorsButton.FlatAppearance.BorderSize = 0;
            this.DoctorsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.DoctorsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.DoctorsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoctorsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoctorsButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DoctorsButton.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DoctorsButton.ImageKey = "Doctor.png";
            this.DoctorsButton.ImageList = this.MenuImages;
            this.DoctorsButton.Location = new System.Drawing.Point(0, 0);
            this.DoctorsButton.Margin = new System.Windows.Forms.Padding(0);
            this.DoctorsButton.Name = "DoctorsButton";
            this.DoctorsButton.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.DoctorsButton.Size = new System.Drawing.Size(300, 65);
            this.DoctorsButton.TabIndex = 0;
            this.DoctorsButton.Text = "Доктора";
            this.DoctorsButton.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DoctorsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DoctorsButton.UseVisualStyleBackColor = true;
            // 
            // TopMenu
            // 
            this.TopMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(193)))), ((int)(((byte)(230)))));
            this.TopMenu.Controls.Add(this.QuestionButton);
            this.TopMenu.Controls.Add(this.MinimizeButton);
            this.TopMenu.Controls.Add(this.CancelButton);
            this.TopMenu.Controls.Add(this.ButtonMenu);
            this.TopMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopMenu.Location = new System.Drawing.Point(0, 0);
            this.TopMenu.Margin = new System.Windows.Forms.Padding(2);
            this.TopMenu.Name = "TopMenu";
            this.TopMenu.Size = new System.Drawing.Size(800, 81);
            this.TopMenu.TabIndex = 4;
            // 
            // MinimizeButton
            // 
            this.MinimizeButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.MinimizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MinimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.MinimizeButton.FlatAppearance.BorderSize = 0;
            this.MinimizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(193)))), ((int)(((byte)(230)))));
            this.MinimizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(193)))), ((int)(((byte)(230)))));
            this.MinimizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinimizeButton.ImageKey = "Minus.png";
            this.MinimizeButton.ImageList = this.MenuImages;
            this.MinimizeButton.Location = new System.Drawing.Point(650, 0);
            this.MinimizeButton.Margin = new System.Windows.Forms.Padding(2);
            this.MinimizeButton.Name = "MinimizeButton";
            this.MinimizeButton.Size = new System.Drawing.Size(75, 81);
            this.MinimizeButton.TabIndex = 4;
            this.MinimizeButton.UseVisualStyleBackColor = true;
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
            this.CancelButton.Size = new System.Drawing.Size(75, 81);
            this.CancelButton.TabIndex = 3;
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // ButtonMenu
            // 
            this.ButtonMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ButtonMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.ButtonMenu.FlatAppearance.BorderSize = 0;
            this.ButtonMenu.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(193)))), ((int)(((byte)(230)))));
            this.ButtonMenu.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(193)))), ((int)(((byte)(230)))));
            this.ButtonMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonMenu.ImageKey = "Menu.png";
            this.ButtonMenu.ImageList = this.MenuImages;
            this.ButtonMenu.Location = new System.Drawing.Point(0, 0);
            this.ButtonMenu.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonMenu.Name = "ButtonMenu";
            this.ButtonMenu.Size = new System.Drawing.Size(150, 81);
            this.ButtonMenu.TabIndex = 0;
            this.ButtonMenu.UseVisualStyleBackColor = true;
            // 
            // QuestionButton
            // 
            this.QuestionButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.QuestionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.QuestionButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.QuestionButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.QuestionButton.FlatAppearance.BorderSize = 0;
            this.QuestionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(193)))), ((int)(((byte)(230)))));
            this.QuestionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(193)))), ((int)(((byte)(230)))));
            this.QuestionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.QuestionButton.ImageKey = "Search.png";
            this.QuestionButton.ImageList = this.MenuImages;
            this.QuestionButton.Location = new System.Drawing.Point(575, 0);
            this.QuestionButton.Margin = new System.Windows.Forms.Padding(2);
            this.QuestionButton.Name = "QuestionButton";
            this.QuestionButton.Size = new System.Drawing.Size(75, 81);
            this.QuestionButton.TabIndex = 5;
            this.QuestionButton.UseVisualStyleBackColor = true;
            // 
            // MedicalForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.LeftMenu);
            this.Controls.Add(this.TopMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MedicalForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.LeftMenu.ResumeLayout(false);
            this.LeftMenu.PerformLayout();
            this.TopMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Panel LeftMenu;
        private System.Windows.Forms.Panel SelectedIndicator;
        private System.Windows.Forms.Button StatisticsButton;
        private System.Windows.Forms.ImageList MenuImages;
        private System.Windows.Forms.Button RecordingButton;
        private System.Windows.Forms.Button PatientsButton;
        private System.Windows.Forms.Button DoctorsButton;
        private System.Windows.Forms.Panel TopMenu;
        private System.Windows.Forms.Button MinimizeButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button ButtonMenu;
        private System.Windows.Forms.Button QuestionButton;
    }
}