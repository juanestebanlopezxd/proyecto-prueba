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
    public partial class materias : Form
    {



        private Datos_Materias datos = new Datos_Materias();
        private Lista_Materias lista_materias;
        public materias()
        {
            InitializeComponent();
        }

        private void butonsavemate_Click(object sender, EventArgs e)
        {
            string linea;
            linea = textBoxidmate.Text + ";" + textBoxnamemate.Text + ";" + textBoxnumcredi.Text;

            if (datos.GuardarMater(linea) == true)
            {
                MessageBox.Show("Se guardo la materia correctamente");
            }
            else
            {
                MessageBox.Show("error al guardar la materia");
            }
        }

        private void btnaggmat_Click(object sender, EventArgs e)
        {
            GPsavemateria.Visible = true;
            submenumaterias.Visible = false;
        }
    }
}
