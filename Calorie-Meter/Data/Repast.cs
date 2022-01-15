using Calori_Meter.Data;
using Calorie_Meter.Data;
using Calorie_Meter.Data.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calorie_Meter.Data
{
    [Table("Repasts")]
    public class Repast
    {
        public Repast()
        {
            RepastFoodDetails = new List<RepastFoodDetail>();
        }
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }
        public RepastName RepastName { get; set; }
        public DateTime? Date { get; set; } = DateTime.Now;

        public double TotalCalorieRepast { get; set; } = 0;
        public double TotalProteinRepast { get; set; } = 0;
        public double TotalFatRepast { get; set; } = 0;
        public double TotalCarboHydrateRepast { get; set; } = 0;


        [ForeignKey("User")]
        public int UserId { get; set; }
        public virtual User User { get; set; }

        public virtual ICollection<RepastFoodDetail> RepastFoodDetails { get; set; }
    }
}
