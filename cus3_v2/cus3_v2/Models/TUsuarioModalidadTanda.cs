using System;
using System.Collections.Generic;

namespace cus3_v2.Models
{
    public partial class TUsuarioModalidadTanda
    {
        public TUsuarioModalidadTanda()
        {
            TPuntaje = new HashSet<TPuntaje>();
        }

        public string PkVumtCod { get; set; }
        public int FkVumtCodPart { get; set; }
        public int FkVumtCodTan { get; set; }
        public int? IumtPuntajeTotal { get; set; }
        public int? IumtPista { get; set; }

        public TUsuarioModalidad FkVumtCodPartNavigation { get; set; }
        public TTanda FkVumtCodTanNavigation { get; set; }
        public ICollection<TPuntaje> TPuntaje { get; set; }
    }
}
