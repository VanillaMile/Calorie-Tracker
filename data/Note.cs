using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calorie_Tracker.data
{
    public class Note
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateTime { get; set; }

        [Required]
        [MaxLength(514)]
        public required string Noted { get; set; }

        public int? FoodId { get; set; }

        [ForeignKey("FoodId")]
        public Food? Food { get; set; }
    }
}
