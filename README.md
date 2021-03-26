# EventPlannerApp

## ASP.NET Core

Det är ett ramverk som består av verktyg och bibliotek som är till för att specifikt bygga webbapplikationer.
Det kommer med programmeringsmodeller som bland annat MVC och Razor Pages.
Man kan dela upp varje sida i design och kod.
Alltså att en sida har en del som är designen (HTML osv.) och en del som är "code-behind"-delen.


## Razor & MVC
- **_Startup.cs__** konfigurerar hur appen ska fungera. 
Här definerar man även hur requests ska hanteras.
- **_appsettings.json_** håller konfigurerings värden.
Som t.ex connection string till min databas.
- **_Program.cs_** det som startar allt.
Konsollen kör Main()-metoden som i sin tur kan skapa en host till applikationen.
- **_wwwroot-folder_** innehåller statiska filer. Sånt användare "alltid" ser när den använder appen.
Som JavaScript-filer eller CSS-filer.

## Razor Pages
- **_Pages-foldern_** håller i våra razor-pages. Det finns en "shared"-folder här inne, med bland annat \_Layout.cshtml i sig.
Dessa är partial views, vilket i princip betyder att vi kan använda dom på flera ställen i applikationen. (\_Layout.cshtml håller t.ext i headern).
Razor pages har som standard två sidor:
En "content"-sida, som mestadels är HTML, dvs. sånt som användaren kommer att se. Vi kan med razor-syntax skriva lättvikt C# kod om vi vill.
Och "code-behind"-sida, där vi kan binda properties och koda mer komplexa uppgifter. Lite av en kombination av Models och Controllers i MVC (se nedan).


## MVC
- **_Models_** innehåller klasser som definerar vår data. Hur det ska skapas, sparas eller ändras.
- **_Views_** har HTML koden. Views ansvarar för att presentera innehåll till användare, via UI.
- **_Controllers_** har klasser som hanterar interaktionen med användaren. Alltså vilken model som ska användas och vilken view som ska visas.

