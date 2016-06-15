using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen
{
    class Program
    {
        static int option = 0;
        static int i = 0;
        static int size = 5;
        static int size2;
        static string fri = "Frituras";
        static string repo = "Repostería";
        static string refre = "Refrescos gaseosos";
        static string refrenatu = "Refrescos naturales";
        static string conf = "Confitería";
        static string name = "";
        static string phone = "";
        static int total = 0;

        static int cont1 = 0;
        static int cont2 = 0;
        static int cont3 = 0;
        static int cont4 = 0;
        static int cont5 = 0;
        static int cont6 = 0;
        static int cont7 = 0;
        static int cont8 = 0;
        static int cont9 = 0;
        static int cont10 = 0;

        static int nivel1 = 1;
        static int nivel2 = 2;
        static int nivel3 = 3;
        static int nivel4 = 4;
        static int nivel5 = 5;
        static int precio1 = 100;
        static int precio2 = 200;
        static int precio3 = 500;
        static int precio4 = 1000;
        static int precio5 = 1500;







        struct list
        {
            public int codigo;
            public string nombre;
            public string tipo;
            public string fecha;
            public string nomproveedor;
            public double posicion;
            public double precio;
            public double descuento;



        };




        static list[] lists;





        static void agregar()
        {

            int r = 0;

            while (r != 1)
            {
                Console.Clear();
                if (i < lists.Length)
                {
                    Console.WriteLine("*-* Global Machines *_*");
                    Console.WriteLine("Ingreso de Productos.  ");
                    Console.WriteLine();
                    Console.Write("Digite el código del producto:                  ");
                    lists[i].codigo = int.Parse(Console.ReadLine());
                    Console.Write("Digite el nombre del artículo:   ");
                    lists[i].nombre = Console.ReadLine();
                    Console.Write("Tipo:  ");
                    Console.WriteLine();
                    Console.Write(" 1. Frituras. \n");
                    Console.Write(" 2. Repostería.\n");
                    Console.Write(" 3. Refrescos gaseosos.\n");
                    Console.Write(" 4. Refrescos naturales.\n");
                    Console.Write(" 5. Confitería.\n");
                    lists[i].tipo = Console.ReadLine();
                    if (lists[i].tipo == fri)
                    {
                        cont1++;

                    }
                    if (lists[i].tipo == repo)
                    {
                        cont2++;
                    }
                    if (lists[i].tipo == refre)
                    {
                        cont3++;
                    }
                    if (lists[i].tipo == refrenatu)
                    {
                        cont4++;
                    }
                    if (lists[i].tipo == conf)
                    {
                        cont5++;
                    }

                    Console.Write("Ingrese la fecha de vencimiento: ");
                    lists[i].fecha = Console.ReadLine();

                    Console.Write("Nombre de proveedor: ");
                    lists[i].nomproveedor = Console.ReadLine();
                    Console.Write("Ingrese la posición en el estante: ");
                    Console.WriteLine();

                    Console.Write(" 1. Nivel 1\n");
                    Console.Write(" 2. Nivel 2\n");
                    Console.Write(" 3. Nivel 3\n");
                    Console.Write(" 4. Nivel 4\n");
                    Console.Write(" 5. Nivel 5\n");
                    lists[i].posicion = int.Parse(Console.ReadLine());
                    if (lists[i].posicion == nivel1)
                    {
                        cont6++;

                    }
                    if (lists[i].posicion == nivel2)
                    {
                        cont7++;
                    }
                    if (lists[i].posicion == nivel3)
                    {
                        cont8++;
                    }
                    if (lists[i].posicion == nivel4)
                    {
                        cont9++;
                    }
                    if (lists[i].posicion == nivel5)
                    {
                        cont10++;
                    }

                    Console.Write("Ingrese el precio del producto: ");

                    Console.WriteLine();

                    Console.Write(" 1. 100\n");
                    Console.Write(" 2. 200 \n");
                    Console.Write(" 3. 500 \n");
                    Console.Write(" 4. 1000 \n");
                    Console.Write(" 5. 1500 \n");
                    lists[i].precio = int.Parse(Console.ReadLine());




                    Console.WriteLine("Desea agregar otro producto 0-Sí 1-No");
                    r = int.Parse(Console.ReadLine());
                    i++;


                }
                else
                {

                    {
                        Console.WriteLine("Registro de productos lleno...");
                        r = 1;
                        Console.ReadKey();
                    }
                }
            }
        }

        static void venta()
        {
            int cont = 0;
            int reg = 0;
            Console.Clear();
            Console.WriteLine("*-* Gobal Machines *-*");
            Console.WriteLine("Digite su nombre por favor: ");//pide al usuario que digite el nombre
            name = Console.ReadLine();//lee el nombre
            Console.WriteLine("Digite su número teléfonico por favor:");//pide al usuario el # de telefono.
            phone = Console.ReadLine();//lee el telefono

            Console.WriteLine("                                          " + "Global Machines");


            Console.WriteLine("======================================================================================\n" +

                                                "                              " + "Selección de productos\n" +
                           "=====================================================================================");
            Console.WriteLine(" ");


            Console.WriteLine(" ");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            Console.WriteLine(" ");
            Console.WriteLine("Nombre   ||   Precio ");
            Console.WriteLine("----------------------------------------------------------------------------------------");
            for (i = 0; i < lists.Length; i++)
            {
                reg = i + 1;
                Console.WriteLine(reg + "         " + lists[i].nombre + "        " + lists[i].precio);
            }

            Console.WriteLine("=====================================================================================");
            Console.ReadKey();

            Console.WriteLine();
            Console.WriteLine("Seleccione el producto que desea comprar");

        }





        static void muestralistado()
        {
            int reg = 0;
            if (lists.Length == 0)
            {
                Console.WriteLine("Por favor ingresar productos");
                Console.WriteLine("Presione la tecla INTRO para volver al menú");

                Console.ReadKey();

            }
            else
            {

                Console.Clear();
                Console.WriteLine("                                          " + "Global Machines");


                Console.WriteLine("======================================================================================\n" +

                                                    "                                 " + "Listado de productos\n" +
                               "=====================================================================================");
                Console.WriteLine(" ");

                Console.WriteLine(" ");
                Console.WriteLine("----------------------------------------------------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Reg       Código       Nombre      Tipo       Vencimiento    Proveedor      Posición    Precio    ");
                for (i = 0; i < lists.Length; i++)
                {
                    reg = i + 1;
                    Console.WriteLine(reg + "         " + lists[i].codigo + "        " + lists[i].nombre + "        " + lists[i].tipo + "       " + lists[i].fecha + "          " + lists[i].nomproveedor + "          " + lists[i].posicion + "        " + lists[i].precio);
                }
                Console.WriteLine(" ");
                Console.WriteLine("=====================================================================================");
                Console.WriteLine("Fin de listado");
                Console.WriteLine();



                Console.WriteLine("                                          " + "Global Machines");


                Console.WriteLine("======================================================================================\n" +

                                                    "                                 " + "Listado de productos\n" +
                               "=====================================================================================");
                Console.WriteLine(" ");


                Console.WriteLine(" ");
                Console.WriteLine("----------------------------------------------------------------------------------------");
                Console.WriteLine(" ");
                Console.WriteLine("Clasificación    ||   Cantidad ");
                Console.WriteLine("----------------------------------------------------------------------------------------");
                Console.WriteLine("Frituras " + "        " + "||" + "     " + cont1);
                Console.WriteLine("Repostería " + "      " + "||" + "     " + cont2);
                Console.WriteLine("Gaseosas   " + "      " + "||" + "     " + cont3);
                Console.WriteLine("Naturales " + "       " + "||" + "     " + cont4);
                Console.WriteLine("Confitería: " + "     " + "||" + "     " + cont5);
                Console.WriteLine("----------------------------------------------------------------------------------------");
                Console.WriteLine("Nivel            ||   Cantidad ");
                Console.WriteLine("1 " + "               " + "||" + "      " + cont6);
                Console.WriteLine("2 " + "               " + "||" + "      " + cont7);
                Console.WriteLine("3   " + "             " + "||" + "      " + cont8);
                Console.WriteLine("4 " + "               " + "||" + "      " + cont9);
                Console.WriteLine("5 " + "               " + "||" + "      " + cont10);

                Console.WriteLine(" ");
                Console.WriteLine("=====================================================================================");
                Console.WriteLine("Fin del informe");

                Console.WriteLine("Presione la tecla INTRO para volver al menú");

                Console.ReadKey();
            }
        }


        static void busquedaproducto()
        {

            int Code = 0;
            int reg = 0;
            int r = 0;
            bool found = false;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("*-* Global Machines *_*");
                Console.WriteLine("Búsquedad de productos           ");
                Console.WriteLine("Digite el código del producto a buscar");
                Code = int.Parse(Console.ReadLine());
                for (i = 0; i < lists.Length; i++)
                {
                    if (Code == lists[i].codigo)
                    {
                        reg = i + 1;
                        Console.WriteLine("Registro: " + reg);
                        Console.WriteLine("Código del artículo:   " + lists[i].codigo);
                        Console.WriteLine("Nombre del artículo:   " + lists[i].nombre);
                        Console.WriteLine("Tipo:  " + lists[i].tipo);
                        Console.WriteLine("Fecha de vencimiento:   " + lists[i].fecha);
                        Console.WriteLine("Nombre del proveedor:   " + lists[i].nomproveedor);
                        Console.WriteLine("Posición en estante:   " + lists[i].posicion);
                        Console.WriteLine("Precio:   " + lists[i].precio);
                        Console.WriteLine("Descuento:   " + lists[i].descuento);
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese código");
                    found = false;
                }
                Console.WriteLine("Desea buscar otro producto 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
            }
        }

        static void modifydata()
        {

            int option = 0;
            int user = 0;
            int r = 0;
            bool found = false;

            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("*_* Global Machines");
                Console.WriteLine("Modificación de Productos");
                Console.WriteLine("Digite el código del producto a buscar: ");
                user = int.Parse(Console.ReadLine());
                for (i = 0; i < lists.Length; i++)
                {
                    if (user == lists[i].codigo)
                    {
                        do

                        {
                            Console.Clear();
                            Console.WriteLine("Ingrese la opcion que desea cambiar");
                            Console.WriteLine("1.Nombre del artículo");
                            Console.WriteLine("2.Tipo");
                            Console.WriteLine("3.Fecha de vencimiento");
                            Console.WriteLine("4.Nombre del proveedor");
                            Console.WriteLine("5.Posicion en el estante");
                            Console.WriteLine("6.Precio");
                            Console.WriteLine("7.Descuentos");

                            Console.WriteLine("8.Actuales modificaciones");


                            Console.WriteLine("9.Salir");
                            option = int.Parse(Console.ReadLine());
                            switch (option)
                            {
                                case 1:
                                    Console.Clear();
                                    Console.WriteLine("Digite el nuevo nombre del artículo");
                                    lists[i].nombre = Console.ReadLine();
                                    break;
                                case 2:
                                    Console.Clear();
                                    Console.Write("Tipo:  ");
                                    Console.WriteLine();
                                    Console.Write(" 1. Frituras. \n");
                                    Console.Write(" 2. Repostería.\n");
                                    Console.Write(" 3. Refrescos gaseosos.\n");
                                    Console.Write(" 4. Refrescos naturales.\n");
                                    Console.Write(" 5. Confitería.\n");
                                    lists[i].tipo = Console.ReadLine();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Console.Write("Ingrese la fecha de vencimiento:");
                                    lists[i].fecha = Console.ReadLine();

                                    break;
                                case 4:

                                    Console.Clear();
                                    Console.Write("Nombre de proveedor: ");
                                    lists[i].nomproveedor = Console.ReadLine();

                                    break;
                                case 5:
                                    Console.Clear();
                                    Console.Write("Ingrese la posición en el estante: ");
                                    Console.WriteLine();

                                    Console.Write(" 1. Nivel 1\n");
                                    Console.Write(" 2. Nivel 2\n");
                                    Console.Write(" 3. Nivel 3\n");
                                    Console.Write(" 4. Nivel 4\n");
                                    Console.Write(" 5. Nivel 5\n");
                                    lists[i].posicion = int.Parse(Console.ReadLine());


                                    break;
                                case 6:
                                    Console.Clear();
                                    Console.Write("Ingrese el precio del producto: ");
                                    lists[i].precio = int.Parse(Console.ReadLine());
                                    break;
                                case 7:
                                    Console.Clear();
                                    Console.WriteLine("Ingrese el descuento del producto");
                                    lists[i].descuento = int.Parse(Console.ReadLine());


                                    break;
                                case 8:
                                    Console.Clear();
                                    Console.WriteLine("Actuales Modificaciones");
                                    if (user == lists[i].codigo)
                                    {

                                        Console.WriteLine("Código del artículo:   " + lists[i].codigo);
                                        Console.WriteLine("Nombre del artículo:   " + lists[i].nombre);
                                        Console.WriteLine("Tipo:  " + lists[i].tipo);
                                        Console.WriteLine("Fecha de vencimiento:   " + lists[i].fecha);
                                        Console.WriteLine("Nombre del proveedor:   " + lists[i].nomproveedor);
                                        Console.WriteLine("Posición en estante:   " + lists[i].posicion);
                                        Console.WriteLine("Precio:   " + lists[i].precio);
                                        Console.WriteLine("Descuento:   " + lists[i].descuento);



                                    }
                                    Console.WriteLine("Desea realizar otro cambio 0-Sí 1-No");
                                    r = int.Parse(Console.ReadLine());
                                    break;
                                case 9:
                                    break;
                            }

                        } while (option != 9);
                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese ID");
                    found = false;
                }
                Console.WriteLine("Desea buscar otro producto 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());
            }
        }

        static void deletdata()
        {
            int codigo = 0;
            int reg = 0;
            int r = 0;
            bool found = false;
            while (r != 1)
            {
                Console.Clear();
                Console.WriteLine("*_* Global Machines");
                Console.WriteLine("Digite el código del producto que desea borrar");
                codigo = int.Parse(Console.ReadLine());
                for (i = 0; i < lists.Length; i++)
                {
                    if (codigo == lists[i].codigo)
                    {
                        Console.Clear();

                        reg = i + 1;
                        reg = 0;
                        lists[i].codigo = 0;
                        lists[i].nombre = "";
                        lists[i].tipo = "";
                        lists[i].fecha = "";
                        lists[i].nomproveedor = "";
                        lists[i].posicion = 0;
                        lists[i].precio = 0;
                        lists[i].descuento = 0;



                        found = true;
                    }
                }
                if (!found)
                {
                    Console.WriteLine("No se encontro ese ID");
                    found = false;
                }
                Console.WriteLine("Desea borrar otro producto 0-Sí 1-No");
                r = int.Parse(Console.ReadLine());


            }
        }

        static void Main(string[] args)
        {
            do
            {
                Console.Clear();
                Console.WriteLine("Digite la cantidad de prodcutos a ingresar");
                size2 = int.Parse(Console.ReadLine());

                if (size2 < size)
                {
                    Console.Clear();
                    Console.WriteLine("Digite minimo 5 productos");
                    Console.WriteLine("Presione la tecla INTRO para volver a ingresar el número de estudiantes");

                    Console.ReadKey();


                }

                else
                {


                    lists = new list[size2];
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("*_* Global Machines *_*");
                        Console.WriteLine("Menú Principal");
                        Console.WriteLine("1. Ingreso de Productos.");
                        Console.WriteLine("2. Modificación de Productos.");
                        Console.WriteLine("3. Eliminación de productos.");
                        Console.WriteLine("4. Búsquedad de productos.");
                        Console.WriteLine("5. Listado de productos.");
                        Console.WriteLine("6. Venta de productos.");
                        Console.WriteLine("7. Salir.");
                        Console.WriteLine("Selecciones una opción");
                        option = int.Parse(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                {
                                    agregar();
                                    break;
                                }
                            case 2:
                                {
                                    modifydata();
                                    break;
                                }
                            case 3:
                                {
                                    deletdata();
                                    break;
                                }
                            case 4:
                                {
                                    busquedaproducto();
                                    break;
                                }
                            case 5:
                                {
                                    muestralistado();
                                    break;
                                }
                            case 6:
                                {
                                    venta();
                                    break;
                                }
                            case 7:

                                break;
                            default:
                                {
                                    Console.WriteLine("Seleccione inválida..");
                                    Console.ReadKey();
                                    Console.Clear();
                                    break;
                                }
                        }

                    } while (size2 >= size && option != 7);
                }
            } while (option != 7);
        }
    }
}


