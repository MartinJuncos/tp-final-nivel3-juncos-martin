﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dominio
{
    public class Articulo
    {
        [DisplayName("Código")]
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public string ImagenUrl { get; set; }
        public int Id { get; set; }
        public Marca Marca { get; set; }

        [DisplayName("Categoría")]
        public Categoria Categoria { get; set; }
        public decimal Precio { get; set; }

        public bool Activo { get; set; }
    }
}
