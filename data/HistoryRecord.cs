using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Calorie_Tracker.data
{
    public class HistoryRecord
    {
        [Key]
        public int Id { get; set; }

        [DataType(DataType.Date)]
        public DateTime DateTime { get; set; }

        [Range(0, 100000)]
        [Column(TypeName = "decimal(10,2)")]
        public decimal Grams { get; set; }

        [Range(0, 100000)]
        [Column(TypeName = "decimal(10,2)")]
        public decimal? Portions { get; set; }

        public required int FoodId { get; set; }

        [ForeignKey("FoodId")]
        public Food Food { get; set; }
    }
}
