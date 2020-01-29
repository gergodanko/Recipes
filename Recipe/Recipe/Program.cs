using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Recipe
{
    class Program

    {

        static void Main(string[] args)
        {
            Recipe szenya = new Recipe(12, "szendvics", new List<String> { "vaj", "kenyer" });
            Recipe bodak = new Recipe(11, "Cigany bodak", new List<String> { "liszt", "eleszto", "szodabikarbona" });
            Recipe lecso = new Recipe(10, "Lecso", new List<String> { "paprika", "hagyma","paradicsom","so" });
            Recipe szalmonella = new Recipe(1, "szalmonella", new List<String> { "tojas" });
            Recipe koviubi = new Recipe(13, "Kovaszos ubi", new List<String> { "viz", "kenyer", "befottes uveg", "uborka" });

            displayRecipe(szenya);
            displayRecipe(bodak);
            displayRecipe(lecso);
            displayRecipe(szalmonella);
            displayRecipe(koviubi);

            Recipe melegszenya = (Recipe)szenya.Clone();
            melegszenya.Id = 69;
            melegszenya.Name = "Melegszendvics";
            melegszenya.Ingredients = new List<String> { "kenyer","vaj", "meleg" };

            Recipe bundaskenyer = (Recipe)szalmonella.Clone();
            bundaskenyer.Id = 4;
            bundaskenyer.Name = "Bundaskenyer";
            bundaskenyer.Ingredients.Add("kenyer");
            bundaskenyer.Ingredients.Add("so");

            Recipe lecsosbodak = (Recipe)bodak.Clone();
            lecsosbodak.Id = 420;
            lecsosbodak.Name = "Lecsos cigany bodak";
            lecsosbodak.Ingredients.AddRange(lecso.Ingredients);

            Console.WriteLine("=============================");

            displayRecipe(szenya);
            displayRecipe(bodak);
            displayRecipe(lecso);
            displayRecipe(szalmonella);
            displayRecipe(koviubi);

            displayRecipe(melegszenya);
            displayRecipe(bundaskenyer);
            displayRecipe(lecsosbodak);

            Console.ReadLine();
        }

        private static void displayRecipe(Recipe r)
        {
            Console.WriteLine(r.ToString());
        }
    }

}
