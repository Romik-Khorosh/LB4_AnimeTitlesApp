using System;
using System.Collections.Generic;

namespace LB4_AnimeTitlesApp.Models;

// класс модели соответствует таблице в БД
// экземпляр класса - это строка таблицы БД
public partial class AnimeType
{
    // свойства класса соответствуют полям таблицы в БД
    public short Id { get; set; }

    public string AnimeOfType { get; set; } = null!;

    // навигационное свойство
    // помогает связывать таблицы в коде
    // одному типу аниме соответствует много тайтлов аниме,
    // т. е. создается коллекция экземпляров AnimeTitle
    public virtual ICollection<AnimeTitle> AnimeTitles { get; set; } = new List<AnimeTitle>();
}
