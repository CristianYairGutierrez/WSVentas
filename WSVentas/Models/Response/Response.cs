namespace WSVentas.Models.Response
{
    public class Response<Content>
    {
        public bool Exito { get; set; }
        public string Mensaje { get; set; }
        public Content Contenido { get; set; }
    }
}
