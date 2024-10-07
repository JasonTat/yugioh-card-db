using Newtonsoft.Json;
using System.Net.Http;
using System.Threading.Tasks;
using yugioh_card_db.Models;

public class CardService
{
    private readonly HttpClient _httpClient;

    public CardService (HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<CardModel>> GetCardsAsync ()
    {
        var response = await _httpClient.GetStringAsync("https://db.ygoprodeck.com/api/v7/cardinfo.php");

        //deserialize api res
        var apiRes = JsonConvert.DeserializeObject<CardApiResponse> (response);

        //map deserialized data to cardmodel

        var cards = apiRes.data.Select(cardData => new CardModel
        {
            Name = cardData.Name,
            Description = cardData.Description,
            ImageLink = cardData.Card_Images.FirstOrDefault()?.Image_Url
        }).ToList();

        return cards;


    }






}


