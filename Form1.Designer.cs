namespace WindowsProcesses
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewProcesses;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dataGridViewProcesses = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProcesses).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProcesses
            // 
            dataGridViewProcesses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProcesses.Location = new Point(10, 11);
            dataGridViewProcesses.Name = "dataGridViewProcesses";
            dataGridViewProcesses.Size = new Size(679, 399);
            dataGridViewProcesses.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 422);
            Controls.Add(dataGridViewProcesses);
            Name = "Form1";
            Text = "Top Memory Consuming Processes";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewProcesses).EndInit();
            ResumeLayout(false);
        }
    }
}
