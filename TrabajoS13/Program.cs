
using TrabajoS13;

Desayuno dd = new Desayuno();
dd.Nombre = "Continental";
dd.Precio = 20.5;
dd.Dias = "lun,mar,mie";

Console.WriteLine(dd);

String[] lista = dd.ListaDias();
foreach (string str in lista)
{
    Console.WriteLine(str);
}