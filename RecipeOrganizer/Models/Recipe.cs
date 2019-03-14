using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RecipeOrganizer.Models
{
    public class Recipe
    {
        public int ID { get; set; }

        [Required, MaxLength(50)]
        public string Title { get; set; }

        [Required, MaxLength(1500)]
        public string Instructions { get; set; }

        [Required, MaxLength(1500)]
        public string Ingredients { get; set; }

        public CategoryEnum Category { get; set; }
    }

    public enum CategoryEnum

    {
        Desserts,
        Salads,
        Soups,
        Meats,
        Breakfast,
        SideDishes,
        Casseroles,
        Beverages,
        Appetizers,
        Breads,
        Other
    }
}
