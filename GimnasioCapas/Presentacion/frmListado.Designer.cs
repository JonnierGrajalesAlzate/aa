namespace Presentacion
{
    partial class frmListado
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
            this.txtCod = new System.Windows.Forms.TextBox();
            this.rbtOtro = new System.Windows.Forms.RadioButton();
            this.rbtServicios = new System.Windows.Forms.RadioButton();
            this.rbtPacientes = new System.Windows.Forms.RadioButton();
            this.dgvListado = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Location = new System.Drawing.Point(299, 16);
            this.txtCod.Margin = new System.Windows.Forms.Padding(2);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(153, 20);
            this.txtCod.TabIndex = 9;
            // 
            // rbtOtro
            // 
            this.rbtOtro.AutoSize = true;
            this.rbtOtro.Location = new System.Drawing.Point(161, 18);
            this.rbtOtro.Margin = new System.Windows.Forms.Padding(2);
            this.rbtOtro.Name = "rbtOtro";
            this.rbtOtro.Size = new System.Drawing.Size(134, 17);
            this.rbtOtro.TabIndex = 8;
            this.rbtOtro.TabStop = true;
            this.rbtOtro.Text = "Servicios por Paciente:";
            this.rbtOtro.UseVisualStyleBackColor = true;
            // 
            // rbtServicios
            // 
            this.rbtServicios.AutoSize = true;
            this.rbtServicios.Location = new System.Drawing.Point(92, 17);
            this.rbtServicios.Margin = new System.Windows.Forms.Padding(2);
            this.rbtServicios.Name = "rbtServicios";
            this.rbtServicios.Size = new System.Drawing.Size(65, 17);
            this.rbtServicios.TabIndex = 7;
            this.rbtServicios.TabStop = true;
            this.rbtServicios.Text = "Medicos";
            this.rbtServicios.UseVisualStyleBackColor = true;
            this.rbtServicios.CheckedChanged += new System.EventHandler(this.rbtServicios_CheckedChanged);
            // 
            // rbtPacientes
            // 
            this.rbtPacientes.AutoSize = true;
            this.rbtPacientes.Location = new System.Drawing.Point(18, 18);
            this.rbtPacientes.Margin = new System.Windows.Forms.Padding(2);
            this.rbtPacientes.Name = "rbtPacientes";
            this.rbtPacientes.Size = new System.Drawing.Size(72, 17);
            this.rbtPacientes.TabIndex = 6;
            this.rbtPacientes.TabStop = true;
            this.rbtPacientes.Text = "Pacientes";
            this.rbtPacientes.UseVisualStyleBackColor = true;
            this.rbtPacientes.CheckedChanged += new System.EventHandler(this.rbtClientes_CheckedChanged);
            // 
            // dgvListado
            // 
            this.dgvListado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListado.Location = new System.Drawing.Point(0, 39);
            this.dgvListado.Margin = new System.Windows.Forms.Padding(2);
            this.dgvListado.Name = "dgvListado";
            this.dgvListado.RowHeadersWidth = 51;
            this.dgvListado.RowTemplate.Height = 24;
            this.dgvListado.Size = new System.Drawing.Size(470, 363);
            this.dgvListado.TabIndex = 5;
            // 
            // frmListado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 405);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.rbtOtro);
            this.Controls.Add(this.rbtServicios);
            this.Controls.Add(this.rbtPacientes);
            this.Controls.Add(this.dgvListado);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmListado";
            this.Text = "Listado de Servicios";
            this.Load += new System.EventHandler(this.frmListado_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListado)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.RadioButton rbtOtro;
        private System.Windows.Forms.RadioButton rbtServicios;
        private System.Windows.Forms.RadioButton rbtPacientes;
        private System.Windows.Forms.DataGridView dgvListado;
    }
}