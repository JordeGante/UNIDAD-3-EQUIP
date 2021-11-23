class equipo1
{

    static float restaurante(float x, float y, float l, float m, float mesaDisponible, float mesaOcupada)
    {
        return (x * y * l * m * mesaDisponible * mesaOcupada);


    }

    static string reservacion(string status)
    {
        int mesaDisponible = 0;
        while (status != " no" && status != "si")
        {
            Console.Write("Ingresa el nombre de la persona quien reserva ");
            string nombreR = Console.ReadLine();
            Console.Write("Ingresa la Fecha de reservacion ");
            float fecha = float.Parse(Console.ReadLine());
            Console.Write("Ingresa el status de la reserva  si/no");
            if (status == "si")
            {
                Console.Write("Su mesa sera la " + mesaDisponible);
            }
            else if (status == "no")
            {
                Console.Write("No hay mesas disponibles favor de registrar las entradas mas tarde");
            }
        }
        return nombreR;
    }
    static string reservacion(string status)
    {
        string[] reservacion2 = { "mesa", "nombre: Armando", "status", "fecha" };
        string[] reservacion3 = { "mesa", "nombre: Jorman", "status", "fecha" };
        string[] reservacion4 = { "mesa", "nombre: Harvey", "status" };
        string[] reservacion5 = { "mesa", "nombre: Zamudio ", "status" };

        Console.WriteLine(
            "mesa: " + reservacion2[0] +
            "nombre: " + reservacion2[1] +
            "status: " + reservacion2[2] +
            "fecha: " + reservacion2[3]
            );
        Console.WriteLine( "mesa: " + reservacion3[0] +
            "nombre: " + reservacion3[1] +
            "status: " + reservacion3[2] +
            "fecha: " + reservacion3[3]
            );
        Console.WriteLine( "mesa: " + reservacion4[0] + 
            "nombre: " + reservacion4[1] +
            "status: " + reservacion4[2]
            );
        
    }
    }




