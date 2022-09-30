using System;
namespace Open_BootCamp
{
    public class Persona
    {
        private int _edad;
        private string _nombre;
        private string _telefono;

        public int Edad
        {
            get { return this._edad; }
            set { this._edad = value; }
        }

        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public string Telefono
        {
            get { return this._telefono; }
            set { this._telefono = value; }
        }
    }
}

