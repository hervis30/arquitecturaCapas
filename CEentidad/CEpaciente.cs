using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEentidad
{
    public class CEpaciente
    {
        private String idpaciente;
        private String tipodocumento;
        private String nompaciente;
        private String dirpaciente;
        private int telpaciente;
        private int celpaciente;
        private byte activo;

        public string Idpaciente { get => idpaciente; set => idpaciente = value; }
        public string Tipodocumento { get => tipodocumento; set => tipodocumento = value; }
        public string Nompaciente { get => nompaciente; set => nompaciente = value; }
        public string Dirpaciente { get => dirpaciente; set => dirpaciente = value; }
        public int Telpaciente { get => telpaciente; set => telpaciente = value; }
        public int Celpaciente { get => celpaciente; set => celpaciente = value; }
        public byte Activo { get => activo; set => activo = value; }
    }
}
