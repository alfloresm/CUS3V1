using System;
using System.Collections.Generic;

namespace cus3_v2.Models
{
    public partial class TPuntaje
    {
        public int PkIpCodP { get; set; }
        public int IpPuntaje { get; set; }
        public int IpNumeroJurado { get; set; }
        public string FkIumtCod { get; set; }

        public TUsuarioModalidadTanda FkIumtCodNavigation { get; set; }
    }
}
