
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
            this.PatientsList = new System.Windows.Forms.DataGridView();
            this.PatientInformationButton = new System.Windows.Forms.Button();
            this.AddPatientButton = new System.Windows.Forms.Button();
            this.RemovePatientButton = new System.Windows.Forms.Button();
            this.BottomPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.PatientsList)).BeginInit();
            this.BottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // PatientsList
            // 
            this.PatientsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PatientsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.PatientsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PatientsList.Location = new System.Drawing.Point(0, 0);
            this.PatientsList.Margin = new System.Windows.Forms.Padding(0);
            this.PatientsList.Name = "PatientsList";
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView PatientsList;
        private System.Windows.Forms.Button PatientInformationButton;
        private System.Windows.Forms.Button AddPatientButton;
        private System.Windows.Forms.Button RemovePatientButton;
        private System.Windows.Forms.FlowLayoutPanel BottomPanel;
    }
}
