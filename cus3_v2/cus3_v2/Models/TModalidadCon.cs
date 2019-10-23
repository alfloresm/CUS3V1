﻿using System;
using System.Collections.Generic;

namespace cus3_v2.Models
{
    public partial class TModalidadCon
    {
        public TModalidadCon()
        {
            TUsuarioModalidad = new HashSet<TUsuarioModalidad>();
        }

        public int PkImIdModalidad { get; set; }
        public string VmNombreMod { get; set; }

        public ICollection<TUsuarioModalidad> TUsuarioModalidad { get; set; }
    }
}
