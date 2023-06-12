// See https://aka.ms/new-console-template for more information
/* Tehtävä1
 * Luo ohjelma, joka luo kokonaislukumuuttujan 
 * nimeltä "ika" ja antaa sille arvoksi 25. 
 * Näytä muuttujan arvo konsolissa.
 
int ika = 25;
Console.WriteLine(ika);
Console.WriteLine("Ikä = " + ika);

/*Tehtävä2
 * Luo ohjelma, joka luo merkkijonomuuttujan nimeltä "nimi" ja antaa sille oman nimesi. 
 * Näytä muuttujan arvo konsolissa.
*/
String nimi = "Pekka";
Console.WriteLine(nimi);
Console.WriteLine("Nimesi = " + nimi);

/*Tehtävä3
 * Luo ohjelma, joka luo kaksi kokonaislukumuuttujaa, 
 * "luku1" ja "luku2", ja antaa niille eri arvot. 
 * Suorita yhteen-, vähennys-, kerto- ja jakolaskut 
 * käyttäen näitä muuttujia ja näytä tulokset konsolissa.
 */
int luku1=5;
int luku2=2;
int tulos;

tulos=luku1 + luku2;
Console.WriteLine("Lukujen "+luku1+" ja "+luku2+" summa = "+tulos);

tulos = luku1 - luku2;
Console.WriteLine("Lukujen " + luku1 + " ja " + luku2 + " erotus = " + tulos);

tulos = luku1 * luku2;
Console.WriteLine("Lukujen " + luku1 + " ja " + luku2 + " tulo = " + tulos);

float osam = (float)luku1 / (float)luku2;
Console.WriteLine("Lukujen " + luku1 + " ja " + luku2 + " osamäärä = " + osam);

/*Tehtävä4
 * Luo ohjelma, joka luo desimaalityyppisen vakion nimeltä "pi" 
 * ja antaa sille arvoksi 3.14159. Laske ympyrän pinta-ala, 
 * jonka säde on 5, kaavalla: ala = pi * säde * säde. Näytä tulos konsolissa.
 */
const double pi = 3.14159;
double ala = pi * 5 * 5;
Console.WriteLine("Ympyrän ala=" + ala);
Console.WriteLine("Ympyrän ala=" + Math.Round(ala,2) );

/*Tehtävä5
 * Luo ohjelma, joka pyytää käyttäjää syöttämään nimensä ja 
 * tallentaa sen merkkijonomuuttujaan nimeltä "kayttajaNimi". 
 * Näytä tervehdysviesti konsolissa, jossa käyttäjän nimi näkyy.
*/
Console.WriteLine("Anna nimesi");
String kayttajaNimi;
kayttajaNimi = Console.ReadLine();
Console.WriteLine("Tervehdys : "+kayttajaNimi);

/*Tehtävä6
Luo ohjelma, joka pyytää käyttäjää syöttämään kaksi lukua 
ja tallentaa ne kokonaislukumuuttujiin nimeltä "luku1" ja "luku2". 
Vaihda näiden muuttujien arvot keskenään 
käyttäen kolmatta muuttujaa ('apumuuttuja') ja näytä uudet arvot konsolissa
*/
//int luku1, luku2;
int apumuuttuja;
Console.WriteLine("Anna eka luku");
//jos annat vahingossa kirjaimen, niin seuraava rivi
//kaataa sovelluksen
//luku1=int.Parse(Console.ReadLine());
int.TryParse(Console.ReadLine(), out luku1);
Console.WriteLine("Anna toinen luku");
//luku2=int.Parse(Console.ReadLine());
int.TryParse(Console.ReadLine(), out luku2);
//TryParsen sijaan voisi käyttää myös try catch rakennetta

apumuuttuja = luku1;
luku1=luku2;
luku2 = apumuuttuja;
Console.WriteLine("Luvut ovat " + luku1 + " ja " + luku2);

//try-catch versio alkaa
try
{
    Console.WriteLine("Try-catch versio");
    Console.WriteLine("Anna eka luku");
    luku1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Anna toka luku");
    luku2 = int.Parse(Console.ReadLine());
    apumuuttuja = luku1;
    luku1 = luku2;
    luku2 = apumuuttuja;
    Console.WriteLine("Luvut ovat " + luku1 + " ja " + luku2);
}
catch (Exception ex)
{
    Console.WriteLine("Jokin meni vikaan");
    Console.WriteLine(ex.Message);
}

