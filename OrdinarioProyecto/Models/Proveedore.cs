using System;
using System.Collections.Generic;

namespace OrdinarioProyecto.Models;
//creacion de la clase proveedor
public partial class Proveedore
{    
    //Definicion de las variables que ocupa nuetra tabla proveedores
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Email { get; set; }

    public string? Direccion { get; set; }

    public int? Telefono { get; set; }
}
