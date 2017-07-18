using shtuki_tuki.domain.Entities;
using shtuki_tuki.domain.Entities.MainPageStrings;
using System.Data.Entity;

namespace shtuki_tuki.domain.DbProject
{
    class ShtukiDbContext : DbContext
    {
        public ShtukiDbContext() : base("u0295663_shtukituki")
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<ShtukiDbContext>());
        }

        public DbSet<PageString> PageStrings { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<Contact> Contacts { get; set; }

        public DbSet<Currency> Currencies { get; set; }

        public DbSet<Good> Goods { get; set; }

        public DbSet<GoodsPhoto> GoodsPhotos { get; set; }

        public DbSet<GoodsRelation> GoodRelations { get; set; }

        public DbSet<Review> Reviews { get; set; }

        public DbSet<SocialNetwork> SocialNetworks { get; set; }

        public DbSet<SpecialOffer> SpecialOffers { get; set; }        

        public DbSet<Video> Videos { get; set; }        
    }
}
