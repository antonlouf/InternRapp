# InternRapp
ENG

This application is made in cooperation with Inetum-Realdolmen. This project was assignment to @recepp42 and myself during our internship at Inetum in 2022-2023. 
During my 3 month intership at Realdolmen I learned how it was being in an coorperate envirement with the structure way of tackling such project that comes being inside a big cooperation like Realdolmen.

Nl

Deze applicatie is gemaakt in samenwerking met Inetum-Realdolmen. Dit project was een opdracht aan @Recep Gultekin en mijzelf tijdens onze stage bij Inetum in 2022-2023. 
Tijdens mijn stage van 3 maanden bij Realdolmen heb ik geleerd hoe het is om te werken in een zakelijke omgeving en hoe er gestructureerd wordt omgegaan met dergelijke projecten binnen een grote organisatie als Realdolmen.
## The project
ENG

The intention of the project was to incorporate the internship management into a web app and create an export feature for automatically generating a Word document containing all the available internships offered by RealDolmen. This document could then be distributed to schools or final-year students. 
The application itself would be used by school coordinators and RealDolmen employees who provide internship training. They would enter the internship assignments, which could be subsequently sent out. 

NL

De bedoeling van het project was om de stagebehandeling in een webapp te gieten en een export feature te creeren voor het automatisch generen van een word bestand van al de beschikbare stages die realdolmen te bieden heeft. Dit document zou dan rondgestuurd kunnen worden naar de scholen of laatstejaar studenten. 
De applicatie zelf wordt dan gebruikt door schoolcoordinatoren en realdolmen werknemers die stagaires opleiden. Zij voeren de stageopdrachten in die dan nadien doorgestuurd kunnen worden. 

## Used Technologies
ENG

The backend API was to be developed using **ASP.NET Core Entity Framework**, utilizing patterns such as **clean architecture** and **CQRS**. For data migration, we used the Fluent API with a SQL database.  
For our frontend, we used the **NX framework** built on top of Angular. It was expected that we would use **observables**, which are similar to promises in JavaScript. 
For authentication, we had to utilize the RealDolmen **Azure Active Directory**, meaning there would need to be a BFF proxy between these two layers. This proxy would track authorized individuals based on access tokens and cookies. 
All of this together would then need to be published on **Azure** to be accessible from external sources.

NL

De backend Api zou gemaakt worden met **Asp.net core Entity Framework** gebruik makend van patronen als **clean architecture** en **cqrs**. Voor Data migratie maakte we gebruik van de Fluent API met een sql database.  
Voor onze Frontend gebruikte we het **nx framework** dat bovenop Angular ligt. Hierbij werd verwacht dat we gebruik maakte van **observables** wat sterk lijkt op promises in javascript.
Voor authenticatie moesten we gebruik maken van de realdolmen **azure active directory** dat wil zeggen dat tussen deze twee lagen dan een BFF proxy zou hebben moeten liggen die adhv access tokens en cookies bijhoudt welke persoon geautoriseerd is en welke niet. 
Dit alles tezamen zou dan gepublished moeten worden op **azure** om aanspreekbaar te kunnen zijn van buitenaf. 

