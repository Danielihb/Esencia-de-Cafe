using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Esencia_de_cafe
{
    public class ProductosBL
    {
        contexto _contexto;
        public BindingList<Producto> ListaProductos { get; set; }
        public ProductosBL()
        {
            _contexto = new contexto();
            ListaProductos = new BindingList<Producto>();

        }

        public BindingList<Producto> ObtenerProductos()
        {
            _contexto.Productos.Load();
            ListaProductos = _contexto.Productos.Local.ToBindingList();
            return ListaProductos;
        }
        public Resultado guardarProducto(Producto producto) //guardar producto
        {
            var resultado = Validar(producto);
            if(resultado.Exitoso == false)
            {
                return resultado;
            }

            _contexto.SaveChanges();
            resultado.Exitoso = true;
            return resultado;
        }

        public void agregarProductos() //agregar un nuevo producto.
        {
            var nuevoProducto = new Producto();
            ListaProductos.Add(nuevoProducto);
        }

        public bool EliminarProducto(int id) //Eliminar Producto.
        {
            foreach (var producto in ListaProductos)
            {
                if (producto.id == id)
                {
                    ListaProductos.Remove(producto);
                    _contexto.SaveChanges();
                    return true;
                }
            }
            return false;
        }

        private Resultado Validar(Producto producto) //Validaciones
        {
            var resultado = new Resultado();
            resultado.Exitoso = true;

            if(string.IsNullOrEmpty(producto.Descripcion) == true)
            {
                resultado.Mensaje = "Ingrese una descripcion";
                resultado.Exitoso = false;
            }

            if (string.IsNullOrEmpty(producto.Categorias) == true)
            {
                resultado.Mensaje = "Ingrese una Categoria";
                resultado.Exitoso = false;
            }

            if (producto.Precio <= 0 )
            {
                resultado.Mensaje = "El precio debe ser mayor que Cero (0)";
                resultado.Exitoso = false;
            }
            return resultado;
        }
    }
    public class Producto
    {
        public int id { get; set; }
        public string Categorias { get; set; }
        public string Descripcion { get; set; }
        public double Precio { get; set; }
        public bool Activo { get; set; }
    }
    public class Resultado
    {
        public bool Exitoso { get; set; }
        public string Mensaje { get; set; }
    }
}