//try catch versio loppuu


/*Tehtävä7
 * Luo ohjelma, joka pyytää käyttäjää syöttämään kaksi lukua 
 * ja tallentaa ne kokonaislukumuuttujiin nimeltä "luku1" ja "luku2". 
 * Vaihda näiden muuttujien arvot keskenään ilman kolmatta muuttujaa 
 * ja näytä uudet arvot konsolissa.
*/
try
{
    Console.WriteLine("Ilman apumuuttuja");
    Console.WriteLine("Anna eka luku");
    luku1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Anna toka luku");
    luku2 = int.Parse(Console.ReadLine());
    luku1 = luku1 + luku2;
    luku2 = luku1-luku2;
    luku1 = luku1-luku2;
    Console.WriteLine("Luvut ovat " + luku1 + " ja " + luku2);
}
catch (Exception ex)
{
    Console.WriteLine("Jokin meni vikaan");
    Console.WriteLine(ex.Message);
}
/*Tehtävä8
 * Luo ohjelma, joka luo totuusarvomuuttujan nimeltä "onParillinen" 
 * ja antaa sille arvon true, jos annettu luku on parillinen, 
 * ja false muutoin. Pyydä käyttäjää syöttämään luku ja näytä 
 * konsolissa, onko luku parillinen vai ei.
 */
bool onParillinen;
int annettuLuku;
Console.WriteLine("Anna luku");
int.TryParse(Console.ReadLine(), out annettuLuku);
//Jakojäännös eli modulo on C# kielessä %
if (annettuLuku % 2 == 0)
{
    onParillinen = true;
}
else
{
    onParillinen = false;
}
if (onParillinen)
{
    Console.WriteLine("Luku on parillinen");
}
else
{
    Console.WriteLine("Luku on pariton");
}

/*Tehtävä9
 * Luo ohjelma, joka luo kokonaislukumuuttujan nimeltä "laskuri" 
 * ja antaa sille alkuarvoksi 0. Toteuta silmukka, joka lisää 
 * laskuri-muuttujaa yhdellä joka iteraatiossa. 
 * Näytä laskuri-muuttujan arvo konsolissa jokaisen iteraation 
 * jälkeen, kunnes laskuri on 10
 */
int laskuri = 0;
while (laskuri < 10)
{
    //kasvatetaan yhdellä
    laskuri++;
    Console.WriteLine(" laskuri = " + laskuri);
}
/*Tehtävä10
Luo ohjelma, joka laskee 10 ensimmäisen luonnollisen 
luvun (1+2+3+...+10) summan ja tallentaa sen 
kokonaislukumuuttujaan nimeltä "summa". 
Näytä summa-muuttujan arvo konsolissa.
 */
int summa = 0;
for(int luku=1; luku<=10; luku++)
{
    summa = summa+luku;
    // tai lyhyemmin
    //summa += luku;
    Console.WriteLine(luku+". nyt summa="+summa);
}
Console.WriteLine("Lukujen summa = " + summa);

/*Tehtävä11
 Luo ohjelma, joka pyytää käyttäjää syöttämään suorakulmion 
pituuden ja leveyden ja tallentaa ne kokonaislukumuuttujiin 
nimeltä "pituus" ja "leveys". Laske suorakulmion pinta-ala 
ja ympärysmitta näiden muuttujien avulla ja näytä tulokset konsolissa.
 */
int pituus, leveys;
int pintaAla, ymparysMitta;
Console.WriteLine("Anna suorakulmion pituus");
int.TryParse(Console.ReadLine(),out pituus);
Console.WriteLine("Anna suorakulmion leveys");
int.TryParse(Console.ReadLine(), out leveys);
pintaAla = pituus * leveys;
ymparysMitta = 2 * (pituus + leveys);
Console.WriteLine("Suorakulmion pinta-ala = " + pintaAla);
Console.WriteLine("Suorkulmion ympärysmitta = " + ymparysMitta);