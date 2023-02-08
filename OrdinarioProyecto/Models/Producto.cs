//Nombre:Producto.cs
//Fecha de creacion: 08/02/22
//Creador:Floriceli Gonzalez Ruiz
//Descripcion:modelo deproducto


using System;
using System.Collections.Generic;

namespace OrdinarioProyecto.Models;
//creacion de la clase producto
public partial class Producto
{
    //Definicion de las variables que ocupa nuetra tabla producto
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Descripcion { get; set; }

    public int? Cantidad { get; set; }

    public double? Precio { get; set; }
}
