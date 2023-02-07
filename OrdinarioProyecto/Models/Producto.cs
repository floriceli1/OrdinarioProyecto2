using System;
using System.Collections.Generic;

namespace OrdinarioProyecto.Models;

public partial class Producto
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public int? Cantidad { get; set; }

    public double? Precio { get; set; }
}
