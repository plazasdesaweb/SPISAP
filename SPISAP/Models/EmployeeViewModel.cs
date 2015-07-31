﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;

namespace SPISAP.Models
{
    public class EmployeeViewModel
    {

        /* DPERSONALES : Datos Personales */
        public string FICHA { get; set; }
        public string CEDULA { get; set; }
        public string COD_SUCURSAL { get; set; }
        public string COD_GRUPO { get; set; }
        public string COD_AREA_PERSONAL { get; set; }
        public string CARGO { get; set; }
        public string TRATAMIENTO { get; set; }
        public string PRIMER_APELLIDO { get; set; }
        public string SEGUNDO_APELLIDO { get; set; }
        public string NOMBRE { get; set; }
        public Nullable<System.DateTime> FECHA_NACIMIENTO { get; set; }
        public string CIUDAD_NACIMIENTO { get; set; }
        public string COD_PAIS { get; set; }
        public string COD_ESTADO { get; set; }
        public string COD_NACIONALIDAD { get; set; }
        public string ESTADO_CIVIL { get; set; }
        public string SEXO { get; set; }
        public string RIF { get; set; }
        public string CALZADO { get; set; }
        public string CHEMISE { get; set; }
        public string PANTALON { get; set; }
        public string COD_USER_INS { get; set; }
        public System.DateTime FECHA_INS { get; set; }
        public string COD_USER_UPD { get; set; }
        public System.DateTime FECHA_UPD { get; set; }

        /* DDIRECCION : Dirección del Trabajador */
        //public string CEDULA { get; set; }
        public string CALLE { get; set; }
        public string EDIFICIO { get; set; }
        public string PISO { get; set; }
        public string NUMERO { get; set; }
        public string CIUDAD { get; set; }
        public string URBANIZACION { get; set; }
        public string COD_ESTADO_DDIRECCION { get; set; }
        public string COD_PAIS_DDIRECCION { get; set; }
        public string TELEFONOS { get; set; }
        public string COD_ESTADO_SSO { get; set; }
        public string COD_MUNICIPIO_SSO { get; set; }
        public string COD_PARROQUIA_SSO { get; set; }
        
        /* DDISCAPACIDAD */
        public List<DDISCAPACIDAD> Discapacidades { set; get; }

        public EmployeeViewModel()
        {

            /* Datos Personales */
            FICHA = "123456789012";
            CEDULA = "12919906";
            COD_SUCURSAL = "1001";
            COD_GRUPO = "1";
            COD_AREA_PERSONAL = "VK";
            CARGO = "CARGO";
            TRATAMIENTO = "Sra.";
            PRIMER_APELLIDO = "GONZALEZ";
            SEGUNDO_APELLIDO = "LOPEZ";
            NOMBRE = "FLOR MARINA";
            FECHA_NACIMIENTO = DateTime.Parse("1976-01-18", CultureInfo.InvariantCulture);
            CIUDAD_NACIMIENTO = "PORLAMAR";
            COD_PAIS = "VE";
            COD_ESTADO = "NE";
            COD_NACIONALIDAD = "PA";
            ESTADO_CIVIL = "Cas.";
            SEXO = "F";
            RIF = "J129199060";
            CALZADO = "34";
            CHEMISE = "S";
            PANTALON = "8";

            /* Dirección */
            CALLE = "CALLEJÓN MACHADO";
            EDIFICIO = "RESD.LOS GRANADILLOS";
            PISO = "14";
            NUMERO = "141B";
            URBANIZACION = "EL PARAÍSO";
            COD_ESTADO = "";
            COD_PAIS = "";
            TELEFONOS = "0124835448";
            COD_ESTADO_SSO = "NUE";
            COD_MUNICIPIO_SSO = "217";
            COD_PARROQUIA_SSO = "1191";

            /* Discapacidad : 'ZA', 'ZB', 'ZC' */
            //Discapacidades.Add(new DDISCAPACIDAD { CEDULA = "12919906", GRUPO_DISCAPACIDAD = "ZA", COD_USER_INS = "CROSARIO", FECHA_INS = System.DateTime.Now, COD_USER_UPD = "CROSARIO", FECHA_UPD = System.DateTime.Now });

            /* Usuario */
            COD_USER_INS = "CROSARIO";
            FECHA_INS = System.DateTime.Now;
            COD_USER_UPD = null;
            FECHA_UPD = System.DateTime.Now;

        }

    }
}