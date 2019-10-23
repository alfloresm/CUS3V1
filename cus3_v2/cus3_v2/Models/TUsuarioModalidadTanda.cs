using System;
using System.Collections.Generic;

namespace cus3_v2.Models
{
    public partial class TUsuarioModalidadTanda
    {
        public string PkIumtCod { get; set; }
        public int FkIumtCodPart { get; set; }
        public int FkIumtCodTan { get; set; }
        public int? IumtPuntajeTotal { get; set; }
        public int? IumtPista { get; set; }

        public TUsuarioModalidad FkIumtCodPart1 { get; set; }
        public TPuntaje FkIumtCodPartNavigation { get; set; }
        public TTanda FkIumtCodTanNavigation { get; set; }
    }
}
