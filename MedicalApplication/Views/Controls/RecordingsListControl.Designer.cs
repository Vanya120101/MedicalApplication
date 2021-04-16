
namespace MedicalApplication.Views.Controls
{
    partial class RecordingsListControl
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
            this.RecordingsList = new System.Windows.Forms.DataGridView();
            this.RecordingInformationButton = new System.Windows.Forms.Button();
            this.AddRecordingButton = new System.Windows.Forms.Button();
            this.RemoveRecordingButton = new System.Windows.Forms.Button();
            this.BottomPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.doctorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.patientDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.meetingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.causeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.recordingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.RecordingsList)).BeginInit();
            this.BottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordingBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // RecordingsList
            // 
            this.RecordingsList.AllowUserToAddRows = false;
            this.RecordingsList.AllowUserToDeleteRows = false;
            this.RecordingsList.AllowUserToResizeColumns = false;
            this.RecordingsList.AllowUserToResizeRows = false;
            this.RecordingsList.AutoGenerateColumns = false;
            this.RecordingsList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.RecordingsList.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.RecordingsList.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.RecordingsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecordingsList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.RecordingsList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.RecordingsList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.RecordingsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordingsList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.doctorDataGridViewTextBoxColumn,
            this.patientDataGridViewTextBoxColumn,
            this.meetingTimeDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn,
            this.causeDataGridViewTextBoxColumn});
            this.RecordingsList.DataSource = this.recordingBindingSource;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.RecordingsList.DefaultCellStyle = dataGridViewCellStyle2;
            this.RecordingsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecordingsList.EnableHeadersVisualStyles = false;
            this.RecordingsList.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.RecordingsList.Location = new System.Drawing.Point(0, 0);
            this.RecordingsList.Margin = new System.Windows.Forms.Padding(0);
            this.RecordingsList.MultiSelect = false;
            this.RecordingsList.Name = "RecordingsList";
            this.RecordingsList.ReadOnly = true;
            this.RecordingsList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.RecordingsList.RowHeadersVisible = false;
            this.RecordingsList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.RecordingsList.ShowCellErrors = false;
            this.RecordingsList.ShowCellToolTips = false;
            this.RecordingsList.ShowEditingIcon = false;
            this.RecordingsList.Size = new System.Drawing.Size(2000, 1808);
            this.RecordingsList.TabIndex = 3;
            // 
            // RecordingInformationButton
            // 
            this.RecordingInformationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RecordingInformationButton.AutoSize = true;
            this.RecordingInformationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecordingInformationButton.FlatAppearance.BorderSize = 0;
            this.RecordingInformationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.RecordingInformationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.RecordingInformationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecordingInformationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecordingInformationButton.Location = new System.Drawing.Point(0, 0);
            this.RecordingInformationButton.Margin = new System.Windows.Forms.Padding(0);
            this.RecordingInformationButton.Name = "RecordingInformationButton";
            this.RecordingInformationButton.Padding = new System.Windows.Forms.Padding(60, 58, 60, 58);
            this.RecordingInformationButton.Size = new System.Drawing.Size(436, 185);
            this.RecordingInformationButton.TabIndex = 0;
            this.RecordingInformationButton.Text = "Информация";
            this.RecordingInformationButton.UseVisualStyleBackColor = true;
            this.RecordingInformationButton.Click += new System.EventHandler(this.RecordingInformationButton_Click);
            // 
            // AddRecordingButton
            // 
            this.AddRecordingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddRecordingButton.AutoSize = true;
            this.AddRecordingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddRecordingButton.FlatAppearance.BorderSize = 0;
            this.AddRecordingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.AddRecordingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AddRecordingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRecordingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRecordingButton.Location = new System.Drawing.Point(436, 0);
            this.AddRecordingButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddRecordingButton.Name = "AddRecordingButton";
            this.AddRecordingButton.Padding = new System.Windows.Forms.Padding(60, 58, 60, 58);
            this.AddRecordingButton.Size = new System.Drawing.Size(364, 185);
            this.AddRecordingButton.TabIndex = 1;
            this.AddRecordingButton.Text = "Добавить";
            this.AddRecordingButton.UseVisualStyleBackColor = true;
            this.AddRecordingButton.Click += new System.EventHandler(this.AddRecordingButton_Click);
            // 
            // RemoveRecordingButton
            // 
            this.RemoveRecordingButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveRecordingButton.AutoSize = true;
            this.RemoveRecordingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveRecordingButton.FlatAppearance.BorderSize = 0;
            this.RemoveRecordingButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.RemoveRecordingButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.RemoveRecordingButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveRecordingButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveRecordingButton.Location = new System.Drawing.Point(800, 0);
            this.RemoveRecordingButton.Margin = new System.Windows.Forms.Padding(0);
            this.RemoveRecordingButton.Name = "RemoveRecordingButton";
            this.RemoveRecordingButton.Padding = new System.Windows.Forms.Padding(60, 58, 60, 58);
            this.RemoveRecordingButton.Size = new System.Drawing.Size(512, 185);
            this.RemoveRecordingButton.TabIndex = 2;
            this.RemoveRecordingButton.Text = "Удалить";
            this.RemoveRecordingButton.UseVisualStyleBackColor = true;
            this.RemoveRecordingButton.Click += new System.EventHandler(this.RemoveRecordButton_Click);
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.RecordingInformationButton);
            this.BottomPanel.Controls.Add(this.AddRecordingButton);
            this.BottomPanel.Controls.Add(this.RemoveRecordingButton);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 1808);
            this.BottomPanel.Margin = new System.Windows.Forms.Padding(6);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(2000, 192);
            this.BottomPanel.TabIndex = 4;
            // 
            // doctorDataGridViewTextBoxColumn
            // 
            this.doctorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.doctorDataGridViewTextBoxColumn.DataPropertyName = "Doctor";
            this.doctorDataGridViewTextBoxColumn.HeaderText = "Доктор";
            this.doctorDataGridViewTextBoxColumn.Name = "doctorDataGridViewTextBoxColumn";
            this.doctorDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // patientDataGridViewTextBoxColumn
            // 
            this.patientDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.patientDataGridViewTextBoxColumn.DataPropertyName = "Patient";
            this.patientDataGridViewTextBoxColumn.HeaderText = "Пациент";
            this.patientDataGridViewTextBoxColumn.Name = "patientDataGridViewTextBoxColumn";
            this.patientDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // meetingTimeDataGridViewTextBoxColumn
            // 
            this.meetingTimeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.meetingTimeDataGridViewTextBoxColumn.DataPropertyName = "MeetingTime";
            this.meetingTimeDataGridViewTextBoxColumn.HeaderText = "Дата и время";
            this.meetingTimeDataGridViewTextBoxColumn.Name = "meetingTimeDataGridViewTextBoxColumn";
            this.meetingTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            this.statusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // causeDataGridViewTextBoxColumn
            // 
            this.causeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.causeDataGridViewTextBoxColumn.DataPropertyName = "Cause";
            this.causeDataGridViewTextBoxColumn.HeaderText = "Причина";
            this.causeDataGridViewTextBoxColumn.Name = "causeDataGridViewTextBoxColumn";
            this.causeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // recordingBindingSource
            // 
            this.recordingBindingSource.DataSource = typeof(MedicalApplication.Domain_Models.Recording);
            // 
            // RecordingsListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RecordingsList);
            this.Controls.Add(this.BottomPanel);
            this.Name = "RecordingsListControl";
            this.Size = new System.Drawing.Size(2000, 2000);
            ((System.ComponentModel.ISupportInitialize)(this.RecordingsList)).EndInit();
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordingBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RecordingsList;
        private System.Windows.Forms.DataGridViewTextBoxColumn doctorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn patientDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn meetingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn causeDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource recordingBindingSource;
        private System.Windows.Forms.Button RecordingInformationButton;
        private System.Windows.Forms.Button AddRecordingButton;
        private System.Windows.Forms.Button RemoveRecordingButton;
        private System.Windows.Forms.FlowLayoutPanel BottomPanel;
    }
}
