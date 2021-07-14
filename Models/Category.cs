using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeebarhRestaurant.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [DisplayName("DisplayOrder")]
        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Display Order For Category Must Be Greater Than 0")]
        public int DisplayOrder { get; set; }
    }
}
