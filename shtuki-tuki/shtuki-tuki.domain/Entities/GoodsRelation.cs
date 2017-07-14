namespace shtuki_tuki.domain.Entities
{
    public class GoodsRelation
    {
        public int Id { get; set; }

        public virtual Good Good { get; set; }

        public virtual Good GoodRelation { get; set; }

        public virtual Category Category { get; set; }

    }
}