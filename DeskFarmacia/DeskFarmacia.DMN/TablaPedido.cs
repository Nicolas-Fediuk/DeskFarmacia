﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeskFarmacia.DMN
{
    public class TablaPedido
    {
        public int CODIGO_MED { get; set; }
        public string NOMBRE_MED { get; set; }
        public string DESCRIP_FAM { get; set; }
        public decimal PRECIO_LABXMED { get; set; }
        public int CANTIDAD { get; set; }   
    }
}
