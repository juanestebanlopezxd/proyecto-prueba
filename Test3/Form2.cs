using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Datos;
using Entidad;

namespace Test3
{
    public partial class FormSalones : Form
    {


        private Datos_Salones datos = new Datos_Salones();
        private Lista_Salones lista_salones;
        public FormSalones()
        {
            InitializeComponent();
        }

        private void butonsave_Click(object sender, EventArgs e)
        {
            string linea;
            linea = textBoxidsalon.Text + ";" + textBoxnumsal.Text + ";" + textBoxbloque.Text;

            if (datos.GuardarSalon(linea) == true)
            {
                MessageBox.Show("Se guardo el salon correctamente");
            }
            else
            {
                MessageBox.Show("error al guardar el docente");
            }
        }

        private void textBoxbloque_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnaggsal_Click(object sender, EventArgs e)
        {
            GPsavebloque.Visible = true;
            submenusalones.Visible = false;

        }
    }
}
