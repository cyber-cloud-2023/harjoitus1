// See https://aka.ms/new-console-template for more information
/* Tehtävä1
 * Luo ohjelma, joka luo kokonaislukumuuttujan 
 * nimeltä "ika" ja antaa sille arvoksi 25. 
 * Näytä muuttujan arvo konsolissa.
 */
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

float osam = luku1 / (float)luku2;
Console.WriteLine("Lukujen " + luku1 + " ja " + luku2 + " osamäärä = " + osam);