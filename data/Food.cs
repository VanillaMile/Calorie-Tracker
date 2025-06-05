using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Calorie_Tracker.data
{
    public class Food
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public required string Name { get; set; }

        [Required]
        [Range(0, 100000)]
        [Column(TypeName = "decimal(10,2)")]
        public required decimal Calorie { get; set; }
        public decimal? Fats { get; set; }
        public decimal? Salts { get; set; }
        public decimal? Protein { get; set; }
        public decimal? Caffeine { get; set; }

        [Required]
        [Range(0, 100000)]
        [Column(TypeName = "decimal(10,2)")]
        public required decimal GramsInPortion { get; set; }
    }
}
