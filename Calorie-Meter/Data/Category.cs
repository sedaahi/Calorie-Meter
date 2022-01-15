using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calori_Meter.Data
{
    [Table("Categories")]
    public class Category
    {
        public Category()
        {
            Foods = new List<Food>();
        }
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        public virtual ICollection<Food> Foods { get; set; }

    }
}
