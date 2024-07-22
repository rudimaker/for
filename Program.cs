



// Konsol ekranına 10 kere "Kendime inanıyorum, ben bu yazılım işini hallederim!" yazdırınız.

for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}

//  1 ile 20 arasındaki sayıları konsol ekranına yazdırınız.

for (int i = 2; i < 20; i++)
{
    Console.WriteLine(i);
}

//  1 ile 20 arasındaki çift sayıları konsol ekranına yazdırınız.

for (int i = 1; i < 20; i++)
{
    if(i%2==0)
    {
        Console.WriteLine(i);
    }   
}

//  50 ile 150 arasındaki sayıların toplamını ekrana yazdırınız.

int toplam = 0;

for (int i = 50; i <= 150; i++)
{
    toplam=toplam+i;
   
}
Console.WriteLine(toplam);

//  1 ile 120 arasındaki tek ve çift sayıların toplamlarını ayrı ayrı ekrana yazdırınız.

int toplamtek = 0;
int toplamcift = 0;

for (int i = 1; i <= 120; i++)
{
    if (i % 2 == 0)
    {
        toplamcift += i;
    }


    if (i % 2 == 1)
    {
        toplamtek += i;
    }
}
Console.WriteLine(toplamcift);
Console.WriteLine(toplamtek);