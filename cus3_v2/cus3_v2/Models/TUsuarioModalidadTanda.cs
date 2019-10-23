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

        public int PkIumtCod { get; set; }
        public int FkIumtCodPart { get; set; }
        public int FkIumtCodTan { get; set; }
        public int? IumtPuntajeTotal { get; set; }
        public int? IumtPista { get; set; }

        public TUsuarioModalidad FkIumtCodPartNavigation { get; set; }
        public TTanda FkIumtCodTanNavigation { get; set; }
        public ICollection<TPuntaje> TPuntaje { get; set; }
    }
}
