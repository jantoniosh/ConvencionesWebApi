namespace ConvencionesWebApi.Models
{
    public class EntradaRequest
    {
        public int Id { get; set; }
        public string? Titulo { get; set; }
        public string? Convencion { get; set; }
        public string? Categoria { get; set; }
        public string? Descripcion { get; set; }
        public string? Etiquetas { get; set; }
        public string? Thumbnail { get; set; }
        public string? URLEntrada { get; set; }
    }
}
