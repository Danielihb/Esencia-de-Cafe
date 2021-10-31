using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Esencia_de_cafe
{
    public class Datosdeinicio : CreateDatabaseIfNotExists<contexto>
    {
        protected override void Seed(contexto Contexto)
        {
            var usuarioadmin = new Usuario();
            usuarioadmin.Nombre = "admin1";
            usuarioadmin.Contrasena = "1234";

            Contexto.Usuarios.Add(usuarioadmin);

            var usuarioadmin1 = new Usuario();
            usuarioadmin1.Nombre = "admin2";
            usuarioadmin1.Contrasena = "123456";

            Contexto.Usuarios.Add(usuarioadmin1);


            var categoria1 = new Categoria();
            categoria1.Descripcion = "Bibidas";
            Contexto.Categorias.Add(categoria1);

            base.Seed(Contexto);
        }
    }
    }

