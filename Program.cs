string Utasnev="Márton Károly";
int Tavolsag=14;
bool Ejszaka=false;
int Alapdíj = 1100;
int kmDíj = 440;
double EjszakaSzorzo = 1.2;
//3.feladat
double alapertek = Alapdíj + (Tavolsag * kmDíj);
double osszesen = alapertek;
if (Ejszaka)
{
    osszesen = osszesen*EjszakaSzorzo;
}
Console.WriteLine("========================================");
Console.WriteLine($"Utas neve: {Utasnev}");
Console.WriteLine($"Megtett távolság: {Tavolsag} km");
Console.WriteLine($"Alapérték: {alapertek} Ft");
Console.WriteLine($"Fizetendő végösszeg: {osszesen} Ft");
if(Ejszaka) Console.WriteLine("Státusz: 20% éjszakai pótlék felszámolva.");
else Console.WriteLine("Státusz: Normál díj felszámolva.");
Console.WriteLine("========================================");
