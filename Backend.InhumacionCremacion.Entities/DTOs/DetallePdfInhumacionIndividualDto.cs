﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Backend.InhumacionCremacion.Entities.DTOs
{
    public class DetallePdfInhumacionIndividualDto
    {
        public string FechaActual { get; set; }
        public string Hora { get; set; }
        public string NumeroLicencia { get; set; }
        public string CertificadoDefuncion { get; set; }
        public string Funeraria { get; set; }
        public string FullNameTramitador { get; set; }
        public string FullNameFallecido { get; set; }
        public string Nacionalidad { get; set; }
        public DateTime FechaFallecido { get; set; }
        public string Genero { get; set; }
        public string TipoIdentificacion { get; set; }
        public string NumeroIdentificacion { get; set; }
        public string Muerte { get; set; }
        public int Edad { get; set; }
        public string FullNameMedico { get; set; }
        public string Cementerio { get; set; }
        public string FirmaAprobador { get; set; }
        public string FirmaValidador { get; set; }
        //public string Name { get; set; }
    }
}
