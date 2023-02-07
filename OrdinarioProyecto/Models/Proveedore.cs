using System;
using System.Collections.Generic;

namespace OrdinarioProyecto.Models;

public partial class Proveedore
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Email { get; set; }

    public string? Direccion { get; set; }

    public int? Telefono { get; set; }
}
