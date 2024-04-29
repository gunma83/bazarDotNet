using System;
using System.Collections.Generic;

namespace webapi.BazarDaElioDb;

public partial class Ombrelloni
{
    public int Id { get; set; }

    public string Categoria { get; set; } = null!;

    public string Modello { get; set; } = null!;

    public string Quantita { get; set; } = null!;

    public string Materiale { get; set; } = null!;

    public DateTime InsertDateTime { get; set; }
}
