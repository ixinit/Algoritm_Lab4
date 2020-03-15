namespace Algoritm3._1
{
    partial class Algoritm31
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
            this.lblResult = new System.Windows.Forms.Label();
            this.btnClic = new System.Windows.Forms.Button();
            this.tbNum = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblResult
            // 
            this.lblResult.AutoEllipsis = true;
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(55, 189);
            this.lblResult.MaximumSize = new System.Drawing.Size(200, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(0, 13);
            this.lblResult.TabIndex = 0;
            // 
            // btnClic
            // 
            this.btnClic.Location = new System.Drawing.Point(82, 107);
            this.btnClic.Name = "btnClic";
            this.btnClic.Size = new System.Drawing.Size(75, 23);
            this.btnClic.TabIndex = 1;
            this.btnClic.Text = "Решить";
            this.btnClic.UseVisualStyleBackColor = true;
            this.btnClic.Click += new System.EventHandler(this.btnClic_Click);
            // 
            // tbNum
            // 
            this.tbNum.Location = new System.Drawing.Point(82, 60);
            this.tbNum.Name = "tbNum";
            this.tbNum.Size = new System.Drawing.Size(100, 20);
            this.tbNum.TabIndex = 2;
            // 
            // Algoritm31
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tbNum);
            this.Controls.Add(this.btnClic);
            this.Controls.Add(this.lblResult);
            this.Name = "Algoritm31";
            this.Text = "Algoritm31";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Button btnClic;
        private System.Windows.Forms.TextBox tbNum;
    }
}