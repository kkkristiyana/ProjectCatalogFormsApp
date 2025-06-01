using System;
using System.Collections.Generic;

namespace ProjectCatalogFormsApp.Models;

public partial class Director
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string? LastName { get; set; }

    public int? Age { get; set; }

    public virtual ICollection<Movie> Movies { get; set; } = new List<Movie>();
}
