using System;
using System.Collections.Generic;

namespace LanguageSchool.Models;

public partial class Gender
{
    public char Code { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Client> Clients { get; } = new List<Client>();
}
