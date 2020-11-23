﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Cadeteria.Entidades
{
    public class Persona
    {
        // atributos
        private int id;
        private string nombre;
        private string direccion;
        private string telefono;

        // propiedades
        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }

        // constructor
        public Persona() { }

        public Persona(string nombre, string direccion, string telefono)
        {
            Nombre = nombre;
            Direccion = direccion;
            Telefono = telefono;
        }

        // métodos
        public virtual int CantidadDePedidos() { return 0; }
    }
}
