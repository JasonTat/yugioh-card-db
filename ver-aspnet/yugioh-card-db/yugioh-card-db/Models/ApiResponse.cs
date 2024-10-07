using static yugioh_card_db.Pages.Index;

namespace yugioh_card_db.Models
{
    public class CardApiResponse
    {
        public List<CardData> data { get; set; }
    }
}
