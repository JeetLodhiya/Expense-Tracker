using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    [Table("tbl_Category")]
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "*Name Required")]
        public String Name { get; set; }

        [Required(ErrorMessage = "*Limit Set Required..")]
        public long Ex_Limit { get; set; }
        //public string? Category { get; internal set; }

        public Category(string? category)
        {
           // Category = category;
        }

        public Category()
        {
        }

        public DateTime CategoryDate { get; internal set; }
    }
}
