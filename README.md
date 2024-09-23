# yugioh-card-db

## This project is just a personal project to showcase my skills with consuming external API's and using it on a web app with C# ASP.NET

## API Source: https://ygoprodeck.com/api-guide/

## Endpoint
**GET all cards** (This is the only endpoint, actually.)  
https://db.ygoprodeck.com/api/v7/cardinfo.php  
Returns a list of ALL Yugioh cards

*Example Endpoints*  
https://db.ygoprodeck.com/api/v7/cardinfo.php?name=Dark%Magician
- Finds card based off the card name

https://db.ygoprodeck.com/api/v7/cardinfo.php?archetype=Blue-Eyes  
- Finds all cards with the archetype of 'Blue-Eyes'


https://db.ygoprodeck.com/api/v7/cardinfo.php?level=4&attribute=water&sort=atk
- Finds all `LEVEL 4` cards with the `WATER Attribute`

More example endpoints/parameters on the API docs linked above.

```
The following endpoint parameters can be passed:

name - The exact name of the card. You can pass multiple | separated names to this parameter (Baby Dragon|Time Wizard).
fname - A fuzzy search using a string. For example &fname=Magician to search by all cards with "Magician" in the name.
id - The 8-digit passcode of the card. You cannot pass this alongside name. You can pass multiple comma separated IDs to this parameter.
konami_id - The Konami ID of the card. This is not the passcode.
type - The type of card you want to filter by. See below "Card Types Returned" to see all available types. You can pass multiple comma separated Types to this parameter.
atk - Filter by atk value.
def - Filter by def value.
level - Filter by card level/RANK.
race - Filter by the card race which is officially called type (Spellcaster, Warrior, Insect, etc). This is also used for Spell/Trap cards (see below). You can pass multiple comma separated Races to this parameter.
attribute - Filter by the card attribute. You can pass multiple comma separated Attributes to this parameter.
link - Filter the cards by Link value.
linkmarker - Filter the cards by Link Marker value (Top, Bottom, Left, Right, Bottom-Left, Bottom-Right, Top-Left, Top-Right). You can pass multiple comma separated values to this parameter (see examples below).
scale - Filter the cards by Pendulum Scale value.
cardset - Filter the cards by card set (Metal Raiders, Soul Fusion, etc).
archetype - Filter the cards by archetype (Dark Magician, Prank-Kids, Blue-Eyes, etc).
banlist - Filter the cards by banlist (TCG, OCG, Goat).
sort - Sort the order of the cards (atk, def, name, type, level, id, new).
format - Sort the format of the cards (tcg, goat, ocg goat, speed duel, master duel, rush duel, duel links). Note: Duel Links is not 100% accurate but is close. Using tcg results in all cards with a set TCG Release Date and excludes Speed Duel/Rush Duel cards.
misc - Pass yes to show additional response info (details).
staple - Check if card is a staple.
has_effect - Check if a card actually has an effect or not by passing a boolean true/false. Examples of cards that do not have an actual effect: Black Skull Dragon, LANphorhynchus, etc etc.
startdate, enddate and dateregion - Filter based on cards' release date. Format dates as YYYY-mm-dd. Pass dateregion as tcg (default) or ocg.
You can also use the following equation symbols for atk, def and level:
"lt" (less than), "lte" (less than equals to), "gt" (greater than), "gte" (greater than equals to).

Examples: atk=lt2500 (atk is less than 2500), def=gte2000 (def is greater than or equal to 2000) and level=lte8 (level is less than or equal to 8).
```