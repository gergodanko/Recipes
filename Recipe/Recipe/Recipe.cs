using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recipe
{
    class Recipe : ICloneable
    {
        
        public int Id;
        public String Name;
        public List<String> Ingredients;

        public Recipe( int id, String name,
            List<String> ingredients)
        {
            
            Id = id;
            Name = name;
            Ingredients = ingredients;
        }

        public object Clone()
        {
            List<string> copiedIngs = new List<string>();
            copiedIngs.AddRange(this.Ingredients);
            Recipe deepcopyRecipe = new Recipe(this.Id, this.Name, copiedIngs);

            return deepcopyRecipe;
            //return MemberwiseClone();
        }

        public override string ToString()
        {
            string s = "";
            foreach (string ingredient in Ingredients)
            {
                s += ingredient + ", ";
            }
            return $"ID: {Id} Name: {Name} Ingredients: {s}";
        }

    }
    
}
