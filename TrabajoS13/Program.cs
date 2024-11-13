using System.Drawing;
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
int menu_number, desayuno_length = 0, desayuno2_length = 0, elim=0;
string[] desayuno = new string[desayuno_length];//creacion de array
do //Bucle del menú
{
    do
    {
        Console.Clear();
        Console.WriteLine("MENÚ:");
        Console.WriteLine("1. Cantidad de alimentos");
        Console.WriteLine("2. Crear: crea desayuno");
        Console.WriteLine("3. Lista: muestra los desayunos disponibles");
        Console.WriteLine("4. Elimina: elimina un desayuno");
        Console.WriteLine("5. Salir");
        Console.Write("Seleccione una opción: ");
        string valor = Console.ReadLine();
        if (int.TryParse(valor, out menu_number)) ;
    } while (false);
    switch (menu_number) //Ingresar a las opciones del menú
    {
        case 1: //Menú de array numérico
            Console.Clear();
            Console.WriteLine("Lista de desayunos creada");
            Console.WriteLine("Inserte la cantidad de desayunos que desea para su lista:");
            desayuno_length = int.Parse(Console.ReadLine());
            Array.Resize(ref desayuno, desayuno_length);
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            break;
        case 2:
            Console.Clear();
            for (int i=0; i<desayuno.Length; i++)
            {
                Console.WriteLine($"Inserte qué valores quiere almacenar en el {i + 1}° espacio:");
                desayuno[i] = Console.ReadLine();
            }
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            break;
        case 3:
            Console.Clear();
            Console.WriteLine("Aquí se muestran los valores ingresados con su ubicación:");
            for (int i = 0; i < desayuno.Length; i++)
            {
                Console.WriteLine($"Ubicación: {i} --> Valor: {desayuno[i]}"); //Mostrar valores del array
            }
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            break;
        case 4:
                Console.Clear();
                Console.WriteLine("¿Qué elemento desea eliminar?");
                Console.Write("Inserte el nombre del desayuno: ");
                string nombre_desayuno = Console.ReadLine();
                if (Array.Exists(desayuno, element => element == nombre_desayuno))
                {
                    elim = Array.IndexOf(desayuno, nombre_desayuno);
                    string[] desayuno2 = new string[desayuno_length];//creacion de array 
                    desayuno2 = desayuno; 
                    desayuno2_length = desayuno_length - 1;
                    Array.Resize(ref desayuno, desayuno2_length);
                    for (int i = 0, i2 = 0; i2 < desayuno2.Length; i2++)
                    {
                        if (i2 != elim)
                        {
                            desayuno[i] = desayuno2[i2];
                            i++;
                        }
                        else { }
                    }
                    desayuno_length = desayuno2_length;
                    Console.WriteLine($"Se eliminó la posición {elim}, es decir el {elim + 1}° elemento");
                    Console.WriteLine("Presione cualquier tecla para continuar");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Elemento no encontrado");
                    Console.WriteLine("");
                    Console.WriteLine("Presione cualquier tecla para continuar");
                    Console.ReadKey();
                }
            break;
        case 5: //Salir del programa
            Console.Clear();
            Console.WriteLine("Terminó el programa");
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
            break;
        default:
            Console.Clear();
            Console.WriteLine("Error. Valor no válido ultimo");
            Console.WriteLine("");
            Console.WriteLine("Presione cualquier tecla para continuar");
            Console.ReadKey();
                break;
    }
} while (menu_number != 5) ;