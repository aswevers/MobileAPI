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
            context.Database.EnsureDeleted();
            context.Database.EnsureCreated();

            if (context.RecipeIngredients.Any()) {
                return;
                // DB has been seeded
            }
            var categories = new List<Category> {
                new Category { Name = "Dessert" },
                new Category { Name = "Pasta" },
                new Category { Name = "Vegetarian" },
                new Category { Name = "Seafood" },
        };

            var ingredients = new List<Ingredient> {
                new Ingredient { Name = "Digestive biscuits" },
                new Ingredient { Name = "Butter" },
                new Ingredient { Name = "Bramley apples" },
                new Ingredient { Name = "Softened butter" },
                new Ingredient { Name = "Caster sugar" },
                new Ingredient { Name = "Beaten free-range eggs" },
                new Ingredient { Name = "Ground almonds" },
                new Ingredient { Name = "Almond extract" },
                new Ingredient { Name = "Flaked almond" },
                new Ingredient { Name = "Plain Flour" },
                new Ingredient { Name = "Braeburn Apples"},
                new Ingredient { Name = "Demerara Sugar"},
                new Ingredient { Name = "Blackberries"},
                new Ingredient { Name = "Cinnamon"},
                new Ingredient { Name = "Ice Cream"},
                new Ingredient { Name = "Onions"},
                new Ingredient { Name = "Olive oil"},
                new Ingredient { Name = "Garlic"},
                new Ingredient { Name = "Lean minced beef"},
                new Ingredient { Name = "Mushrooms"},
                new Ingredient { Name = "Dried oregano"},
                new Ingredient { Name = "Tomatoes"},
                new Ingredient { Name = "Hot beef stock"},
                new Ingredient { Name = "Tomato puree"},
                new Ingredient { Name = "Worcestershire sauce"},
                new Ingredient { Name = "Spaghetti"},
                new Ingredient { Name = "Parmesan"},
                new Ingredient { Name = "Penne"},
                new Ingredient { Name = "Chopped tomatoes"},
                new Ingredient { Name = "Red chili flakes"},
                new Ingredient { Name = "Italian seasoning"},
                new Ingredient { Name = "Basil"},
                new Ingredient { Name = "Small potatoes"},
                new Ingredient { Name = "Harissa spice"},
                new Ingredient { Name = "Spring onions"},
                new Ingredient { Name = "Rocket"},
                new Ingredient { Name = "Lemon"},
                new Ingredient { Name = "Feta"},
                new Ingredient { Name = "Mint"},
                new Ingredient { Name = "Pine nuts"},
                new Ingredient { Name = "Salt"},
                new Ingredient { Name = "Pepper"},
                new Ingredient { Name = "Raw king prawns"},
                new Ingredient { Name = "Parsley"},
                new Ingredient { Name = "White wine"},
            };

            var recipes = new List<Recipe> { 
                new Recipe { Name = "Apple Frangipan Tart", Category = categories.Single(c => c.Name == "Dessert"), Picture = "https://www.themealdb.com/images/media/meals/wxywrq1468235067.jpg", Instructions = "Preheat the oven to 200C/180C Fan/Gas 6.\r\nPut the biscuits in a large re-sealable freezer bag and bash with a rolling pin into fine crumbs. Melt the butter in a small pan, then add the biscuit crumbs and stir until coated with butter. Tip into the tart tin and, using the back of a spoon, press over the base and sides of the tin to give an even layer. Chill in the fridge while you make the filling.\r\nCream together the butter and sugar until light and fluffy. You can do this in a food processor if you have one. Process for 2-3 minutes. Mix in the eggs, then add the ground almonds and almond extract and blend until well combined.\r\nPeel the apples, and cut thin slices of apple. Do this at the last minute to prevent the apple going brown. Arrange the slices over the biscuit base. Spread the frangipane filling evenly on top. Level the surface and sprinkle with the flaked almonds.\r\nBake for 20-25 minutes until golden-brown and set.\r\nRemove from the oven and leave to cool for 15 minutes. Remove the sides of the tin. An easy way to do this is to stand the tin on a can of beans and push down gently on the edges of the tin.\r\nTransfer the tart, with the tin base attached, to a serving plate. Serve warm with cream, crème fraiche or ice cream." },
                new Recipe { Name = "Apple & Blackberry Crumble", Category = categories.Single(c => c.Name == "Dessert"), Picture = "https://www.themealdb.com/images/media/meals/xvsurr1511719182.jpg", Instructions = "Heat oven to 190C/170C fan/gas 5. Tip the flour and sugar into a large bowl. Add the butter, then rub into the flour using your fingertips to make a light breadcrumb texture. Do not overwork it or the crumble will become heavy. Sprinkle the mixture evenly over a baking sheet and bake for 15 mins or until lightly coloured.\r\nMeanwhile, for the compote, peel, core and cut the apples into 2cm dice. Put the butter and sugar in a medium saucepan and melt together over a medium heat. Cook for 3 mins until the mixture turns to a light caramel. Stir in the apples and cook for 3 mins. Add the blackberries and cinnamon, and cook for 3 mins more. Cover, remove from the heat, then leave for 2-3 mins to continue cooking in the warmth of the pan.\r\nTo serve, spoon the warm fruit into an ovenproof gratin dish, top with the crumble mix, then reheat in the oven for 5-10 mins. Serve with vanilla ice cream." },
                new Recipe { Name = "Spaghetti Bolognese", Category = categories.Single(c => c.Name == "Pasta"), Picture = "https://www.themealdb.com/images/media/meals/sutysw1468247559.jpg", Instructions = "Put the onion and oil in a large pan and fry over a fairly high heat for 3-4 mins. Add the garlic and mince and fry until they both brown. Add the mushrooms and herbs, and cook for another couple of mins.\r\n\r\nStir in the tomatoes, beef stock, tomato ketchup or purée, Worcestershire sauce and seasoning. Bring to the boil, then reduce the heat, cover and simmer, stirring occasionally, for 30 mins.\r\n\r\nMeanwhile, cook the spaghetti in a large pan of boiling, salted water, according to packet instructions. Drain well, run hot water through it, put it back in the pan and add a dash of olive oil, if you like, then stir in the meat sauce. Serve in hot bowls and hand round Parmesan cheese, for sprinkling on top." },
                new Recipe { Name = "Spicy Arrabiata Penne", Category = categories.Single(c => c.Name == "Pasta"), Picture = "https://www.themealdb.com/images/media/meals/ustsqw1468250014.jpg", Instructions = "Bring a large pot of water to a boil. Add kosher salt to the boiling water, then add the pasta. Cook according to the package instructions, about 9 minutes.\r\nIn a large skillet over medium-high heat, add the olive oil and heat until the oil starts to shimmer. Add the garlic and cook, stirring, until fragrant, 1 to 2 minutes. Add the chopped tomatoes, red chile flakes, Italian seasoning and salt and pepper to taste. Bring to a boil and cook for 5 minutes. Remove from the heat and add the chopped basil.\r\nDrain the pasta and add it to the sauce. Garnish with Parmigiano-Reggiano flakes and more basil and serve warm." },
                new Recipe { Name = "Spicy North African Potato Salad", Category = categories.Single(c => c.Name == "Vegetarian"), Picture = "https://www.themealdb.com/images/media/meals/urtwux1486983078.jpg", Instructions = "Cook potatoes - place potatoes in a pot of cold water, and bring to the boil. Boil 20 minutes, or until potatoes are tender. You know they are cooked when you can stick a knife in them and the knife goes straight through.\r\nCombine harissa spice, olive oil, salt and pepper and lemon juice in a small bowl and whisk until combined.\r\nOnce potatoes are cooked, drain water and roughly chop potatoes in half.\r\nAdd harissa mix and spring onions/green onions to potatoes and stir.\r\nIn a large salad bowl, lay out arugula/rocket.\r\nTop with potato mix and toss.\r\nAdd fetta, mint and sprinkle over pine nuts.\r\nAdjust salt and pepper to taste." },
                new Recipe { Name = "Garides Saganaki", Category = categories.Single(c => c.Name == "Seafood"), Picture = "https://www.themealdb.com/images/media/meals/wuvryu1468232995.jpg", Instructions = "Place the prawns in a pot and add enough water to cover. Boil for 5 minutes. Drain, reserving the liquid, and set aside.\r\nHeat 2 tablespoons of oil in a saucepan. Add the onion; cook and stir until soft. Mix in the parsley, wine, tomatoes, garlic and remaining olive oil. Simmer, stirring occasionally, for about 30 minutes, or until the sauce is thickened.\r\nWhile the sauce is simmering, the prawns should become cool enough to handle. First remove the legs by pinching them, and then pull off the shells, leaving the head and tail on.\r\nWhen the sauce has thickened, stir in the prawns. Bring to a simmer again if the sauce has cooled with the prawns, and cook for about 5 minutes. Add the feta and remove from the heat. Let stand until the cheese starts to melt. Serve warm with slices of crusty bread.\r\nThough completely untraditional, you can add a few tablespoons of stock or passata to this recipe to make a delicious pasta sauce. Toss with pasta after adding the feta, and serve." },
            };

            new List<RecipeIngredient>
            {
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Digestive biscuits"), Measurement="175gr", Recipe = recipes.Single(r => r.Name == "Apple Frangipan Tart")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Butter"), Measurement="75gr", Recipe = recipes.Single(r => r.Name == "Apple Frangipan Tart")},
                new RecipeIngredient { Ingredient = ingredients.Single(i =>i.Name == "Bramley apples"), Measurement="200gr", Recipe = recipes.Single(r => r.Name == "Apple Frangipan Tart")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Softened butter"), Measurement="75gr", Recipe = recipes.Single(r => r.Name == "Apple Frangipan Tart")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Caster sugar"), Measurement="75gr", Recipe = recipes.Single(r => r.Name == "Apple Frangipan Tart")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Beaten free-range eggs"), Measurement="2", Recipe = recipes.Single(r => r.Name == "Apple Frangipan Tart")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Ground almonds"), Measurement="75gr", Recipe = recipes.Single(r => r.Name == "Apple Frangipan Tart")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Almond extract"), Measurement="1 tsp", Recipe = recipes.Single(r => r.Name == "Apple Frangipan Tart")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Flaked almond"), Measurement="50gr", Recipe = recipes.Single(r => r.Name == "Apple Frangipan Tart")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Plain Flour"), Measurement="120gr", Recipe = recipes.Single(r => r.Name == "Apple & Blackberry Crumble")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Caster sugar"), Measurement="60gr", Recipe = recipes.Single(r => r.Name == "Apple & Blackberry Crumble")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Butter"), Measurement="60gr", Recipe = recipes.Single(r => r.Name == "Apple & Blackberry Crumble")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Braeburn Apples"), Measurement="300gr", Recipe = recipes.Single(r => r.Name == "Apple & Blackberry Crumble")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Butter"), Measurement="30gr", Recipe = recipes.Single(r => r.Name == "Apple & Blackberry Crumble")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Demerara Sugar"), Measurement="30gr", Recipe = recipes.Single(r => r.Name == "Apple & Blackberry Crumble")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Blackberries"), Measurement="120gr", Recipe = recipes.Single(r => r.Name == "Apple & Blackberry Crumble")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Cinnamon"), Measurement="1/4 tsp", Recipe = recipes.Single(r => r.Name == "Apple & Blackberry Crumble")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Ice Cream"), Measurement="to serve", Recipe = recipes.Single(r => r.Name == "Apple & Blackberry Crumble")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Onions"), Measurement="2", Recipe = recipes.Single(r => r.Name == "Spaghetti Bolognese")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Olive oil"), Measurement="1tbsp", Recipe = recipes.Single(r => r.Name == "Spaghetti Bolognese")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Garlic"), Measurement="1 clove", Recipe = recipes.Single(r => r.Name == "Spaghetti Bolognese")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Lean minced beef"), Measurement="500gr", Recipe = recipes.Single(r => r.Name == "Spaghetti Bolognese")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Mushrooms"), Measurement="90gr", Recipe = recipes.Single(r => r.Name == "Spaghetti Bolognese")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Dried oregano"), Measurement="1tbs", Recipe = recipes.Single(r => r.Name == "Spaghetti Bolognese")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Tomatoes"), Measurement="400g can", Recipe = recipes.Single(r => r.Name == "Spaghetti Bolognese")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Hot beef stock"), Measurement="300ml", Recipe = recipes.Single(r => r.Name == "Spaghetti Bolognese")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Tomato puree"), Measurement="1tbsp", Recipe = recipes.Single(r => r.Name == "Spaghetti Bolognese")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Worcestershire sauce"), Measurement="1tbsp", Recipe = recipes.Single(r => r.Name == "Spaghetti Bolognese")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Spaghetti"), Measurement="350gr", Recipe = recipes.Single(r => r.Name == "Spaghetti Bolognese")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Parmesan"), Measurement="to serve", Recipe = recipes.Single(r => r.Name == "Spaghetti Bolognese")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Parmesan"), Measurement="to serve", Recipe = recipes.Single(r => r.Name == "Spicy Arrabiata Penne")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Penne"), Measurement="1lbs", Recipe = recipes.Single(r => r.Name == "Spicy Arrabiata Penne")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Olive oil"), Measurement="1/4cup", Recipe = recipes.Single(r => r.Name == "Spicy Arrabiata Penne")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Garlic"), Measurement="3 cloves", Recipe = recipes.Single(r => r.Name == "Spicy Arrabiata Penne")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Chopped tomatoes"), Measurement="1 tin", Recipe = recipes.Single(r => r.Name == "Spicy Arrabiata Penne")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Red chili flakes"), Measurement="1/2 tsp", Recipe = recipes.Single(r => r.Name == "Spicy Arrabiata Penne")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Italian seasoning"), Measurement="1/2 tsp", Recipe = recipes.Single(r => r.Name == "Spicy Arrabiata Penne")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Basil"), Measurement="6 leaves", Recipe = recipes.Single(r => r.Name == "Spicy Arrabiata Penne")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Small potatoes"), Measurement="650gr", Recipe = recipes.Single(r => r.Name == "Spicy North African Potato Salad")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Harissa spice"), Measurement="1tsp", Recipe = recipes.Single(r => r.Name == "Spicy North African Potato Salad")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Olive oil"), Measurement="2tsp", Recipe = recipes.Single(r => r.Name == "Spicy North African Potato Salad")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Lemon"), Measurement="juice of half", Recipe = recipes.Single(r => r.Name == "Spicy North African Potato Salad")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Spring onions"), Measurement="4", Recipe = recipes.Single(r => r.Name == "Spicy North African Potato Salad")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Rocket"), Measurement="150gr", Recipe = recipes.Single(r => r.Name == "Spicy North African Potato Salad")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Feta"), Measurement="80gr", Recipe = recipes.Single(r => r.Name == "Spicy North African Potato Salad")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Mint"), Measurement="20 chopped", Recipe = recipes.Single(r => r.Name == "Spicy North African Potato Salad")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Pine nuts"), Measurement="2 tbsp", Recipe = recipes.Single(r => r.Name == "Spicy North African Potato Salad")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Salt"), Measurement="pinch", Recipe = recipes.Single(r => r.Name == "Spicy North African Potato Salad")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Pepper"), Measurement="pinch", Recipe = recipes.Single(r => r.Name == "Spicy North African Potato Salad")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Feta"), Measurement="1 pack", Recipe = recipes.Single(r => r.Name == "Garides Saganaki")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Garlic"), Measurement="1/2 tsp", Recipe = recipes.Single(r => r.Name == "Garides Saganaki")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Chopped tomatoes"), Measurement="1 tin", Recipe = recipes.Single(r => r.Name == "Garides Saganaki")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "White wine"), Measurement="250ml", Recipe = recipes.Single(r => r.Name == "Garides Saganaki")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Parsley"), Measurement="pinch", Recipe = recipes.Single(r => r.Name == "Garides Saganaki")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Onions"), Measurement="1", Recipe = recipes.Single(r => r.Name == "Garides Saganaki")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Olive oil"), Measurement="3 tbsp", Recipe = recipes.Single(r => r.Name == "Garides Saganaki")},
                new RecipeIngredient { Ingredient = ingredients.Single(i => i.Name == "Raw king prawns"), Measurement="500gr", Recipe = recipes.Single(r => r.Name == "Garides Saganaki")},
            }.ForEach(r =>context.RecipeIngredients.Add(r));

            context.SaveChanges();
        }
    }
}
