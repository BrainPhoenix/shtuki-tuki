using shtuki_tuki.domain.Enumerables;

namespace shtuki_tuki.domain.Entities
{
    public class Currency
    {
        public int Id { get; set; }

        public decimal CourseCurrency { get; set; }

        public  TypeCurrency TypeCurrency { get; set; }
    }
}