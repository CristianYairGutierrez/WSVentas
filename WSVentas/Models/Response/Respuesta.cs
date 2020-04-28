using System;

namespace WSVentas.Models.Response
{
    public class Respuesta<TResult> : Exception
    {
        public bool Exito { get; set; }
        public string Mensaje { get; set; }
        public TResult Contenido { get; set; }

        public Respuesta(TResult contenido, bool exito = true)
        {
            Exito = exito;
            Contenido = contenido;
        }

        public Respuesta(string mensaje, bool exito = false)
        {
            this.Exito = exito;
            Mensaje = mensaje;
        }

        public Respuesta(string message, Exception innerException) : base(message, innerException)
        {            
        }
        
        public bool EsExito
        {
            get { return this.Exito = true; }
        }

        public bool EsError
        {
            get { return !EsExito; }
        }
    }

    public class Respuesta : Exception
    {
        public bool Exito { get; set; }
        public string Mensaje { get; set; }

        public Respuesta() { this.Exito = true; }

        public Respuesta(string mensaje)
        {
            this.Exito = false;
            this.Mensaje = mensaje;
        }

        public Respuesta(string message, Exception innerException) : base(message, innerException)
        {
        }

        public bool EsExito
        {
            get { return this.Exito = true; }
        }

        public bool EsError
        {
            get { return !EsExito; }
        }
    }
}
