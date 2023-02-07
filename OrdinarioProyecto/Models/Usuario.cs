using System;
using System.Collections.Generic;

namespace OrdinarioProyecto.Models;
//creacion de la clase usuario
public partial class Usuario
{
    //Definicion de las variables que ocupa nuetra tabla usuarios
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public string? Usuario1 { get; set; }

    public string? Contrasena { get; set; }

    public string? Email { get; set; }
}
