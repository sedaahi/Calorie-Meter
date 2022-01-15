using Calorie_Meter.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calori_Meter.Data
{
    [Table("Foods")]
    public class Food
    {
        public Food()
        {
            RepastFoodDetails = new List<RepastFoodDetail>();
            ImagePath = Environment.CurrentDirectory.Replace("bin\\Debug", "") + "Images\\" + "Food-Default-Picture.png";
        }
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(200)]
        public string Name { get; set; }

        public double Protein { get; set; }

        public double CarboHydrate { get; set; }

        public double Fat { get; set; }

        public double Calorie { get; set; }

        public string ImagePath { get; set; }

        public int CountOfTotalEating { get; set; } = 0;
        public int CountOfEatingBreakfeast { get; set; } = 0;
        public int CountOfEatingLunch { get; set; } = 0;
        public int CountOfEatingDinner { get; set; } = 0;
        public int CountOfEatingSnack { get; set; } = 0;


        [ForeignKey("Category")]
        public int CategoriId { get; set; }
        public virtual Category Category { get; set; }

        public virtual ICollection<RepastFoodDetail> RepastFoodDetails { get; set; }

    }
}
