namespace TextProcessing
{
    partial class CSVDisplayForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.csvFileNameTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.selectCSVButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "FileName:";
            // 
            // csvFileNameTextBox
            // 
            this.csvFileNameTextBox.Location = new System.Drawing.Point(209, 41);
            this.csvFileNameTextBox.Name = "csvFileNameTextBox";
            this.csvFileNameTextBox.Size = new System.Drawing.Size(100, 23);
            this.csvFileNameTextBox.TabIndex = 1;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(35, 80);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowTemplate.Height = 25;
            this.dataGridView.Size = new System.Drawing.Size(721, 358);
            this.dataGridView.TabIndex = 2;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // selectCSVButton
            // 
            this.selectCSVButton.Location = new System.Drawing.Point(350, 41);
            this.selectCSVButton.Name = "selectCSVButton";
            this.selectCSVButton.Size = new System.Drawing.Size(75, 23);
            this.selectCSVButton.TabIndex = 3;
            this.selectCSVButton.Text = "Select File";
            this.selectCSVButton.UseVisualStyleBackColor = true;
            this.selectCSVButton.Click += new System.EventHandler(this.selectCSVButton_Click);
            // 
            // CSVDisplayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.selectCSVButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.csvFileNameTextBox);
            this.Controls.Add(this.label1);
            this.Name = "CSVDisplayForm";
            this.Text = "CSVDisplayForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private TextBox csvFileNameTextBox;
        private DataGridView dataGridView;
        private OpenFileDialog openFileDialog1;
        private Button selectCSVButton;
    }
}