/*int limit;
int sayac = 0;
Console.WriteLine("Ekrana yazdırılacak mesaj için bir limit belirleyiniz.");
limit = Convert.ToInt32(Console.ReadLine());
while(sayac < limit)
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayac++;
}

Console.WriteLine("--------------------------------------------------------------------");

*/


//While döngüsü döngüye girmeden önce sayac<limit koşulunu kontrol ediyor.Limit mesela 0 ise ya da negatif bir sayı ise döngünün içindeki yapıyı hiç çalıştırmıyor.

Console.WriteLine("Ekrana yazdırılacak mesaj için bir limit belirleyiniz.");
int limittt = Convert.ToInt32(Console.ReadLine());

int sayaccc = 0;
do
{
    Console.WriteLine("Ben bir Patika'lıyım");
    sayaccc++;


}
while (sayaccc < limittt);

//do-while döngüsünde ise koşulumuz en baştan sağlanmıyor olsa da koşulun içindeki döngüyü en az bir defa çalıştırıyor.