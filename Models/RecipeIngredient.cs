using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileProjectAPI.Models
{
    public class RecipeIngredient
    {
        public long RecipeIngredientID { get; set; }
        public long IngredientID { get; set; }
        public long RecipeID { get; set; }
        public string Measurement { get; set; }

        public Recipe Recipe { get; set; }
        public Ingredient Ingredient { get; set; }
    }
}
