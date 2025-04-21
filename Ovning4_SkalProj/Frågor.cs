

#region Hur fungerar stacken och heapen? Förklara gärna med exempel eller skiss på dess grundläggande funktion?
// 

// Stack: används för att lagra lokala variabler och metodanrop.
// → Fungerar som en "skokartongstapel", där man alltid tar från toppen.
// → Rensas automatiskt när metoden avslutas.

//void MyMethod()
//{
//    int x = 5;  // Lagrad på stacken
//}

//// Heap: används för att lagra objekt (t.ex. instanser av klasser).
//// → Fungerar som en "tvätthög" – man kan nå alla delar direkt.
//// → Kräver Garbage Collector för att städa bort oanvända objekt.

//class MyClass
//{
//    public int number;
//}

//MyClass obj = new MyClass();  // Objektet lagras i heapen
#endregion

#region Vad är Value Types respektive Reference Types och vad skiljer dem åt?
// Value Types:
// → Lagrar själva värdet direkt
// → Ligger på stacken (om de deklareras i en metod)
// → Exempel: int, float, bool, struct

//int a = 5;
//int b = a;   // b får en KOPIA av värdet 5

// Reference Types:
// → Lagrar en pekare (referens) till objektet
// → Objektet ligger i heapen
// → Exempel: class, string, array, object

//MyClass c1 = new MyClass();
//MyClass c2 = c1;   // c2 pekar på samma objekt som c1

#endregion

#region Följande metoder (se bild nedan) genererar olika svar. Den första returnerar 3, den andra returnerar 4, varför?

//int x = new int();    x = 0
//x = 3;
//int y = new int();    y = 0
//y = x;                y = 3 (kopieras från x)
//y = 4;                y ändras → x påverkas inte
//return x;             x är fortfarande 3

//Metoden retunerar 3 eftersom int är en value type
// y = x skapar en kopia av värdet

//MyInt x = new MyInt();       MyInt är en klass = reference type
//x.MyValue = 3;
//MyInt y = new MyInt();
//y = x;                       y och x pekar på samma objekt
//y.MyValue = 4;               ändrar värdet i det gemensamma objektet
//return x.MyValue;            x.MyValue är nu 4!

//Metoden returnerar 4 eftersom MyInt är en reference type
//y = x gör att båda pekar på samma objekt i heapen
#endregion



