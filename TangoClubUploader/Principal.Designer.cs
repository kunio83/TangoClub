﻿namespace TangoClubUploader
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
            this.lblCantidad = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.button1 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRun
            // 
            this.btnRun.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnRun.Location = new System.Drawing.Point(301, 98);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(285, 181);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "Sincronizar";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // lblTips
            // 
            this.lblTips.AutoSize = true;
            this.lblTips.Location = new System.Drawing.Point(4, 93);
            this.lblTips.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTips.Name = "lblTips";
            this.lblTips.Size = new System.Drawing.Size(0, 20);
            this.lblTips.TabIndex = 1;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblEstado.Location = new System.Drawing.Point(301, 73);
            this.lblEstado.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(285, 20);
            this.lblEstado.TabIndex = 2;
            this.lblEstado.Visible = false;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(594, 284);
            this.lblCantidad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(0, 20);
            this.lblCantidad.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.28902F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.71098F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 117F));
            this.tableLayoutPanel1.Controls.Add(this.btnRun, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblTips, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.progressBar1, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblCantidad, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblEstado, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.button1, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 4;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 32.78688F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 67.21311F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 37F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(708, 414);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.progressBar1.Location = new System.Drawing.Point(301, 289);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(285, 27);
            this.progressBar1.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(594, 5);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 35);
            this.button1.TabIndex = 6;
            this.button1.Text = "Verificador";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(708, 414);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Principal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.Principal_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Label lblTips;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Button button1;
    }
}