using System;
class Program
{
    static void Main()
    {
        //             --------- SALUDO DE BIENVENIDA, AVION Y MARCO --------

        int ancho = 60;
        // Imprimir borde superior
        Console.WriteLine("\n     ┌" + new string('─', ancho - 2) + "┐");




        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("                       :okOxoc:"); Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("                            * * *"); Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("                         :1x0XXK0kdlc:           :clc;;");
        Console.WriteLine("                           ;cokKNNNXKOxol:  :coxk0KXkc;");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("                              :cd0KNNNNXK0kk0KNNNX0xc; ");
        Console.WriteLine("                                 :lx0XNNNNNNNNK0xo: ");
        Console.WriteLine("                                 :ldOXNNNNNNKxl: ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("                   ;colc: ");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("    ;cox0KNNXXNNNNNk:; ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("                   ;ckK0kol");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("cok0XXKKOdodKNNNKo; ");
        Console.WriteLine("                    ;:o0XXKKKKOxolk  :l0NNNOc; ");
        Console.WriteLine("                    :coOKXNKdc       :l0NNKd; ");
        Console.WriteLine("                      :lllONOc       :l0NNOc; ");
        Console.WriteLine("                        :xXk::       :lKNXd: ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("                        ;col::       :l0N0l; ");
        Console.WriteLine("                          ::::       :lOOo: ");
        Console.WriteLine("                                       OO: ");
        Console.ResetColor();
        Console.WriteLine("\n        \"Bienvenidos a AERO EXPRESS tu mejor forma de viajar\" ");
        Console.WriteLine("\n                       Gracias por elegirnos");
        // Imprimir borde inferior
        Console.WriteLine("     └" + new string('─', ancho - 2) + "┘");
        Console.Write("\n\n\n\n      Presione cualquier tecla para continuar: ");
        Console.ReadKey();
        Console.Clear();

        // FINAL DEL SALUDO 


        // ---------------    INICIO DE CHECK-IN     ----------------


        Console.WriteLine("\n         CHECK-IN DEL PASAJERO");


        Console.ForegroundColor = ConsoleColor.Cyan;//Elijo color de letra
        Console.Write("\n Nombre y Apellido: "); //Dato de usuario: nombre y apellido
        Console.ResetColor();//reseteo el color de letra
        string nombre = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("\n DNI: "); Console.ResetColor(); //Dato de usuario: dni
        string dni = Console.ReadLine();

        // 2)_ Los menores de entre 2 y 5 años no cumplidos deberán viajar obligatoriamente
        // acompañados por sus padres o responsable a cargo mayor de 18 años en la misma
        // cabina y en asientos contiguos. En ese caso solicitar el dni del adulto acompañante.

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("\n Edad: "); Console.ResetColor(); //Dato de usuario: edad
        int edad = int.Parse(Console.ReadLine());
        string acompañante = "";
        if (edad < 5)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("\n Los menores de 2 y 5 años no cumplidos viajan obligatoriamente acompañados. ");
            Console.Write("\n DNI del adulto acompañante: "); Console.ResetColor();
            acompañante = Console.ReadLine();
        }

        // 3)_ Los menores de entre 5  y 11 años cumplidos al momento de inicio del viaje,
        // podrán viajar solos, utilizando el Servicio de Menor No Acompañado; consultar en ese
        // caso si se solicita ese servicio y si no, solicitar el dni del adulto responsable. 
        String menor_acompañado = "";
        string adulto = "";
        if (edad >= 5 && edad <= 11)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n Los menores de entre 5  y 11 años cumplidos" +
                " podrán viajar solos\n utilizando el Servicio de Menor No Acompañado. "
                + "\n\n Desea el servicio de Menor acompañado(SI, NO): "); Console.ResetColor();
            menor_acompañado = Console.ReadLine().ToLower();

            if (menor_acompañado == "no")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n DNI del Adulto responsable: "); Console.ResetColor();
                adulto = Console.ReadLine();
            }
        }

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("\n Destino: "); Console.ResetColor(); //Dato de usuario: destino
        string destino = Console.ReadLine();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("\n Clase Economica(1), Ejecutiva(2)," + //Dato de usuario: clase econo,ejucutiva,primera
            " Primera Clase(3): "); Console.ResetColor();
        int clase = int.Parse(Console.ReadLine());

        // 4)_ Si el usuario posee equipaje de mano, solicitar la cantidad. Si son más de 3,
        // se debe mostrar un mensaje indicando que excede la cantidad permitida por pasajero.

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("\n Posee equipaje de mano (SI, NO): "); Console.ResetColor();
        string equipaje = Console.ReadLine().ToLower();

        int cantidad = 0;

        if (equipaje == "si")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n Ingrese la cantidad de equipaje (Maximo/3): "); Console.ResetColor();
            cantidad = int.Parse(Console.ReadLine());

            if (cantidad >= 4)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("\n Excede el limite de equipaje permitido."); Console.ResetColor();
            }
        }

        // 5)_ Si el usuario no posee el equipaje facturado, se debe solicitar el peso del mismo y consultar según
        // la siguiente tabla el peso permitido por valija en bodega por clase de vuelo. Si el peso total del equipaje
        // facturado excede el límite permitido, se debe indicar el precio correspondiente al peso adicional en kg.

        // *Económica: hasta 5kg, *Ejecutiva: hasta 10 kg , *Primera Clase: hasta 20 kg, *Precio por kg adicional: $10

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("\n Cuenta con el equipaje facturado en bodega (SI, NO): "); Console.ResetColor();
        string bodega = Console.ReadLine().ToLower();

        int limite = 0; int cantidad_mas = 0; int precio_adicional = 0;  //precio adicional, va al finalizar chekin.

        if (bodega == "no")
        {
            switch (clase)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n Para la clase Economica el limite es 5kg (Precio pór kg adicional: $10)." +
                        "\n\n Ingrese el pesaje: "); Console.ResetColor();
                    limite = int.Parse(Console.ReadLine());

                    if (limite > 5)
                    {
                        cantidad_mas = limite - 5; precio_adicional = (limite - 5) * 10;

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\n Usted lleva " + cantidad_mas + "kg superior al limite, al finalizar el chekin" +
                            " se le informara el costo adicional."); Console.ResetColor();
                    }
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n Para la clase Ejecutiva el limite es 10kg (Precio pór kg adicional: $10)." +
                        "\n\n Ingrese el pesaje: "); Console.ResetColor();
                    limite = int.Parse(Console.ReadLine());

                    if (limite > 10)
                    {
                        cantidad_mas = limite - 10; precio_adicional = (limite - 10) * 10;

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\n Usted lleva " + cantidad_mas + "kg superior al limite, al finalizar el chekin " +
                            "se le informara  el costo  adicional."); Console.ResetColor();
                    }
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("\n Para la Primera Clase el limite es 20kg (Precio pór kg adicional: $10)." +
                        "\n\n Ingrese el pesaje: "); Console.ResetColor();
                    limite = int.Parse(Console.ReadLine());

                    if (limite > 20)
                    {
                        cantidad_mas = limite - 20; precio_adicional = (limite - 20) * 10;

                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.WriteLine("\n Usted lleva " + cantidad_mas + "kg superior al limite, al finalizar el chekin " +
                            "se le informara el costo  adicional."); Console.ResetColor();
                    }
                    break;
            }
        }
        // 6)_ Si viaja con un perro de servicio, verificar que el perro esté debidamente identificado
        //con su chaleco o distintivo de servicio y que trae un accesorio o correa para asegurarlo
        //con el cinturón de seguridad.

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write("\n Viaja con perro de servicio (SI, NO): "); Console.ResetColor();
        string perro = Console.ReadLine().ToLower();

        string perro_indentificado = "";
        string raza = "";
        string nombre_perro = "";
        string edad_perro = "";
        string chaleco = "";
        string correa = "";

        if (perro == "si")
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\n Se encuentra devidamente identificado (SI, NO): "); Console.ResetColor();
            perro_indentificado = Console.ReadLine().ToLower();

            if (perro_indentificado == "no")
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n Raza de perro: "); Console.ResetColor();
                raza = Console.ReadLine().ToLower();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n Nombre del perro: "); Console.ResetColor();
                nombre_perro = Console.ReadLine().ToLower();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n Edad del perro: "); Console.ResetColor();
                edad_perro = Console.ReadLine().ToLower();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n Cuenta con con su chaleco o distintivo de servicio (SI, NO): "); Console.ResetColor();
                chaleco = Console.ReadLine().ToLower();

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("\n Cuenta con correa para asegurarlo con el cinturón de seguridad (SI, NO): "); Console.ResetColor();
                correa = Console.ReadLine().ToLower();
            }
        }
        // 7)_ Al finalizar el proceso, mostrar por pantalla los datos del usuario, número de tarjeta de embarque
        // (un código con dos letras seguido de 5 números, por ejemplo AF569821), junto con la fecha y hora de
        // emisión del mismo. También indicar si hay costo adicional a abonar por las valijas.

        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\n\n         CHECK-IN FINALIZADO"); Console.ResetColor();
        Console.Write("\n Precione tecla para continuar."); Console.ReadKey();
        Console.Clear();

        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine("\n          DATOS DEL PASAJERO"); Console.ResetColor();

        Console.WriteLine("\n Nombre y Apellido: " + nombre);
        Console.WriteLine("\n DNI: " + dni);
        Console.Write("\n Edad: " + edad);

        // EDAD MENOR DE 5

        if (edad < 5)
        {
            Console.WriteLine(" (Menor acompañado obligatoriamente, DNI adulto responsable: " + acompañante + ")");
        }

        // EDAD DE 5 A 11

        if (edad >= 5 && edad <= 11)
        {
            if (menor_acompañado == "si")
            {
                Console.WriteLine(" (Menor con  servicio de acompañante)");
            }
            if (menor_acompañado == "no")
            {
                Console.WriteLine(" (Menor con acompañante, DNI adulto responsable: " + adulto + ")");
            }
        }

        // EDAD PERMITIDA PARA VIAJAR

        if (edad >= 12 && edad < 18)
        {
            Console.WriteLine(" (Menor de edad, edad permitida para viajar solo)");
        }
        if (edad >= 18)
        {
            Console.WriteLine(" (Adulto)");
        }

        // DESTINO

        Console.Write("\n Destino: " + destino + "\n");

        // CLASE, ECONOMICA., EJECUTIVA., PRIMERA CLASE

        if (clase == 1)
        {
            Console.WriteLine("\n Clase: Economica");
        }
        else if (clase == 2)
        {
            Console.WriteLine("\n Clase: Ejecutiva");
        }
        else if (clase == 3)
        {
            Console.WriteLine("\n Clase: Primera Clase");
        }

        // EQUIPAJE DE MANO

        if (equipaje == "si")
        {
            Console.Write("\n Equipaje de mano: " + equipaje);

            if (cantidad >= 4)
            {
                Console.WriteLine(", (excede el limite permitido).");
            }
            else if (cantidad < 4 && cantidad >= 1)
            {
                Console.WriteLine(", (limite permitido).");
            }
        }
        else if (equipaje == "no")
        {
            Console.WriteLine("\n Equipaje de mano: " + equipaje);

        }

        // EQUIPAJE DE BODEGA

        if (bodega == "si")
        {
            Console.WriteLine("\n Equipaje de bodega facturado anterior mente,(Costo Adicional): $" + precio_adicional);
        }
        else if (bodega == "no")
        {
            Console.WriteLine("\n" + " " + cantidad_mas + "kg superior al limite en equipaje de bodega,(Costo Adicional): $" + precio_adicional);
        }

        // PERRO

        if (perro == "no")
        {
            Console.Write("\n Perro de servicio: " + perro);
        }
        else if (perro == "si")
        {
            if (perro_indentificado == "si")
            {
                Console.WriteLine("\n perro de servicio: si, (identificado correctamente anteriormente).");
            }
            else if (perro_indentificado == "no")
            {
                Console.WriteLine("\n Raza de perro: " + raza);
                Console.WriteLine("\n Nombre del perro: " + nombre_perro);
                Console.WriteLine("\n Edad del perro: " + edad_perro);
                if (chaleco == "no")
                {
                    Console.WriteLine("\n Chaleco o distintivo de servicio: no, (se le suministrara uno)");
                }
                else
                {
                    Console.WriteLine("\n Chaleco o distintivo de servicio: si.");
                }

                if (correa == "no")
                {
                    Console.WriteLine("\n Cuenta con correa: no, (se le suministrara uno)");
                }
                else
                {
                    Console.WriteLine("\n Cuenta con correa: si.");

                }
            }

        }

        // TARJETA DE EMBARQUE

        Random rando = new Random();
        char letra_Uno = (char)rando.Next('A', 'Z' + 1);
        char letra_Dos = (char)rando.Next('A', 'Z' + 1);
        int numero1 = rando.Next(0, 10);
        int numero2 = rando.Next(0, 10);
        int numero3 = rando.Next(0, 10);
        int numero4 = rando.Next(0, 10);
        int numero5 = rando.Next(0, 10);

        DateTime hora = DateTime.Now;

        Console.WriteLine("\n Numero de tarjeta de embarque: " + letra_Uno + letra_Dos + numero1 + numero2 + numero3 + numero4 + numero5
            + " | Dia y Hora: " + hora.ToString());

        Console.Write("\n\n Presione cualquier tecla para finalizar: ");
        Console.ReadKey();
        Console.Clear();

        //  SALUDO FINAL

        Console.Write("\n   Que tenga un excelente viaje a ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.Write(destino); Console.ResetColor();
        Console.Write(" muchas gracias por elejirnos");


        Console.Write("\n\n\n                                  AERO ");
        Console.ForegroundColor = ConsoleColor.Cyan;
        Console.WriteLine(" EXPRESS"); Console.ResetColor();
        Console.ForegroundColor = ConsoleColor.DarkYellow;
        Console.WriteLine("                                      * * *"); Console.ResetColor();

        Console.WriteLine("\n\n\n\n\n\n\n\n\n");

    }
}