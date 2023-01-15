using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Expense_Tracker.Models
{
    [Table("tbl_TotalLimit")]
    public class totalLimit
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Must be Set total Limit")]
        public long Total_Limit { get; set; }
    }
}
