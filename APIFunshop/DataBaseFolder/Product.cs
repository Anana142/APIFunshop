using System;
using System.Collections.Generic;

namespace APIFunshop.DataBaseFolder;

public partial class Product
{
    public int Id { get; set; }

    public string? Title { get; set; }

    public string? Price { get; set; }

    public string? Description { get; set; }

    public int? IdCategory { get; set; }

    public virtual Category? IdCategoryNavigation { get; set; }
}
