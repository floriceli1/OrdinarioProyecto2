namespace OrdinarioProyecto.Models
{
    //clase para la pagina de error
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}