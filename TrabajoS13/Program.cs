//
//Chumbiauca Quispe , Maria Fernando
//Alarcon Pinao , Andre Adolfo
//Garcia Osorio , James Hgun Jair
//Casas , Fabian 
// 
using TrabajoS13;

Desayuno d = new Desayuno();
d.Nombre = "Continental";
d.Precio = 20.5;
d.Dias = "lun,mar,mie";

Console.WriteLine(d);

String[] lista = d.ListaDias();
foreach (string str in lista)
{
    Console.WriteLine(str);
}
