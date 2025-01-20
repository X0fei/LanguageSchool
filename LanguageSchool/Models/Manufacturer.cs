using System;
using System.Collections.Generic;

namespace LanguageSchool.Models;

public partial class Manufacturer
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public DateOnly? StartDate { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
