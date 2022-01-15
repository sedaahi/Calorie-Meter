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
    [Table("Users")]
    public class User
    {
        public User()
        {
            Repasts = new List<Repast>();
        }
        [Key]
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Name { get; set; }

        [Required, MaxLength(100)]
        public string EMail { get; set; }

        [Required, MaxLength(15)]
        public string Password { get; set; }

        public virtual ICollection<Repast> Repasts { get; set; }

    }
}
