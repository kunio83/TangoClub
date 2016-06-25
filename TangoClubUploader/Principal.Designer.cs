namespace TangoClubUploader
{
    partial class Principal
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
            this.btnRun = new System.Windows.Forms.Button();
            this.lblTips = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(164, 131);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(154, 91);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Sincronizar";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblTips
            // 
            this.lblTips.AutoSize = true;
            this.lblTips.Location = new System.Drawing.Point(12, 189);
            this.lblTips.Name = "lblTips";
            this.lblTips.Size = new System.Drawing.Size(37, 13);
            this.lblTips.TabIndex = 1;
            this.lblTips.Text = "lblTips";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(137, 253);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(50, 13);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Text = "lblEstado";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(74, 35);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(335, 23);
            this.progressBar1.TabIndex = 3;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(182, 19);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(35, 13);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "label1";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 335);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblTips);
            this.Controls.Add(this.btnRun);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblTips;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblCantidad;
    }
}