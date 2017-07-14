namespace shtuki_tuki.domain.Entities
{
    public class Good
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string Size { get; set; }

        public string Discription { get; set; }

        public string Material { get; set; }

        public decimal Price { get; set; }

        public string HitId { get; set; }

        public string NewId { get; set; }

        public string PopId { get; set; }

        public string RelationId { get; set; }

        public bool Hit { get; set; }

        public bool New { get; set; }

        public bool Pop { get; set; }

        public virtual Category Category { get; set; }

    }
}