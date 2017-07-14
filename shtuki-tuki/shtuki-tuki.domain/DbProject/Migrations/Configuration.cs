using shtuki_tuki.domain.Entities;
using shtuki_tuki.domain.Enumerables;
using System;
using System.Data.Entity.Migrations;

namespace shtuki_tuki.domain.DbProject.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<ShtukiDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(ShtukiDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            context.Currencies.AddOrUpdate(currency => currency.TypeCurrency,
                new Currency { TypeCurrency = TypeCurrency.RussiaRuble, CourseCurrency = Convert.ToDecimal(59.25) },
                new Currency { TypeCurrency = TypeCurrency.Dollar, CourseCurrency = 1 });

            context.Categories.AddOrUpdate(category => category.Name,
                new Category { Name = "Двери", TypeCategory = TypeCategory.Doors },
                new Category { Name = "Лестницы", TypeCategory = TypeCategory.Stairs },
                new Category { Name = "Светильники", TypeCategory = TypeCategory.Fixtures },
                new Category { Name = "Мебель", TypeCategory = TypeCategory.Furniture },
                new Category { Name = "Эксперименты дизайнеров", TypeCategory = TypeCategory.DesignExp });

            context.Contacts.AddOrUpdate(contact => contact.Phone,
                new Contact { Phone = "+7 (928) 342-47-53", Email = "shtuki-tuki@yandex.ru" });

            context.SocialNetworks.AddOrUpdate(social => social.LinkNetwork,
                new SocialNetwork { LinkNetwork = "https://www.instagram.com/design_shtuki", TypeNetwork = TypeNetwork.Instagram },
                new SocialNetwork { LinkNetwork = "https://vk.com/club129227002", TypeNetwork = TypeNetwork.Vk },
                new SocialNetwork { LinkNetwork = "https://ok.ru/profile/563866844247", TypeNetwork = TypeNetwork.Ok });
        }
    }
}
