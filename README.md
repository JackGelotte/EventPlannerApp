# EventPlannerApp

## ASP.NET Core

Det är ett ramverk som består av verktyg och bibliotek som är till för att specifikt bygga webbapplikationer.
Det kommer med programmeringsmodeller som bland annat MVC och Razor Pages.
Man kan dela upp varje sida i design och kod.
Alltså att en sida har en del som är designen (HTML osv.) och en del som är "code-behind"-delen.


## Razor Pages

Razor Pages kommer med följande filer: Pages-folder, wwwroot-folder, Startup.cs, appsettings.json och Program.cs.
**_Startup.cs__** konfigurerar hur appen ska fungera. 
Här definerar man även hur requests ska hanteras.
**_appsettings.json_** håller konfigurerings värden.
Som t.ex connection string till min databas.
**_Program.cs_** det som startar allt.
Konsollen kör Main()-metoden som i sin tur kan skapa en hos till applikationen.
**_wwwroot-folder_** innehåller statiska filer. Sånt användare "alltid" ser när den använder appen.
Som JavaScript-filer eller CSS-filer.
**_Pages-foldern_** håller i våra razor-pages. Det finns en "shared"-folder här inne, med bland annat \_Layout.cshtml i sig.
Dessa är partial views, vilket i princip betyder att vi kan använda dom på flera ställen i applikationen. (\_Layout.cshtml håller t.ext i headern).


## MVC


