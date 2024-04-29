using System;
using System.Collections.Generic;

namespace webapi.BazarDaElioDb;

public partial class Categories
{
    public int Id { get; set; }
    public string Categoria { get; set; } = null!;
    public string? DescrizioneCategoria { get; set; } = null!;
    public string? ImmagineCategoria { get; set; } = null!;
    public DateTime CreatedDateTime { get; set; }
}
