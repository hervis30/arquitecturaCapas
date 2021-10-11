using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEentidad
{
    public class CEcitas
    {
        private String codcita;
        private DateTime fecha;
        private DateTime hora;
        private String idpaciente;
        private String idmedico;
        private int valor;
        private String diagnostico;
        private String nomacompañante;
        private byte activo;

        public string Codcita { get => codcita; set => codcita = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public DateTime Hora { get => hora; set => hora = value; }
        public string Idpaciente { get => idpaciente; set => idpaciente = value; }
        public string Idmedico { get => idmedico; set => idmedico = value; }
        public int Valor { get => valor; set => valor = value; }
        public string Diagnostico { get => diagnostico; set => diagnostico = value; }
        public string Nomacompañante { get => nomacompañante; set => nomacompañante = value; }
        public byte Activo { get => activo; set => activo = value; }
    }
}
