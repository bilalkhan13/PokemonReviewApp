namespace PokemonReviewApp.Models
{
    public class PokemonCategory
    {
        public int CategoryId { get; set; }
        public int PokemonId { get; set; }
        public Pokemon Pokemon { get; set; }

        public Category Category { get; set; }
    }
}
