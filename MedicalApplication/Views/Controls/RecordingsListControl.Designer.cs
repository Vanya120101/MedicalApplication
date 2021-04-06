
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
            this.RecordInformationButton = new System.Windows.Forms.Button();
            this.AddRecordButton = new System.Windows.Forms.Button();
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
            // RecordInformationButton
            // 
            this.RecordInformationButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RecordInformationButton.AutoSize = true;
            this.RecordInformationButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.RecordInformationButton.FlatAppearance.BorderSize = 0;
            this.RecordInformationButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.RecordInformationButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.RecordInformationButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RecordInformationButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.RecordInformationButton.Location = new System.Drawing.Point(0, 0);
            this.RecordInformationButton.Margin = new System.Windows.Forms.Padding(0);
            this.RecordInformationButton.Name = "RecordInformationButton";
            this.RecordInformationButton.Padding = new System.Windows.Forms.Padding(30);
            this.RecordInformationButton.Size = new System.Drawing.Size(218, 96);
            this.RecordInformationButton.TabIndex = 0;
            this.RecordInformationButton.Text = "Информация";
            this.RecordInformationButton.UseVisualStyleBackColor = true;
            // 
            // AddRecordButton
            // 
            this.AddRecordButton.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddRecordButton.AutoSize = true;
            this.AddRecordButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AddRecordButton.FlatAppearance.BorderSize = 0;
            this.AddRecordButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.AddRecordButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.White;
            this.AddRecordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddRecordButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AddRecordButton.Location = new System.Drawing.Point(218, 0);
            this.AddRecordButton.Margin = new System.Windows.Forms.Padding(0);
            this.AddRecordButton.Name = "AddRecordButton";
            this.AddRecordButton.Padding = new System.Windows.Forms.Padding(30);
            this.AddRecordButton.Size = new System.Drawing.Size(182, 96);
            this.AddRecordButton.TabIndex = 1;
            this.AddRecordButton.Text = "Добавить";
            this.AddRecordButton.UseVisualStyleBackColor = true;
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
            this.BottomPanel.Controls.Add(this.RecordInformationButton);
            this.BottomPanel.Controls.Add(this.AddRecordButton);
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
        private System.Windows.Forms.Button RecordInformationButton;
        private System.Windows.Forms.Button AddRecordButton;
        private System.Windows.Forms.Button RemoveRecordButton;
        private System.Windows.Forms.FlowLayoutPanel BottomPanel;
    }
}
