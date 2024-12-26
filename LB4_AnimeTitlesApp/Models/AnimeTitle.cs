using System;
using System.Collections.Generic;

namespace LB4_AnimeTitlesApp.Models;

public partial class AnimeTitle
{
    public int Id { get; set; }

    public short IdAnimeType { get; set; }

    public short IdGenre { get; set; }

    public int IdModerator { get; set; }

    public string OriginalName { get; set; } = null!;

    public string TitleName { get; set; } = null!;

    public short? YearOfRelese { get; set; }

    public string? Description { get; set; }

    public string? Poster { get; set; }

    public short? CountOfSeries { get; set; }

    public short? Duration { get; set; }

    public bool IsComplete { get; set; }

    public string Studio { get; set; } = null!;

    // навигационное свойство
    // одному тайтлу соответствует только один тип аниме
    public virtual AnimeType AnimeType { get; set; } = null!;

    public virtual Genre Genre { get; set; } = null!;

    public virtual User User { get; set; } = null!;
}
