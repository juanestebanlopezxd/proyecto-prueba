using Datos;
using Entidad;

namespace Test3

{
    public partial class Form1 : Form
    {


        private Datos_Docentes datos = new Datos_Docentes();
        private Lista_Docentes lista_docentes;
        public Form1()
        {
            InitializeComponent();
        }



        private void Barratitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }







        private void cargar_docentes()
        {
            dataGridDocentes.Rows.Clear();

            lista_docentes = datos.leer_docentes();

            if (datos.leer_docentes() == null)
            {

                return;
            }
            foreach (Docente docente in lista_docentes.coleccion_docentes())
            {
                dataGridDocentes.Rows.Add(docente.Id, docente.Nombre, docente.Telefono);


            }

        }
        private void cargar_docentesmodi()
        {
            dgvModidocentes.Rows.Clear();

            lista_docentes = datos.leer_docentes();

            if (datos.leer_docentes() == null)
            {

                return;
            }
            foreach (Docente docente in lista_docentes.coleccion_docentes())
            {
                dgvModidocentes.Rows.Add(docente.Id, docente.Nombre, docente.Telefono);


            }

        }
        private void guardar_docente()
        {
            string linea;
            linea = textBoxIddoc.Text + ";" + textBoxnomdoc.Text + ";" + textBoxTeldoc.Text;

            if (datos.GuardarDocente(linea) == true)
            {
                MessageBox.Show("Se guardo el docente correctamente");
            }
            else
            {
                MessageBox.Show("error al guardar el docente");
            }


        }



        private void bttondocen_Click(object sender, EventArgs e)
        {

        }

        private void btnaggdocen_Click(object sender, EventArgs e)
        {


        }

        private void butguardar_Click(object sender, EventArgs e)
        {

        }

        private void btnsubmenudocentes_Click(object sender, EventArgs e)
        {
            panelsubmenudoc.Visible = true;
        }

        private void Btnaggdocente_Click(object sender, EventArgs e)
        {
            GPsavedocente.Visible = true;
            panelsubmenudoc.Visible = false;
        }

        private void butonsave_Click(object sender, EventArgs e)
        {
            guardar_docente();
        }

        private void BtnVerdocentes_Click(object sender, EventArgs e)
        {
            GPverdocentes.Visible = true;
            panelsubmenudoc.Visible = false;
        }

        private void btnberdocentes_Click(object sender, EventArgs e)
        {
            cargar_docentes();
        }

        private void dataGridDocentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila_seleccionada = dataGridDocentes.CurrentRow.Index;
            textBoxIddoc.Text = dataGridDocentes.Rows[fila_seleccionada].Cells[0].Value.ToString();
            textBoxnomdoc.Text = dataGridDocentes.Rows[fila_seleccionada].Cells[1].Value.ToString();
            textBoxTeldoc.Text = dataGridDocentes.Rows[fila_seleccionada].Cells[2].Value.ToString();
        }


        private void actualizar_docente()
        {
            lista_docentes = datos.leer_docentes();
            Docente docente = new Docente();
            docente.Id = textboxmodidocente.Text;
            docente.Nombre = textboxmodinombredoce.Text;
            docente.Telefono = textboxmoditeldoce.Text;
            lista_docentes.actualizar_docente(docente);
            regrabar_archiv();
        }

        private void btnmodificardoce_Click(object sender, EventArgs e)
        {
            actualizar_docente();

        }

        private void btndeletedocente_Click(object sender, EventArgs e)
        { string id = textboxeletedoc.Text;
            eliminar_docente(id);
        }

        private void dgvModidocentes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila_seleccionada = dgvModidocentes.CurrentRow.Index;
            textboxmodidocente.Text = dgvModidocentes.Rows[fila_seleccionada].Cells[0].Value.ToString();
            textboxmodinombredoce.Text = dgvModidocentes.Rows[fila_seleccionada].Cells[1].Value.ToString();
            textboxmoditeldoce.Text = dgvModidocentes.Rows[fila_seleccionada].Cells[2].Value.ToString();
        }

        private void btnmodidocentes_Click(object sender, EventArgs e)
        {
            GPModidocentes.Visible = true;
        }

        private void cargarmodidocentes_Click(object sender, EventArgs e)
        {
            cargar_docentesmodi();
        }
        private void modificar_docente() {

            lista_docentes = datos.leer_docentes();
        }

        private void eliminar_docente(string id)
        {
            lista_docentes = datos.leer_docentes();
            lista_docentes.eliminar_docente(id);
            regrabar_archiv();

        }

        private void regrabar_archiv()
        {
            datos.eliminar_archivo_doc();
            string linea;

            foreach (Docente doc in lista_docentes.coleccion_docentes())
            {
                linea = doc.Id + ";" + doc.Nombre + ";" + doc.Telefono;
                datos.GuardarDocente(linea);
            }
        }

        private void btnsalones_Click(object sender, EventArgs e)
        {
            Form salones = new FormSalones();
            salones.Show();
        }

        private void btnaggsal_Click(object sender, EventArgs e)
        {
            
            
            //salones.GPsavebloque.Visible = true;
        }

        private void btnmaterias_Click(object sender, EventArgs e)
        {
            Form materias = new materias();
            materias.Show();
        }
    }
}
