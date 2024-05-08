﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaciaBack.Datos.Dominio
{
    public class FormaPago
    {
        private int id;
        private string forma;
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Forma
        {
            get { return forma; }
            set { forma = value; }
        }
        public FormaPago(int id, string forma)
        {
            this.id = id;
            Forma = forma;
        }
        public FormaPago()
        {

        }
    }
}
