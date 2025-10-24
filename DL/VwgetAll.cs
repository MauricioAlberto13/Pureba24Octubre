using System;
using System.Collections.Generic;

namespace DL;

public partial class VwgetAll
{
    public string Nombre { get; set; } = null!;

    public string? Apellidos { get; set; }

    public int? Edad { get; set; }

    public DateOnly? Fecha { get; set; }

    public int IdUsuario { get; set; }
}
