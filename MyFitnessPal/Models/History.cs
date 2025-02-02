using System.ComponentModel.DataAnnotations;

namespace MyFitnessPal.Models
{
    public class History
    {
        public int HistoryId { get; set; }
        [Required]
        public DateTime? HistoryDate { get; set; }
        [Required]
        public double? HistoryTime { get; set; }
        [Required]
        public string? HistoryCategory { get; set; }
        [Required]
        public string? HistoryDescription { get; set; }
    }
}
