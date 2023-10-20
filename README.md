# IRDbApi och IRDbApp

Detta är en eximinationsuppgift för Objektorienterad programmering - Avancerad (part 1) hos NBI/Handelsakademin.

Uppgiften innebär att bygga ett API som kopplar till en databas som innehåller filmer.
I den utökade uppgiften ingår även att bygga ett frontend gränssnitt som konsumerar APIt.

Jag valde att göra båda uppgifterna och skall nedan förklara lite hur de fungerar och de val som gjorts när koden skrevs.

## IRDbApi

### Databas
Koden byggdes upp genom att först skapa en filmmodell (MovieModell) och en databaskontext (AppDbContext).
Databaskontexten skapades för att kunna användas tillsammans med programpaketet EntityFramework för att skapa en databas genom C# kod.

### API
Efter databasen var skapade kunde jag börja sätta upp min API.
Apin skapades  genom ett så kallat repository-pattern.
Detta innebär att man skapar ett interface för sina repositorys som databasen kan konsumera.
I längden så gör detta att man slipper revidera kod som har med databaskopplingen att göra.
Om man vill göra ändringar i hur data som skickas till databasen skall behandlas så gör man det i en separat klass ofta kallad en controller.

Detta fungerar bra så länge man inte skall ändra på hur data skall hämtas.
T.ex. om man vill hämta något genom att ange ett värde t.ex. namn och det inte går sedan innan så måste man in och ändra både i sin controller och en i ny repository fil.

## IRDbApp

### HTML/CSS
Har skapa en sida med flexboxar och grid för att få något som liknar något som skulle kunna användas som en sida för ett företag. Detta är inte min starka sida och har bristande kunskap i hur en sida skall byggas. Valde ändå att försöka något som ändå går att visa upp.
Sidan har även några fält och en knapp som användaren kan interagera med för att kunna lägga till en film.

### JavaScript
I den underliggande koden för hemsidan som är skriven i JavaScript så sker magin m.a.o. kopplingen till APIt.

När sidan laddas så körs ett GET kommando asynkront till APIt som i sin tur skickar ett svar som görs om till json data för att lättare kunna konsumeras av hemsidan.
Efter detta är gjort så itereras datan i json objektet och matas ut i olika html kod element "kort". När korten är skapade så visas de upp på hemsidan.

Det finns även funktioner för att skapa ett filmobjekt. JavaScriptet väntar på att användaren skall trycka på "Lägg till film" knappen på hemsidan när detta sker så läser scriptet av datan som är finns i de olika textfälten som användaren kan interagera med.

Denna data (om inte värdena som inte får vara tomma är tomma) knyts till ett nytt objekt kallat newMovie. Detta objekt konverteras till strängar och skickas i ett POST kommando till APIt.
Om allt lyckas så laddas sidan om med det nya elementen.