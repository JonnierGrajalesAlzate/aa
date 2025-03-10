using System;
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
    public partial class frmServicio : Form
    {
        public frmServicio()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                objCN.insertarMedico(
                    int.Parse(txtIdentificacion.Text), cboEspecialidad.Text,
                    cboEspecialidad.Text
                );
                MessageBox.Show("Se ha registrado el medico", "SALUD MEDICOS UNIDOS S.A.S", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message);
            }
        }

        CN_Medico objCN = new CN_Medico();


        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                objCN.actualizar(
                    int.Parse(txtIdentificacion.Text), cboEspecialidad.Text,
                    cboEspecialidad.Text
                );
                MessageBox.Show("Se ha actualizado el medico", "SALUD MEDICOS UNIDOS S.A.S", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                objCN.buscarMedico(
                    int.Parse(txtIdentificacion.Text)
                );
                if (objCN.encontro)
                {
                    txtIdentificacion.Text = objCN.identificacion.ToString();
                    txtNombreCompleto.Text = objCN.nombre.ToString();
                    cboEspecialidad.Text = objCN.especialidad.ToString();
                    txtConsultorio.Text = objCN.consultorio.ToString();
                }
                else
                {
                    MessageBox.Show("El servicio no esta registrado", "SALUD MEDICOS UNIDOS S.A.S", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "SALUD MEDICOS UNIDOS S.A.S", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                objCN.eliminarMedico(
                    int.Parse(txtIdentificacion.Text)
                );
            }
            catch (Exception ex)
            {
                MessageBox.Show("ERROR: " + ex.Message, "SALUD MEDICOS UNIDOS S.A.S", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
