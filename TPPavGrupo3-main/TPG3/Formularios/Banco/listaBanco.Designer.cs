﻿using System.Windows.Forms;

namespace TPG3.Formularios.Banco
{
    partial class listaBanco
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
            this.grdBuscadorBanco = new System.Windows.Forms.DataGridView();
            this.txtBuscadorGenero = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblListadoGenero = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdBuscadorBanco)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grdBuscadorBanco
            // 
            this.grdBuscadorBanco.AllowUserToAddRows = false;
            this.grdBuscadorBanco.AllowUserToDeleteRows = false;
            this.grdBuscadorBanco.BackgroundColor = System.Drawing.Color.White;
            this.grdBuscadorBanco.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdBuscadorBanco.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre});
            this.grdBuscadorBanco.GridColor = System.Drawing.SystemColors.Control;
            this.grdBuscadorBanco.Location = new System.Drawing.Point(158, 187);
            this.grdBuscadorBanco.Name = "grdBuscadorBanco";
            this.grdBuscadorBanco.ReadOnly = true;
            this.grdBuscadorBanco.RowTemplate.Height = 25;
            this.grdBuscadorBanco.Size = new System.Drawing.Size(440, 211);
            this.grdBuscadorBanco.TabIndex = 5;
            // 
            // txtBuscadorGenero
            // 
            this.txtBuscadorGenero.Location = new System.Drawing.Point(158, 142);
            this.txtBuscadorGenero.Name = "txtBuscadorGenero";
            this.txtBuscadorGenero.Size = new System.Drawing.Size(192, 23);
            this.txtBuscadorGenero.TabIndex = 4;
            this.txtBuscadorGenero.TextChanged += new System.EventHandler(this.txtBuscadorGenero_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lblListadoGenero);
            this.panel1.Location = new System.Drawing.Point(99, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(603, 378);
            this.panel1.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(59, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 18;
            this.label1.Text = "Nombre:";
            // 
            // lblListadoGenero
            // 
            this.lblListadoGenero.AutoSize = true;
            this.lblListadoGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(28)))));
            this.lblListadoGenero.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblListadoGenero.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblListadoGenero.Location = new System.Drawing.Point(49, 23);
            this.lblListadoGenero.Name = "lblListadoGenero";
            this.lblListadoGenero.Size = new System.Drawing.Size(182, 28);
            this.lblListadoGenero.TabIndex = 0;
            this.lblListadoGenero.Text = "Listado de Bancos";
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.DataPropertyName = "nombreBanco";
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // listaBanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdBuscadorBanco);
            this.Controls.Add(this.txtBuscadorGenero);
            this.Controls.Add(this.panel1);
            this.Name = "listaBanco";
            this.Text = "listaBanco";
            this.Load += new System.EventHandler(this.listaBanco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdBuscadorBanco)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView grdBuscadorBanco;
        private DataGridViewTextBoxColumn nombre;
        private TextBox txtBuscadorGenero;
        private Panel panel1;
        private Label label1;
        private Label lblListadoGenero;
    }
}