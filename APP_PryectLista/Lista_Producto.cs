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
    public partial class Lista_Producto : Form
    {
        private List<Clases.Productos> productos = new List<Clases.Productos>();
        public Lista_Producto()
        {
            InitializeComponent();
        }

        private void agregar_Click(object sender, EventArgs e)
        {
            Clases.Productos producto = new Clases.Productos();
            producto.codigo = this.codigo.Text;
            producto.nombre = this.nombre.Text;
            producto.precio = Double.Parse (this.precio.Text);
            producto.fecha = DateTime.Parse(this.fecha.Text);
            producto.unidad =int.Parse (this.unidad.Text);

            productos.Add(producto);
            //MOSTRAR LOS ESTUDIANTES EN EL LISTVIEW
            ListViewItem horizontal = new ListViewItem(producto.codigo);
            listView1.Items.Add(horizontal);
            horizontal.SubItems.Add(producto.nombre);
            horizontal.SubItems.Add(producto.precio.ToString());
            horizontal.SubItems.Add(producto.fecha.ToString());
            horizontal.SubItems.Add(producto.unidad.ToString());
            MessageBox.Show("Datos Agregados con exito...");
        }

        private void nuevo_Click(object sender, EventArgs e)
        {
            this.codigo.Text = "";
            this.nombre.Text = "";
            this.precio.Text = "";
            this.fecha.Text = "";
            this.unidad.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.listView1.Clear(); 
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            
        }
    }
}
