using static yugioh_card_db.Pages.Index;

namespace yugioh_card_db.Models
{
    public class CardData
    {
        public string Name { set; get; }
        public int? Level { get; set; }
        public int? Atk { get; set; }
        public int? Def { get; set; }
        public string Type { get; set; }
        public string Description { get; set; }
        public List<CardImage> Card_Images { get; set; }

    }
}
