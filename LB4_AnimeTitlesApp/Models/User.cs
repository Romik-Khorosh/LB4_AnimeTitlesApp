using System;
using System.Collections.Generic;

namespace LB4_AnimeTitlesApp.Models;

public partial class User
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public DateOnly DateOfRegistration { get; set; }

    // навигационное свойство
    public virtual ICollection<AnimeTitle> AnimeTitles { get; set; } = new List<AnimeTitle>();
}
