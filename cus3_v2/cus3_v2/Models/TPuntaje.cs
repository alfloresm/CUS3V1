using System;
using System.Collections.Generic;

namespace cus3_v2.Models
{
    public partial class TPuntaje
    {
        public TPuntaje()
        {
            TUsuarioModalidadTanda = new HashSet<TUsuarioModalidadTanda>();
        }

        public int PkIpCodP { get; set; }
        public int IpPuntaje { get; set; }
        public int IpNumeroJurado { get; set; }
        public int FkIumtCodpar { get; set; }
        public int FkIumtCodta { get; set; }

        public ICollection<TUsuarioModalidadTanda> TUsuarioModalidadTanda { get; set; }
    }
}
