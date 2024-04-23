using System;
using System.Collections.Generic;

namespace crudS.Models;

public partial class Usuario
{
    public int Id { get; set; }

    public string? Nombre { get; set; }

    public int? Edad { get; set; }

    public string? Telefono { get; set; }
}
