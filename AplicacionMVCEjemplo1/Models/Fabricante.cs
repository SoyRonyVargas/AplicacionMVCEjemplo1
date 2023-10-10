using System;
using System.Collections.Generic;

namespace AplicacionMVCEjemplo1.Models;

public partial class Fabricante
{
    public int Pkfabricante { get; set; }

    public string? Nombre { get; set; }

    public virtual ICollection<Producto> Productos { get; set; } = new List<Producto>();
}
