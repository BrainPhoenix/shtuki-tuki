using shtuki_tuki.domain.Enumerables;

namespace shtuki_tuki.domain.Entities
{
    /// <summary>
    /// Класс описывающий объект ссылок на социальные сети
    /// </summary>
    public class SocialNetwork
    {
        public int Id { get; set; }

        public string LinkNetwork { get; set; }

        public TypeNetwork TypeNetwork { get; set; }
    }    
}
