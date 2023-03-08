string [,] ucs = new string [2, 3];
string pesquisar = "";
int l, c;
double numero, cargah;

l = 0;
c = 0;
numero = 0;
cargah = 0;

for (l = 0; l <= 1; l++)
{
    Console.WriteLine("Informe NÚMERO da UC: ");
    ucs[l, c++] = Console.ReadLine();
    Console.WriteLine("DESCRIÇÃO da UC: ");
    ucs[l, c++] = Console.ReadLine();
    Console.WriteLine("Informe a CARGA HORÁRIA: ");
    ucs[l, c++] = Console.ReadLine();

    c = 0;
}



switch (pesquisar)
{
    case 1:
        for (l = 0; l <= 1; l++)
        {
            Console.WriteLine("Informe a UC que deseja pesquisar:");
            pesquisar = Console.ReadLine();
            if (pesquisar == ucs)
            {

            }
        }
        break;

}



