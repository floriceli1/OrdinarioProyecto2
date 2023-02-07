using System;
using System.Collections.Generic;

namespace OrdinarioProyecto.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Usuario1 { get; set; }

    public string? Contrasena { get; set; }

    public string? Email { get; set; }
}
