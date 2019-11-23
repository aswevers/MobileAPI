using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MobileProjectAPI.Models
{
    public class Recipe
    {
        public long RecipeID { get; set; }
        public string Name { get; set; }
        public string Picture { get; set; } //Save images in backend. Only add a few as examples
        public string Instructions { get; set; }
        public long CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
