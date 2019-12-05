using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace APP_PryectLista
{
    public partial class Form1 : Form
    {
        private List<Clases.Estudiantes> lista = new List<Clases.Estudiantes>();
        public Form1()
        {
            InitializeComponent();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            Clases.Estudiantes estudiantes = new Clases.Estudiantes();
            estudiantes.nombrecompleto = this.nombre.Text;
            estudiantes.genero = this.edad.Text;
            estudiantes.estado_civil = this.estado.Text;
            estudiantes.edad = Convert.ToInt32(this.edad.Text);
            lista.Add(estudiantes);
            //MOSTRAR LOS ESTUDIANTES EN EL LISTVIEW
            ListViewItem item = new ListViewItem(estudiantes.nombrecompleto);
            listViewestudiantes.Items.Add(item);
            item.SubItems.Add(estudiantes.genero);
            item.SubItems.Add(estudiantes.estado_civil);
            item.SubItems.Add(estudiantes.edad.ToString());
        }
    }
}
