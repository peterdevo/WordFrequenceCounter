Hur jag byggde appen.

Sätts upp projektet med hjälp av .Net cli, "dotnet new webapi" och skapades sedan CountController och Post request funktion i CountController. 
Användes StreamReader för att läsa in texten från klient. Texten måste filtreras på något sätt, som i det här fallet hade regular expression blivit ett av de alternativen, till exempel behöll 0-9,a-z,A-Z och åäö ÅÄÖ.
Texten splittrades sedan i olika ord och lagrade i en array. Dictionary i C# kom till användning för att lagra orden eftersom Dictionary behåller bara unika värde i sin nyckel.
Skapades en for-loop för att loppa genom alla orden för att hitta om ordet som redan fanns i Dictionary. Om det redan fanns,så inrementerades antalet på det befintliga ordet
annars lagrades ett nytt ord i Dictionary. Linq bibliotek blev också ett alternativ för att sortera antal på orden i nedåtgående riktning och i sin tur gick att returnera de tio mest frekventa orden. 
.För att CountController skulle se lite rent ut och troligtvis lättare att testa, repository pattern blev vald för att ge möjlighet att injektera beroende av sin vilja. 


Hur man kör samt använder appen.

-Installera .NET SDK https://dotnet.microsoft.com/en-us/download
-Installera .Vs code
-Installera Thunder client extension i .Vs code för att testa anropa rest api. (Det är valfritt, ni kan välja enligt er preferens).
-Klona det här projektet från github.
-Öppna en terminal i .Vs code och kör "dotnet run".
-När servern har påbörjats, Öppna Thunder client där ni kan klistra in den här url https://localhost:3000/count och väljs en "POST" request. 
 I Body kan ni välja "Text" som motsvarande text/plain och ni kan skriva in vad ni vill i "Text Content".

