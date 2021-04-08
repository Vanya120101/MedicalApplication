
namespace MedicalApplication.Views
{
    partial class DoctorForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DoctorForm));
            this.TopMenu = new System.Windows.Forms.Panel();
            this.TopContentPanel = new System.Windows.Forms.Label();
            this.CancelButton = new System.Windows.Forms.Button();
            this.MenuImages = new System.Windows.Forms.ImageList(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.DoctorFirstNameBox = new System.Windows.Forms.TextBox();
            this.DoctorSecondNameBox = new System.Windows.Forms.TextBox();
            this.DoctorThirdNameBox = new System.Windows.Forms.TextBox();
            this.DoctorSpecialtyBox = new System.Windows.Forms.TextBox();
            this.DoctorExperienceBox = new System.Windows.Forms.TextBox();
            this.CloseButton = new System.Windows.Forms.Button();
            this.ControlDoctorButton = new System.Windows.Forms.Button();
            this.DoctorBirthdateBox = new System.Windows.Forms.DateTimePicker();
            this.OtherDataButton = new System.Windows.Forms.Button();
            this.TopMenu.SuspendLayout();
            this.SuspendLayout();
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
            this.TopMenu.TabIndex = 0;
            // 
            // TopContentPanel
            // 
            this.TopContentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TopContentPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopContentPanel.Location = new System.Drawing.Point(0, 0);
            this.TopContentPanel.Name = "TopContentPanel";
            this.TopContentPanel.Size = new System.Drawing.Size(725, 100);
            this.TopContentPanel.TabIndex = 5;
            this.TopContentPanel.Text = "Добавление доктора";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(75, 150);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Имя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(75, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 26);
            this.label2.TabIndex = 2;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(75, 222);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 26);
            this.label3.TabIndex = 3;
            this.label3.Text = "Отчество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(75, 258);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 26);
            this.label4.TabIndex = 4;
            this.label4.Text = "Дата рождения";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(75, 294);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 26);
            this.label5.TabIndex = 5;
            this.label5.Text = "Специальность";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(75, 330);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 10, 3, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 26);
            this.label6.TabIndex = 6;
            this.label6.Text = "Опыт работы";
            // 
            // DoctorFirstNameBox
            // 
            this.DoctorFirstNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoctorFirstNameBox.Location = new System.Drawing.Point(268, 150);
            this.DoctorFirstNameBox.Name = "DoctorFirstNameBox";
            this.DoctorFirstNameBox.Size = new System.Drawing.Size(441, 32);
            this.DoctorFirstNameBox.TabIndex = 0;
            // 
            // DoctorSecondNameBox
            // 
            this.DoctorSecondNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoctorSecondNameBox.Location = new System.Drawing.Point(268, 186);
            this.DoctorSecondNameBox.Name = "DoctorSecondNameBox";
            this.DoctorSecondNameBox.Size = new System.Drawing.Size(441, 32);
            this.DoctorSecondNameBox.TabIndex = 1;
            // 
            // DoctorThirdNameBox
            // 
            this.DoctorThirdNameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoctorThirdNameBox.Location = new System.Drawing.Point(268, 222);
            this.DoctorThirdNameBox.Name = "DoctorThirdNameBox";
            this.DoctorThirdNameBox.Size = new System.Drawing.Size(441, 32);
            this.DoctorThirdNameBox.TabIndex = 2;
            // 
            // DoctorSpecialtyBox
            // 
            this.DoctorSpecialtyBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoctorSpecialtyBox.Location = new System.Drawing.Point(268, 294);
            this.DoctorSpecialtyBox.Name = "DoctorSpecialtyBox";
            this.DoctorSpecialtyBox.Size = new System.Drawing.Size(441, 32);
            this.DoctorSpecialtyBox.TabIndex = 4;
            // 
            // DoctorExperienceBox
            // 
            this.DoctorExperienceBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoctorExperienceBox.Location = new System.Drawing.Point(268, 330);
            this.DoctorExperienceBox.Name = "DoctorExperienceBox";
            this.DoctorExperienceBox.Size = new System.Drawing.Size(441, 32);
            this.DoctorExperienceBox.TabIndex = 5;
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
            this.CloseButton.Location = new System.Drawing.Point(606, 450);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(103, 38);
            this.CloseButton.TabIndex = 8;
            this.CloseButton.Text = "Отмена";
            this.CloseButton.UseVisualStyleBackColor = true;
            // 
            // ControlDoctorButton
            // 
            this.ControlDoctorButton.AutoSize = true;
            this.ControlDoctorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ControlDoctorButton.FlatAppearance.BorderSize = 0;
            this.ControlDoctorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ControlDoctorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ControlDoctorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ControlDoctorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ControlDoctorButton.Location = new System.Drawing.Point(268, 450);
            this.ControlDoctorButton.Name = "ControlDoctorButton";
            this.ControlDoctorButton.Size = new System.Drawing.Size(122, 38);
            this.ControlDoctorButton.TabIndex = 9;
            this.ControlDoctorButton.Text = "Действие";
            this.ControlDoctorButton.UseVisualStyleBackColor = true;
            // 
            // DoctorBirthdateBox
            // 
            this.DoctorBirthdateBox.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoctorBirthdateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoctorBirthdateBox.Location = new System.Drawing.Point(268, 261);
            this.DoctorBirthdateBox.Name = "DoctorBirthdateBox";
            this.DoctorBirthdateBox.Size = new System.Drawing.Size(441, 32);
            this.DoctorBirthdateBox.TabIndex = 10;
            // 
            // OtherDataButton
            // 
            this.OtherDataButton.AutoSize = true;
            this.OtherDataButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.OtherDataButton.FlatAppearance.BorderSize = 0;
            this.OtherDataButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.OtherDataButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.OtherDataButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OtherDataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.OtherDataButton.Location = new System.Drawing.Point(80, 359);
            this.OtherDataButton.Margin = new System.Windows.Forms.Padding(0, 3, 3, 3);
            this.OtherDataButton.Name = "OtherDataButton";
            this.OtherDataButton.Size = new System.Drawing.Size(177, 38);
            this.OtherDataButton.TabIndex = 11;
            this.OtherDataButton.Text = "Другие данные";
            this.OtherDataButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.OtherDataButton.UseVisualStyleBackColor = true;
            this.OtherDataButton.Click += new System.EventHandler(this.OtherDataButton_Click);
            // 
            // AddDoctorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 500);
            this.Controls.Add(this.OtherDataButton);
            this.Controls.Add(this.DoctorBirthdateBox);
            this.Controls.Add(this.ControlDoctorButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.DoctorFirstNameBox);
            this.Controls.Add(this.DoctorSecondNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DoctorThirdNameBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.DoctorSpecialtyBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.DoctorExperienceBox);
            this.Controls.Add(this.TopMenu);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddDoctorForm";
            this.Text = "AddDoctorForm";
            this.TopMenu.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel TopMenu;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label TopContentPanel;
        private System.Windows.Forms.ImageList MenuImages;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox DoctorFirstNameBox;
        private System.Windows.Forms.TextBox DoctorSecondNameBox;
        private System.Windows.Forms.TextBox DoctorThirdNameBox;
        private System.Windows.Forms.TextBox DoctorSpecialtyBox;
        private System.Windows.Forms.TextBox DoctorExperienceBox;
        private System.Windows.Forms.Button CloseButton;
        private System.Windows.Forms.Button ControlDoctorButton;
        private System.Windows.Forms.DateTimePicker DoctorBirthdateBox;
        private System.Windows.Forms.Button OtherDataButton;
    }
}