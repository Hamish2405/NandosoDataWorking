using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Data.Entity.Migrations;

namespace Nandos.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class NandosContext : DbContext
    {
        public class MyConfiguration : DbMigrationsConfiguration<NandosContext>
        {
            public MyConfiguration()
            {
                this.AutomaticMigrationsEnabled = true;
            }

            protected override void Seed(NandosContext context)
            {
                var specials = new List<Special>
                {
                    new Special {Name = "Classic Chicken Breast Burger",
                                 Picture = "Pictures/N00.jpg",
                                 Description = "Sink your teeth into our soft, seeded bun filled with a delicious marinated skinless chicken breast, fresh lettuce, tomato & our special light mayo.",
                                 Price = "$9.90"},
                    new Special {Name = "Chicken Breast Pita",
                                 Picture = "Pictures/N01.jpg",
                                 Description = "Portuguese passion in a pita with a succulent, skinless chicken breast, crisp iceberg lettuce, cucumber & juicy tomato, topped with our special light mayo.",
                                 Price = "$10.90"},
                    new Special {Name = "Classic Chicken Wrap",
                                 Picture = "Pictures/N04.jpg",
                                 Description = "Our scrumptious home-style veggie patty will please when placed in a warm pita with fresh lettuce, tomato, cucumber & our special light mayo. ",
                                 Price = "$9.90"},
                    new Special {Name = "Espetada Grande",
                                 Picture = "Pictures/N02.jpg",
                                 Description = "Marinated thigh fillets skewered with fresh red capsicum and onion, flame-grilled to perfection, basted to your heart's desire, served over a regular side.",
                                 Price = "$20.90"},

                };
                specials.ForEach(s => context.Specials.AddOrUpdate(p => p.Description, s));
                context.SaveChanges();
            }
        }
        public NandosContext() : base("name=NandosContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<NandosContext, MyConfiguration>());
        }

        public System.Data.Entity.DbSet<Nandos.Models.Special> Specials { get; set; }
    }
}
