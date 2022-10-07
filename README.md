# Oppgave

1. Gå til www.vegvesen.no/kjoretoy/eie-og-vedlikeholde/finn-godkjent-verksted, trykk *Søk* og deretter *Lag rapport i CSV*. 
2. Bruk csvjson.com til å konvertere CSV-filen til JSON.
3. Lag en C# konsollapp som leser inn JSON-filen som en liste av objekter - hvor du lager klassen som trengs (Tips til google søk: deserialize json C#)
4. Lag en meny - brukeren skal kunne velge et fylke (se https://no.wikipedia.org/wiki/Norges_postnumre for mapping av postnr til fylke) 
og en eller flere godkjenninger. 
Programmet skal liste opp alle verkstedene i valgte fylket som har de valgte godkjenningene. 
