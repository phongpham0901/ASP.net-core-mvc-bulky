using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BulkyWebRazor_Temp.Models
{
    public class Category
    {

        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(30, ErrorMessage = "Vui Lòng Điền tên")]
        [DisplayName("Category Name")]
        public string Name { get; set; }
        [DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display Order từ 1-100")]
        public int DisplayOrder { get; set; }

    }
}
