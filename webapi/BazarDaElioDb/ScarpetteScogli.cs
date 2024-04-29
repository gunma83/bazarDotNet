using System;
using System.Collections.Generic;

namespace webapi.BazarDaElioDb;

public partial class ScarpetteScogli
{
    public int Id { get; set; }

    public string Categoria { get; set; } = null!;

    public string Modello { get; set; } = null!;

    public string Colore { get; set; } = null!;

    public int Numero { get; set; }

    public int Quantita { get; set; }

    public DateTime InsertDateTime { get; set; }
}
