﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Negocio;

namespace Presentacion
{
    public partial class frmCliente : Form
    {
        public frmCliente()
        {
            InitializeComponent();
        }

        CN_Paciente objCN=new CN_Paciente();

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                objCN.insertar(
                    int.Parse(txtCodigo.Text),txtNombre.Text,
                    txtApellido.Text,int.Parse(txtEdad.Text)
                );
                MessageBox.Show("Se ha registrado el cliente", "Gimnasio SportGym", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }catch(Exception ex) {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                objCN.actualizar(
                    int.Parse(txtCodigo.Text), txtNombre.Text,
                    txtApellido.Text, int.Parse(txtEdad.Text)
                );
                MessageBox.Show("Se ha actualizado el cliente","Gimnasio SportGym",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                objCN.buscar(
                    int.Parse(txtCodigo.Text)
                );
                if (objCN.encontro)
                {
                    txtCodigo.Text = objCN.codigo.ToString();
                    txtNombre.Text = objCN.nombre.ToString();
                    txtApellido.Text = objCN.apellido.ToString();
                    txtEdad.Text = objCN.edad.ToString();
                }
                else
                {
                    MessageBox.Show("El cliente no esta registrado", "Gimnasio SportGym", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtCodigo.Clear();
                    txtNombre.Clear();
                    txtApellido.Clear();
                    txtEdad.Clear();
                    txtCodigo.Focus();
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Gimnasio SportGym", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                objCN.eliminar(
                    int.Parse(txtCodigo.Text)
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "Gimnasio SportGym", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
