using System.ComponentModel.DataAnnotations;

namespace Film_HF.Modell {
    public class Film {
        [Key]
        public int Id { get; set; }
        [Required]
        public string? Title { get; set; }
        [Required]
        public string? Director { get; set; }
        [Required]
        [RegularExpression(@"^(.*(https\:\/\/www\.imdb\.com/title/)+([a-zA-Z0-9]{9,}).*)$", ErrorMessage = "Hibás IMDB link.")]
        public string? ImdbLink { get; set; }
    }
}
