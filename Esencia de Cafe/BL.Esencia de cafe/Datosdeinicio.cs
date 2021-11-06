using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Esencia_de_cafe
{
    public class DatosdeInicio : CreateDatabaseIfNotExists<contexto>
    {
        protected override void Seed(contexto _contexto)
        {

            var usuario1 = new Usuario();
            usuario1.Nombre = "admin1";
            usuario1.Contrasena = "1234";

            _contexto.Usuarios.Add(usuario1);

            var usuario2 = new Usuario();
            usuario2.Nombre = "admin2";
            usuario2.Contrasena = "123456";

            _contexto.Usuarios.Add(usuario2);

            var categoria1 = new Categoria();
            categoria1.Descripcion = "Bebidas Calientes";
            _contexto.Categorias.Add(categoria1);

            var categoria2 = new Categoria();
            categoria2.Descripcion = "Bebidas Heladas";
            _contexto.Categorias.Add(categoria2);

            var categoria3 = new Categoria();
            categoria3.Descripcion = "Acompañante";
            _contexto.Categorias.Add(categoria3);

            var cliente1 = new Cliente();
            cliente1.Nombre = "Daniel Hernandez";
            cliente1.Direccion = "Choloma";
            cliente1.DNI = "0502199402416";
            _contexto.Clientes.Add(cliente1);

            var cliente2 = new Cliente();
            cliente2.Nombre = "Omar Menjivar";
            cliente2.Direccion = "Choloma";
            cliente2.DNI = "0502199002611";
            _contexto.Clientes.Add(cliente2);

            base.Seed(_contexto);
        }
    }
}
