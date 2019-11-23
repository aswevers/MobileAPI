using MobileProjectAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileProjectAPI.Data
{
    public class DBInitializer
    {
        public static void Initialize(CookbookContext context)
        {
            context.Database.EnsureCreated();

            if(context.Ingredients.Any()){
                return;   
                // DB has been seeded
            }
            
            context.Ingredients.AddRange(
                new Ingredient { Name = "Appel" },
                new Ingredient { Name = "Peer" },
                new Ingredient { Name = "Wortel" },
                new Ingredient { Name = "Kip" }
            );

            context.SaveChanges();
        }
    }
}
