using shtuki_tuki.domain.Enumerables;

namespace shtuki_tuki.domain.Entities
{
    /// <summary>
    /// Класс описывающий тип категории товара в меню
    /// </summary>
    public class Category
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public TypeCategory TypeCategory { get; set; }

    }
}