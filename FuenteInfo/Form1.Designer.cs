namespace FuenteInfo
{
    partial class Form1
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
            this.btnSearchDir = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textDir = new System.Windows.Forms.TextBox();
            this.btnExec = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.mDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.mDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSearchDir
            // 
            this.btnSearchDir.Location = new System.Drawing.Point(449, 55);
            this.btnSearchDir.Name = "btnSearchDir";
            this.btnSearchDir.Size = new System.Drawing.Size(115, 37);
            this.btnSearchDir.TabIndex = 0;
            this.btnSearchDir.Text = "Select Directory";
            this.btnSearchDir.UseVisualStyleBackColor = true;
            this.btnSearchDir.Click += new System.EventHandler(this.btnSearchDir_Click_1);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textDir
            // 
            this.textDir.Location = new System.Drawing.Point(57, 64);
            this.textDir.Name = "textDir";
            this.textDir.Size = new System.Drawing.Size(329, 20);
            this.textDir.TabIndex = 1;
            // 
            // btnExec
            // 
            this.btnExec.Location = new System.Drawing.Point(57, 107);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(507, 48);
            this.btnExec.TabIndex = 2;
            this.btnExec.Text = "Execute first order ";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 3;
            // 
            // mDataGridView
            // 
            this.mDataGridView.AllowUserToAddRows = false;
            this.mDataGridView.AllowUserToDeleteRows = false;
            this.mDataGridView.AllowUserToOrderColumns = true;
            this.mDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.mDataGridView.Location = new System.Drawing.Point(57, 162);
            this.mDataGridView.Name = "mDataGridView";
            this.mDataGridView.ReadOnly = true;
            this.mDataGridView.Size = new System.Drawing.Size(507, 150);
            this.mDataGridView.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(599, 336);
            this.Controls.Add(this.mDataGridView);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.textDir);
            this.Controls.Add(this.btnSearchDir);
            this.Name = "Form1";
            this.Text = "Fuentes de Informacion";
            ((System.ComponentModel.ISupportInitialize)(this.mDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchDir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textDir;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView mDataGridView;

    }
}

