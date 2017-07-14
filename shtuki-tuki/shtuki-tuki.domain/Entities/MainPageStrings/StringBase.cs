namespace shtuki_tuki.domain.Entities.MainPageStrings
{
    /// <summary>
    /// Базовый класс для описания объекта строки на главной странице
    /// </summary>
    public class StringBase
    {
        /// <summary>
        /// Первая часть объекта строки
        /// </summary>
        public string FirstPhrase { get; set; }

        /// <summary>
        /// Вторая часть объекта строки (выделенная)
        /// </summary>
        public string SecondPhrase { get; set; }

        /// <summary>
        /// Третья часть объекта строки
        /// </summary>
        public string ThirdPhrase { get; set; }
    }
}
