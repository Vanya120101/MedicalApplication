
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DoctorsList = new System.Windows.Forms.DataGridView();
            this.RemoveDoctorButton = new System.Windows.Forms.Button();
            this.AddDoctorButton = new System.Windows.Forms.Button();
            this.DoctorInformationButton = new System.Windows.Forms.Button();
            this.BottomPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thirdNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.specialityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsList)).BeginInit();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // DoctorsList
            // 
            this.DoctorsList.AllowUserToAddRows = false;
            this.DoctorsList.AllowUserToDeleteRows = false;
            this.DoctorsList.AllowUserToResizeColumns = false;
            this.DoctorsList.AllowUserToResizeRows = false;
            this.DoctorsList.AutoGenerateColumns = false;
            this.DoctorsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DoctorsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.DoctorsList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DoctorsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DoctorsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DoctorsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DoctorsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DoctorsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DoctorsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.secondNameDataGridViewTextBoxColumn,
            this.thirdNameDataGridViewTextBoxColumn,
            this.specialityDataGridViewTextBoxColumn});
            this.DoctorsList.DataSource = this.doctorBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DoctorsList.DefaultCellStyle = dataGridViewCellStyle2;
            this.DoctorsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DoctorsList.EnableHeadersVisualStyles = false;
            this.DoctorsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.DoctorsList.Location = new System.Drawing.Point(0, 0);
            this.DoctorsList.Margin = new System.Windows.Forms.Padding(0);
            this.DoctorsList.MultiSelect = false;
            this.DoctorsList.Name = "DoctorsList";
            this.DoctorsList.ReadOnly = true;
            this.DoctorsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DoctorsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DoctorsList.RowHeadersVisible = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.DoctorsList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.DoctorsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DoctorsList.ShowCellErrors = false;
            this.DoctorsList.ShowCellToolTips = false;
            this.DoctorsList.ShowEditingIcon = false;
            this.DoctorsList.Size = new System.Drawing.Size(2600, 769);
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
            this.RemoveDoctorButton.Location = new System.Drawing.Point(800, 0);
            this.RemoveDoctorButton.Margin = new System.Windows.Forms.Padding(0);
            this.RemoveDoctorButton.Name = "RemoveDoctorButton";
            this.RemoveDoctorButton.Padding = new System.Windows.Forms.Padding(60, 58, 60, 58);
            this.RemoveDoctorButton.Size = new System.Drawing.Size(512, 185);
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
            this.AddDoctorButton.Location = new System.Drawing.Point(436, 0);
            this.AddDoctorButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddDoctorButton.Name = "AddDoctorButton";
            this.AddDoctorButton.Padding = new System.Windows.Forms.Padding(60, 58, 60, 58);
            this.AddDoctorButton.Size = new System.Drawing.Size(364, 185);
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
            this.DoctorInformationButton.Padding = new System.Windows.Forms.Padding(60, 58, 60, 58);
            this.DoctorInformationButton.Size = new System.Drawing.Size(436, 185);
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
            this.BottomPanel.Location = new System.Drawing.Point(0, 577);
            this.BottomPanel.Margin = new System.Windows.Forms.Padding(6);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(2600, 192);
            this.BottomPanel.TabIndex = 0;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = "Имя";
            this.firstNameDataGridViewTextBoxColumn.Name = "firstNameDataGridViewTextBoxColumn";
            this.firstNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // secondNameDataGridViewTextBoxColumn
            // 
            this.secondNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.secondNameDataGridViewTextBoxColumn.DataPropertyName = "SecondName";
            this.secondNameDataGridViewTextBoxColumn.HeaderText = "Фамилия";
            this.secondNameDataGridViewTextBoxColumn.Name = "secondNameDataGridViewTextBoxColumn";
            this.secondNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // thirdNameDataGridViewTextBoxColumn
            // 
            this.thirdNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.thirdNameDataGridViewTextBoxColumn.DataPropertyName = "ThirdName";
            this.thirdNameDataGridViewTextBoxColumn.HeaderText = "Отчество";
            this.thirdNameDataGridViewTextBoxColumn.Name = "thirdNameDataGridViewTextBoxColumn";
            this.thirdNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // specialityDataGridViewTextBoxColumn
            // 
            this.specialityDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.specialityDataGridViewTextBoxColumn.DataPropertyName = "Speciality";
            this.specialityDataGridViewTextBoxColumn.HeaderText = "Специальность";
            this.specialityDataGridViewTextBoxColumn.Name = "specialityDataGridViewTextBoxColumn";
            this.specialityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataSource = typeof(MedicalApplication.Domain_Models.Doctor);
            // 
            // DoctorsListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.DoctorsList);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "DoctorsListControl";
            this.Size = new System.Drawing.Size(2600, 769);
            ((System.ComponentModel.ISupportInitialize)(this.DoctorsList)).EndInit();
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DoctorsList;
        private System.Windows.Forms.Button RemoveDoctorButton;
        private System.Windows.Forms.Button AddDoctorButton;
        private System.Windows.Forms.Button DoctorInformationButton;
        private System.Windows.Forms.FlowLayoutPanel BottomPanel;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thirdNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn specialityDataGridViewTextBoxColumn;
    }
}
