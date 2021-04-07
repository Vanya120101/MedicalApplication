
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
            this.RecordingsList = new System.Windows.Forms.DataGridView();
            this.RecordingInformationButton = new System.Windows.Forms.Button();
            this.AddRecordingButton = new System.Windows.Forms.Button();
            this.RemoveRecordButton = new System.Windows.Forms.Button();
            this.BottomPanel = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.RecordingsList)).BeginInit();
            this.BottomPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RecordingsList
            // 
            this.RecordingsList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RecordingsList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.RecordingsList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RecordingsList.Location = new System.Drawing.Point(0, 0);
            this.RecordingsList.Margin = new System.Windows.Forms.Padding(0);
            this.RecordingsList.Name = "RecordingsList";
            this.RecordingsList.Size = new System.Drawing.Size(1300, 300);
            this.RecordingsList.TabIndex = 6;
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
            this.RecordingInformationButton.Padding = new System.Windows.Forms.Padding(30);
            this.RecordingInformationButton.Size = new System.Drawing.Size(218, 96);
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
            this.AddRecordingButton.Location = new System.Drawing.Point(218, 0);
            this.AddRecordingButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddRecordingButton.Name = "AddRecordingButton";
            this.AddRecordingButton.Padding = new System.Windows.Forms.Padding(30);
            this.AddRecordingButton.Size = new System.Drawing.Size(182, 96);
            this.AddRecordingButton.TabIndex = 1;
            this.AddRecordingButton.Text = "Добавить";
            this.AddRecordingButton.UseVisualStyleBackColor = true;
            this.AddRecordingButton.Click += new System.EventHandler(this.AddRecordingButton_Click);
            // 
            // RemoveRecordButton
            // 
            this.RemoveRecordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RemoveRecordButton.AutoSize = true;
            this.RemoveRecordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RemoveRecordButton.FlatAppearance.BorderSize = 0;
            this.RemoveRecordButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.RemoveRecordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.RemoveRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RemoveRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RemoveRecordButton.Location = new System.Drawing.Point(400, 0);
            this.RemoveRecordButton.Margin = new System.Windows.Forms.Padding(0);
            this.RemoveRecordButton.Name = "RemoveRecordButton";
            this.RemoveRecordButton.Padding = new System.Windows.Forms.Padding(30);
            this.RemoveRecordButton.Size = new System.Drawing.Size(256, 96);
            this.RemoveRecordButton.TabIndex = 2;
            this.RemoveRecordButton.Text = "Удалить";
            this.RemoveRecordButton.UseVisualStyleBackColor = true;
            // 
            // BottomPanel
            // 
            this.BottomPanel.Controls.Add(this.RecordingInformationButton);
            this.BottomPanel.Controls.Add(this.AddRecordingButton);
            this.BottomPanel.Controls.Add(this.RemoveRecordButton);
            this.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPanel.Location = new System.Drawing.Point(0, 300);
            this.BottomPanel.Name = "BottomPanel";
            this.BottomPanel.Size = new System.Drawing.Size(1300, 100);
            this.BottomPanel.TabIndex = 5;
            // 
            // RecordingsListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.RecordingsList);
            this.Controls.Add(this.BottomPanel);
            this.Name = "RecordingsListControl";
            this.Size = new System.Drawing.Size(1300, 400);
            ((System.ComponentModel.ISupportInitialize)(this.RecordingsList)).EndInit();
            this.BottomPanel.ResumeLayout(false);
            this.BottomPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView RecordingsList;
        private System.Windows.Forms.Button RecordingInformationButton;
        private System.Windows.Forms.Button AddRecordingButton;
        private System.Windows.Forms.Button RemoveRecordButton;
        private System.Windows.Forms.FlowLayoutPanel BottomPanel;
    }
}
