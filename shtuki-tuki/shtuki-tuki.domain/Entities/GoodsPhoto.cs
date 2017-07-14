using shtuki_tuki.domain.Enumerables;

namespace shtuki_tuki.domain.Entities
{
    public class GoodsPhoto
    {
        public int Id { get; set; }

        public string Path { get; set; }

        public string FullPathToFile { get; set; }

        public string FileName { get; set; }

        public TypePhoto TypePhoto { get; set; }

        public KindPhoto KindPhoto { get; set; }

        public virtual Good Good { get; set; } 

        public virtual SpecialOffer SpecialOffer { get; set; }
    }
}