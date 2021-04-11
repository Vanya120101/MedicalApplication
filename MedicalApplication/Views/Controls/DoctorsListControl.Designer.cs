
namespace MedicalApplication.Views.Controls
{
    partial class DoctorsListControl
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DoctorsList = new System.Windows.Forms.DataGridView();
            this.RemoveDoctorButton = new System.Windows.Forms.Button();
            this.AddDoctorButton = new System.Windows.Forms.Button();
            this.DoctorInformationButton = new System.Windows.Forms.Button();
            this.BottomPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsList)).BeginInit();
            this.BottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // DoctorsList
            // 
            this.DoctorsList.AllowUserToAddRows = false;
            this.DoctorsList.AllowUserToDeleteRows = false;
            this.DoctorsList.AllowUserToResizeRows = false;
            this.DoctorsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DoctorsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllHeaders;
            this.DoctorsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DoctorsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DoctorsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DoctorsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DoctorsList.DefaultCellStyle = dataGridViewCellStyle2;
            this.DoctorsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoctorsList.EnableHeadersVisualStyles = false;
            this.DoctorsList.Location = new System.Drawing.Point(0, 0);
            this.DoctorsList.Margin = new System.Windows.Forms.Padding(0);
            this.DoctorsList.Name = "DoctorsList";
            this.DoctorsList.Size = new System.Drawing.Size(1300, 400);
            this.DoctorsList.TabIndex = 0;
            // 
            // RemoveDoctorButton
            // 
            this.RemoveDoctorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveDoctorButton.AutoSize = true;
            this.RemoveDoctorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveDoctorButton.FlatAppearance.BorderSize = 0;
            this.RemoveDoctorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.RemoveDoctorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.RemoveDoctorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveDoctorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveDoctorButton.Location = new System.Drawing.Point(400, 0);
            this.RemoveDoctorButton.Margin = new System.Windows.Forms.Padding(0);
            this.RemoveDoctorButton.Name = "RemoveDoctorButton";
            this.RemoveDoctorButton.Padding = new System.Windows.Forms.Padding(30);
            this.RemoveDoctorButton.Size = new System.Drawing.Size(256, 96);
            this.RemoveDoctorButton.TabIndex = 2;
            this.RemoveDoctorButton.Text = "Удалить";
            this.RemoveDoctorButton.UseVisualStyleBackColor = true;
            this.RemoveDoctorButton.Click += new System.EventHandler(this.RemoveDoctorButton_Click);
            // 
            // AddDoctorButton
            // 
            this.AddDoctorButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDoctorButton.AutoSize = true;
            this.AddDoctorButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddDoctorButton.FlatAppearance.BorderSize = 0;
            this.AddDoctorButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.AddDoctorButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AddDoctorButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddDoctorButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddDoctorButton.Location = new System.Drawing.Point(218, 0);
            this.AddDoctorButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddDoctorButton.Name = "AddDoctorButton";
            this.AddDoctorButton.Padding = new System.Windows.Forms.Padding(30);
            this.AddDoctorButton.Size = new System.Drawing.Size(182, 96);
            this.AddDoctorButton.TabIndex = 1;
            this.AddDoctorButton.Text = "Добавить";
            this.AddDoctorButton.UseVisualStyleBackColor = true;
            this.AddDoctorButton.Click += new System.EventHandler(this.AddDoctorButton_Click);
            // 
            // DoctorInformationButton
            // 
            this.DoctorInformationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DoctorInformationButton.AutoSize = true;
            this.DoctorInformationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoctorInformationButton.FlatAppearance.BorderSize = 0;
            this.DoctorInformationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.DoctorInformationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.DoctorInformationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DoctorInformationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DoctorInformationButton.Location = new System.Drawing.Point(0, 0);
            this.DoctorInformationButton.Margin = new System.Windows.Forms.Padding(0);
            this.DoctorInformationButton.Name = "DoctorInformationButton";
            this.DoctorInformationButton.Padding = new System.Windows.Forms.Padding(30);
            this.DoctorInformationButton.Size = new System.Drawing.Size(218, 96);
            this.DoctorInformationButton.TabIndex = 0;
            this.DoctorInformationButton.Text = "Информация";
            this.DoctorInformationButton.UseVisualStyleBackColor = true;
            this.DoctorInformationButton.Click += new System.EventHandler(this.DoctorInformationButton_Click);
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.DoctorInformationButton);
            this.BottomPanel.Controls.Add(this.AddDoctorButton);
            this.BottomPanel.Controls.Add(this.RemoveDoctorButton);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 300);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1300, 100);
            this.BottomPanel.TabIndex = 0;
            // 
            // DoctorsListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.DoctorsList);
            this.Name = "DoctorsListControl";
            this.Size = new System.Drawing.Size(1300, 400);
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsList)).EndInit();
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DoctorsList;
        private System.Windows.Forms.Button RemoveDoctorButton;
        private System.Windows.Forms.Button AddDoctorButton;
        private System.Windows.Forms.Button DoctorInformationButton;
        private System.Windows.Forms.FlowLayoutPanel BottomPanel;
    }
}
