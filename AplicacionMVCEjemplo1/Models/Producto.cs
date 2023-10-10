using System;
using System.Collections.Generic;

namespace AplicacionMVCEjemplo1.Models;

public partial class Producto
{
    public int Pkproducto { get; set; }

    public string? Nombre { get; set; }

    public double? Precio { get; set; }

    public int? Fkfabricante { get; set; }

    public virtual Fabricante? FkfabricanteNavigation { get; set; }
}
