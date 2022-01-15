using Calorie_Meter.Data;
using Calorie_Meter.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calori_Meter.Data
{
    [Table("RepastFoodDetails")]
    public class RepastFoodDetail
    {
        public RepastFoodDetail()
        {
            TotalCalorieDetail.ToString("N2");
            TotalProteinDetail.ToString("N2");
            TotalFatDetail.ToString("N2");
            TotalCarboHydrateDetail.ToString("N2");
        }
        [Key]
        public int Id { get; set; }
        public int Number { get; set; } = 0;

        public double TotalCalorieDetail { get; set; }
        public double TotalProteinDetail { get; set; }
        public double TotalFatDetail { get; set; }
        public double TotalCarboHydrateDetail { get; set; }
        
        public PortionPreference Portion { get; set; }



        [ForeignKey("Repast")]
        public int RepastId { get; set; }
        public virtual Repast Repast { get; set; }

        [ForeignKey("Food")]
        public int FoodId { get; set; }
        public virtual Food Food { get; set; }
    }
}
