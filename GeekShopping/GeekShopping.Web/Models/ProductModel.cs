
using System.ComponentModel.DataAnnotations;

namespace GeekShopping.Web.Models
{
    public class ProductModel
    {
        [Display(Name = "Id")]
        public long Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        [StringLength(150)]
        public string Name { get; set; }

        [Required]
        [Range(1.00, 10000.00)]
        [Display(Name = "Price")]
        [DataType(DataType.Currency)]
        [DisplayFormat(DataFormatString = "{0:F2}")]
        public decimal Price { get; set; }

        [StringLength(500)]
        [Display(Name = "Description")]
        public string Description { get; set; }

        [StringLength(50)]
        [Display(Name = "Category Name")]
        public string CategoryName { get; set; }

        [StringLength(300)]
        [Display(Name = "Image URL")]
        public string ImageUrl { get; set; }
    }
}
