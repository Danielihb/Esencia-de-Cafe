using BL.Esencia_de_cafe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win.Esencia_de_Cafe
{
    public partial class RegistroProductos : Form
    {

        ProductosBL _productos;
        CategoriaBL _categorias;

        public RegistroProductos()
        {
            InitializeComponent();

            _productos = new ProductosBL();
            productoBindingSource.DataSource = _productos.ObtenerProductos();

            _categorias = new CategoriaBL();
            listaCategoriasBindingSource.DataSource = _categorias.ObtenerCategorias();
        }

        private void RegistroProductos_Load(object sender, EventArgs e)
        {

        }

        private void productoBindingNavigatorSaveItem_Click(object sender, EventArgs e) //Guardar producto
        {
            productoBindingSource.EndEdit();
            var producto = (Producto)productoBindingSource.Current;

            if (fotoPictureBox.Image != null)
            {
                producto.Foto = Program.imageToByteArray(fotoPictureBox.Image);
            }
            else
            {
                producto.Foto = null;
            }

            var Resultado = _productos.guardarProducto(producto);

            if (Resultado.Exitoso == true)
            {
                productoBindingSource.ResetBindings(false);
                DesabilitarHabilitarBonotes(true);
                MessageBox.Show("Producto Guardado ");
            }
            else
            {
                MessageBox.Show(Resultado.Mensaje);
            }
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e) //Agregar Producto
        {
            _productos.agregarProductos();
            productoBindingSource.MoveLast();

            DesabilitarHabilitarBonotes(false);

        }

        private void DesabilitarHabilitarBonotes(bool valor) //Desabilitar botones mientras un producto esta ingresando un producto.
        {
            bindingNavigatorMoveFirstItem.Enabled = valor;
            bindingNavigatorMoveLastItem.Enabled = valor;
            bindingNavigatorMovePreviousItem.Enabled = valor;
            bindingNavigatorMoveNextItem.Enabled = valor;
            bindingNavigatorPositionItem.Enabled = valor;

            bindingNavigatorAddNewItem.Enabled = valor;
            bindingNavigatorDeleteItem.Enabled = valor;
            toolStripButton1.Visible = !valor;
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e) //Eliminar Producto
        {
            if (idTextBox.Text != "")
            {
                var resultado = MessageBox.Show("¿Desea Eliminar este este Producto?", "Eliminar", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    var id = Convert.ToInt32(idTextBox.Text);
                    Eliminar(id);
                }

            }
        }

        private void Eliminar(int id)
        {

            var Resultado = _productos.EliminarProducto(id);

            if (Resultado == true)
            {
                productoBindingSource.ResetBindings(false);

            }
            else
            {
                MessageBox.Show("Ocurrio un Problema al eliminar un Producto");
            }
        }

        private void productoBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e) //Boton Cancelar
        {
            _productos.CancelarCambios();
            DesabilitarHabilitarBonotes(true);
            
        }

        private void productoBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            var producto = (Producto)productoBindingSource.Current;

            if (producto != null)
            {
                openFileDialog1.FileName = "";
                openFileDialog1.ShowDialog();

                var archivo = openFileDialog1.FileName;

                if (archivo != "")
                {
                    var fileInfo = new FileInfo(archivo);
                    var fileStream = fileInfo.OpenRead();



                    fotoPictureBox.Image = Image.FromStream(fileStream);
                }
            }
            else
            {
                MessageBox.Show("Crear un producto antes de ingresar una imagen");
            }
        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            fotoPictureBox.Image = null;
        }
    }
}
