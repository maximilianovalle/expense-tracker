// represents application data + business logic, often designed to represent database tables

using System.ComponentModel.DataAnnotations;

namespace expense_tracker.Models
{
    public class Expense
    {
        // properties/attributes
        public int ID { get; set; } // primary key
        public decimal Cost_USD { get; set; }   // dollar amnt

        [Required]
        public string? Description { get; set; }   // '?' makes the string nullable i.e. string can be null
    }
}