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
