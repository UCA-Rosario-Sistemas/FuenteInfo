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
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(593, 301);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.textDir);
            this.Controls.Add(this.btnSearchDir);
            this.Name = "Form1";
            this.Text = "Fuentes de Informacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearchDir;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textDir;
        private System.Windows.Forms.Button btnExec;

    }
}

