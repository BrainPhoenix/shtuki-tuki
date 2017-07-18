using shtuki_tuki.domain.Entities;
using System.Collections.Generic;

namespace shtuki_tuki.web.ViewModels
{
    public class ViewModelGood
    {
        public Good Good { get; set; }

        public GoodsPhoto PhotoAvatar { get; set; }

        public List<GoodsPhoto> AdditionalPhoto { get; set; }

        public List<GoodsRelation> RelationGoods { get; set; }
    }
}