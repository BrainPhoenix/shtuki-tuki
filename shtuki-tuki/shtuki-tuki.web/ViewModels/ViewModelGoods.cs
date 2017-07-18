using shtuki_tuki.domain.Entities;
using System.Collections.Generic;

namespace shtuki_tuki.web.ViewModels
{
    public class ViewModelGoods
    {
        public List<Good> AllGoods { get; set; }

        public List<Good> GoodsPop { get; set; }
    }
}