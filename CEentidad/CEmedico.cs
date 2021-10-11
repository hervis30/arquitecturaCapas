﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEentidad
{
    public class CEmedico
    {
        private String idmedico;
        private String nomedico;
        private String especialidad;
        private String telmedico;
        private byte activo;

        public string Idmedico { get => idmedico; set => idmedico = value; }
        public string Nomedico { get => nomedico; set => nomedico = value; }
        public string Especialidad { get => especialidad; set => especialidad = value; }
        public string Telmedico { get => telmedico; set => telmedico = value; }
        public byte Activo { get => activo; set => activo = value; }
    }
}
