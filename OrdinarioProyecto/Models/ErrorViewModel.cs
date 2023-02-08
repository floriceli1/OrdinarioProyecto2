//Nombre:ErrorViewModel.cs
//Fecha de creacion: 08/02/22
//Creador:Floriceli Gonzalez Ruiz
//Descripcion:pagina de error


namespace OrdinarioProyecto.Models
{
    //clase para la pagina de error
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}