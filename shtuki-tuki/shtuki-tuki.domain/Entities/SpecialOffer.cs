namespace shtuki_tuki.domain.Entities
{
    /// <summary>
    /// Класс описывающий тип Специальные предложения
    /// </summary>
    public class SpecialOffer
    {
        public int Id { get; set; }

        public string FirstPartPhrase { get; set; }

        public string SecondPartPhrase { get; set; }

        public string ThirdPartPhrase { get; set; }

        /// <summary>
        /// Цена товара в предложении (задается в долларах)
        /// </summary>
        public decimal Price { get; set; }
    }
}