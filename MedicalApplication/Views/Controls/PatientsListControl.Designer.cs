
namespace MedicalApplication.Views.Controls
{
    partial class PatientsListControl
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
            this.PatientsList = new System.Windows.Forms.DataGridView();
            this.PatientInformationButton = new System.Windows.Forms.Button();
            this.AddPatientButton = new System.Windows.Forms.Button();
            this.RemovePatientButton = new System.Windows.Forms.Button();
            this.BottomPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.firstNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.secondNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.thirdNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.birthdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PatientsList)).BeginInit();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PatientsList
            // 
            this.PatientsList.AllowUserToAddRows = false;
            this.PatientsList.AllowUserToDeleteRows = false;
            this.PatientsList.AllowUserToResizeColumns = false;
            this.PatientsList.AllowUserToResizeRows = false;
            this.PatientsList.AutoGenerateColumns = false;
            this.PatientsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.PatientsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.PatientsList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PatientsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatientsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.PatientsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PatientsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.PatientsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.firstNameDataGridViewTextBoxColumn,
            this.secondNameDataGridViewTextBoxColumn,
            this.thirdNameDataGridViewTextBoxColumn,
            this.birthdateDataGridViewTextBoxColumn});
            this.PatientsList.DataSource = this.patientBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.PatientsList.DefaultCellStyle = dataGridViewCellStyle2;
            this.PatientsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PatientsList.EnableHeadersVisualStyles = false;
            this.PatientsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.PatientsList.Location = new System.Drawing.Point(0, 0);
            this.PatientsList.Margin = new System.Windows.Forms.Padding(0);
            this.PatientsList.MultiSelect = false;
            this.PatientsList.Name = "PatientsList";
            this.PatientsList.ReadOnly = true;
            this.PatientsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.PatientsList.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.PatientsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.PatientsList.ShowCellErrors = false;
            this.PatientsList.ShowCellToolTips = false;
            this.PatientsList.ShowEditingIcon = false;
            this.PatientsList.ShowRowErrors = false;
            this.PatientsList.Size = new System.Drawing.Size(1300, 400);
            this.PatientsList.TabIndex = 4;
            // 
            // PatientInformationButton
            // 
            this.PatientInformationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PatientInformationButton.AutoSize = true;
            this.PatientInformationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PatientInformationButton.FlatAppearance.BorderSize = 0;
            this.PatientInformationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.PatientInformationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.PatientInformationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PatientInformationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.PatientInformationButton.Location = new System.Drawing.Point(0, 0);
            this.PatientInformationButton.Margin = new System.Windows.Forms.Padding(0);
            this.PatientInformationButton.Name = "PatientInformationButton";
            this.PatientInformationButton.Padding = new System.Windows.Forms.Padding(30);
            this.PatientInformationButton.Size = new System.Drawing.Size(218, 96);
            this.PatientInformationButton.TabIndex = 0;
            this.PatientInformationButton.Text = "Информация";
            this.PatientInformationButton.UseVisualStyleBackColor = true;
            this.PatientInformationButton.Click += new System.EventHandler(this.PatientInformationButton_Click);
            // 
            // AddPatientButton
            // 
            this.AddPatientButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddPatientButton.AutoSize = true;
            this.AddPatientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddPatientButton.FlatAppearance.BorderSize = 0;
            this.AddPatientButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.AddPatientButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AddPatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddPatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddPatientButton.Location = new System.Drawing.Point(218, 0);
            this.AddPatientButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddPatientButton.Name = "AddPatientButton";
            this.AddPatientButton.Padding = new System.Windows.Forms.Padding(30);
            this.AddPatientButton.Size = new System.Drawing.Size(182, 96);
            this.AddPatientButton.TabIndex = 1;
            this.AddPatientButton.Text = "Добавить";
            this.AddPatientButton.UseVisualStyleBackColor = true;
            this.AddPatientButton.Click += new System.EventHandler(this.AddPatientButton_Click);
            // 
            // RemovePatientButton
            // 
            this.RemovePatientButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemovePatientButton.AutoSize = true;
            this.RemovePatientButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemovePatientButton.FlatAppearance.BorderSize = 0;
            this.RemovePatientButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.RemovePatientButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.RemovePatientButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemovePatientButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemovePatientButton.Location = new System.Drawing.Point(400, 0);
            this.RemovePatientButton.Margin = new System.Windows.Forms.Padding(0);
            this.RemovePatientButton.Name = "RemovePatientButton";
            this.RemovePatientButton.Padding = new System.Windows.Forms.Padding(30);
            this.RemovePatientButton.Size = new System.Drawing.Size(256, 96);
            this.RemovePatientButton.TabIndex = 2;
            this.RemovePatientButton.Text = "Удалить";
            this.RemovePatientButton.UseVisualStyleBackColor = true;
            this.RemovePatientButton.Click += new System.EventHandler(this.RemovePatientButton_Click);
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.PatientInformationButton);
            this.BottomPanel.Controls.Add(this.AddPatientButton);
            this.BottomPanel.Controls.Add(this.RemovePatientButton);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 300);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1300, 100);
            this.BottomPanel.TabIndex = 0;
            // 
            // firstNameDataGridViewTextBoxColumn
            // 
            this.firstNameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName";
            this.firstNameDataGridViewTextBoxColumn.HeaderText = " Имя";
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
            // birthdateDataGridViewTextBoxColumn
            // 
            this.birthdateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.birthdateDataGridViewTextBoxColumn.DataPropertyName = "Birthdate";
            this.birthdateDataGridViewTextBoxColumn.HeaderText = "Дата рождения";
            this.birthdateDataGridViewTextBoxColumn.Name = "birthdateDataGridViewTextBoxColumn";
            this.birthdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientBindingSource
            // 
            this.patientBindingSource.DataSource = typeof(MedicalApplication.Domain_Models.Patient);
            // 
            // PatientsListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BottomPanel);
            this.Controls.Add(this.PatientsList);
            this.Name = "PatientsListControl";
            this.Size = new System.Drawing.Size(1300, 400);
            ((System.ComponentModel.ISupportInitialize)(this.PatientsList)).EndInit();
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.patientBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PatientsList;
        private System.Windows.Forms.Button PatientInformationButton;
        private System.Windows.Forms.Button AddPatientButton;
        private System.Windows.Forms.Button RemovePatientButton;
        private System.Windows.Forms.FlowLayoutPanel BottomPanel;
        private System.Windows.Forms.BindingSource patientBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn secondNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn thirdNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn birthdateDataGridViewTextBoxColumn;
    }
}
