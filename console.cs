using System;

namespace Superheroes
{

    class videojuego
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenido mi estimado");
            Console.Write("Ingrese Nombre del personaje: ");
            var nombre = Console.ReadLine();

            Console.Write("Ingrese la edad del personaje: ");
            string edad = Console.ReadLine();
            int edad1 = int.Parse(edad);

            Console.Write("Ingrese el  peso del personaje: ");
            float peso = float.Parse(Console.ReadLine());

            Console.Write("Ingrese el numero de personaje: ");
            int numero = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el numero de luchas del personaje: ");
            int numeroluchas = int.Parse(Console.ReadLine());

            Console.Write("Ingrese numero de trofeos del personaje: ");
            int numerotrofeos = int.Parse(Console.ReadLine());

            Console.Write("Ingrese su Color favorito de personaje: ");
            var colorfavorito = Console.ReadLine();


            Console.Write("Ingrese su tipo de escenario favorito: ");
            var escenario = Console.ReadLine();

            Console.Write("Ingrese habitat del personaje: ");
            var habitat = Console.ReadLine();


            Console.Write("Ingrese su transformacion favorita: ");
            var transformacion = Console.ReadLine();

            Console.Write("Ingrese Nombre del personaje mas fuerte del juego: ");
            var nombrepersonaje = Console.ReadLine();

            Console.Write("Ingrese el tipo de traje que utilizan en el espacio para luchar: ");
            var traje = Console.ReadLine();

            int nivel = 18;
            bool esMayordeEdadGohan = (nivel >= 18);
            Console.WriteLine(esMayordeEdadGohan);
            Console.ReadLine();

            Console.Write("Ingrese el año que se creo la saga de broly: ");
            int anio = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el nivel del ki de vegeta cuando se enoja: ");
            float niveles = float.Parse(Console.ReadLine());

            Console.Write("Ingrese Nombre de una pelea bien conocida: ");
            var pelea = Console.ReadLine();

            Console.Write("Ingrese Nombre de la super estrella de ciudad Satan: ");
            var superestrellas = Console.ReadLine();

            Console.Write("Ingrese Nombre del niño con mejor nivel de pelea: ");
            var niñoconmejornivel = Console.ReadLine();

            Console.Write("Ingrese Nombre del villano que enfrento goku en namekusei: ");
            var villanos = Console.ReadLine();

            Console.Write("Ingrese Nombre de la deidad de dragonball: ");
            var deidades = Console.ReadLine();

            Console.Write("Ingrese el numero de peleadores del torneo de la fuerza: ");
            int torneo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el numero de empleados de la corporacion capsula: ");
            int empleados = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el precio de una habilidad en el juego: ");
            float caseria = float.Parse(Console.ReadLine());

            Console.Write("Ingrese la fase mas poderosa del juego: ");
            int fase = int.Parse(Console.ReadLine());

            Console.Write("Ingrese Nombre de uno de los hijos de goku: ");
            var hijos = Console.ReadLine();

            Console.Write("Ingrese el nombre de la dueña de la corporacion capsula: ");
            var corporacion = Console.ReadLine();

            Console.Write("Ingrese el costo de una hora en el gimnasio de vegeta: ");
            float costo = float.Parse(Console.ReadLine());

            Console.Write("Ingrese el numero de minutos que se demora en una pelea online: ");
            int minutos = int.Parse(Console.ReadLine());


            Console.Write("Ingrese Nombre del amigo de kamisama: ");
            var amigo = Console.ReadLine();
            //metodo boleano
            int subida = 19;
            bool esMayordeEdadGoten = (subida >= 19);
            Console.WriteLine(esMayordeEdadGoten);
            Console.ReadLine();
            //metodo POW
            int potencias = 10;
            double elevadoAlCuadrado = Math.Pow(potencias, 2); // Elevarlo a la potencia 2 nivel de poder del jugador

            Console.Write("Ingrese su nivel del juego favorito: ");
            var juegos = Console.ReadLine();

            Console.Write("Ingrese el nombre del planeta donde nacio goku: ");
            var planeta = Console.ReadLine();

            Console.Write("Ingrese el nombre de la montaña de goku: ");
            var montaña = Console.ReadLine();

            Console.Write("Ingrese nombre  del hermano de goku: ");
            var hermano = Console.ReadLine();

            Console.Write("Ingrese el nivel mas dificil del juego: ");
            var dificil = Console.ReadLine();

            Console.Write("Ingrese el escenario con mas gravedad: ");
            var gravedad = Console.ReadLine();
            //pow
            int poderes = 12;
            double poder = Math.Pow(poderes, 2);
            //pow
            int potencial = 14;
            double elevado = Math.Pow(potencial, 2);
            //pow
            int magnitud = 16;
            double maximo = Math.Pow(magnitud, 2);
            //pow
            int alcanze = 18;
            double hit = Math.Pow(alcanze, 2);

            Console.Write("Ingrese el numero de victorias que ha obtenido bills: ");
            int victoria = int.Parse(Console.ReadLine());

            Console.Write("Ingrese cuanto pesan los equipos de entrenamiento en el videojuego: ");
            int equipos = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el precio de una maquina para regenerar a un personaje: ");
            float regenerar = float.Parse(Console.ReadLine());


            Console.Write("Ingrese cuanto cuestan los panes que goku se come: ");
            float panes = float.Parse(Console.ReadLine());

            Console.Write("Ingrese los tipos de trajes que hay en la corporacion: ");
            var tipos = Console.ReadLine();

            Console.Write("Ingrese nombre de un villano poderoso: ");
            var poderoso = Console.ReadLine();

            Console.Write("Ingrese cual es la nube que siempre acompaña a goku: ");
            var nube = Console.ReadLine();

            Console.Write("Ingrese Nombre de la hija de gohan: ");
            var hija = Console.ReadLine();

            //metodo boleano
            int niveldeki = 354;
            bool esMayorelkidebroly = (niveldeki >= 354);
            Console.WriteLine(esMayorelkidebroly);
            Console.ReadLine();
            //metodo POW
            int kielevacion = 210;
            double elevaciondekiactiva = Math.Pow(kielevacion, 2);



            var clase1 = new clase1
            {
                nombre = nombre,
                edad = edad1,
                peso = peso,
                numero = numero,
                numeroluchas = numeroluchas,
                numerotrofeos = numerotrofeos,
                colorfavorito = colorfavorito,
                escenario = escenario,
                habitat = habitat,
                transformacion = transformacion,
            };
            var clase2 = new clase2
            {
                nombrepersonaje = nombrepersonaje,
                traje = traje,
                anio = anio,
                niveles = niveles,
                pelea = pelea,
                superestrellas = superestrellas,
                niñoconmejornivel = niñoconmejornivel,
                villanos = villanos,
                deidades = deidades,
                //un campo de esta clase esta como boleano

            };
            var clase3 = new clase3
            {
                torneo = torneo,
                empleados = empleados,
                caseria = caseria,
                fase = fase,
                hijos = hijos,
                corporacion = corporacion,
                costo = costo,
                minutos = minutos,
                amigo = amigo,
                //un campo de esta clase esta como boleano

            };
            var clase4 = new clase4
            {

                juegos = juegos,
                planeta = planeta,
                montaña = montaña,
                hermano = hermano,
                dificil = dificil,
                gravedad = gravedad
                //los otros 5 campos estan con el metodo pow 

            };
            var clase5 = new clase5
            {
                victoria = victoria,
                equipos = equipos,
                regenerar = regenerar,
                panes = panes,
                tipos = tipos,
                poderoso = poderoso,
                nube = nube,
                hija = hija,
            };



            Console.WriteLine("Los datos del juego ingresados son: ");
            Console.WriteLine($"Nombre del personaje: {clase1.nombre}");
            Console.Write($"edad del personaje:  " + clase1.edad + "\n");
            Console.Write("peso del personaje: " + clase1.peso + "\n");
            Console.Write("su numero de personaje es: " + clase1.numero + "\n");
            Console.WriteLine("el numero de luchas del personaje  es: " + clase1.numeroluchas);
            Console.Write("el numero de trofeos del personaje es: " + clase1.numerotrofeos + "\n");
            Console.WriteLine("su color favorito de personaje es: " + clase1.colorfavorito);
            Console.WriteLine("su tipo de escenario favorito es: " + clase1.escenario);
            Console.WriteLine("el habitat del personaje es: " + clase1.habitat);
            Console.WriteLine("su transformacion favorita es: " + clase1.transformacion + "\n\n");
            Console.WriteLine($"el nombre del personaje mas fuerte es: {clase2.nombrepersonaje}");
            Console.WriteLine($"tipo de traje utilizado en el espacio para luchar: {clase2.traje}");
            Console.Write($"el año que se creo la saga de broly es:  " + clase2.anio + "\n");
            Console.Write("el nivel del ki de vegeta cuando se enoja es: " + clase2.niveles + "\n");
            Console.WriteLine($"el nombre de la pelea que conoce es: {clase2.pelea}");
            Console.WriteLine($"el nombre de la superestrella es: {clase2.superestrellas}");
            Console.WriteLine($"el niño  con mejor nivel es: {clase2.niñoconmejornivel}");
            Console.WriteLine($"el nombre del villano que enfrento goku en namekusei es: {clase2.villanos}");
            Console.WriteLine($"el nombre de la deidad es: " + clase2.deidades + "\n");
            Console.Write($"el numero de peleadores es: " + clase3.torneo + "\n");
            Console.Write("el numero de empleados es: " + clase3.empleados + "\n");
            Console.Write($"el precio de la habilidad es: " + clase3.caseria + "\n");
            Console.WriteLine($"la fase mas poderosa del juego es:  {clase3.fase} ");
            Console.WriteLine($"el nombre de uno de sus hijos es: {clase3.hijos}");
            Console.Write("el nombre de la dueña es: " + clase3.corporacion + "\n");
            Console.Write($"el costo de una hora es:  " + clase3.costo + "\n");
            Console.WriteLine($"el numero de minutos que demora la pelea online: {clase3.minutos}");
            Console.Write($"se llama: " + clase3.amigo + "\n");
            Console.WriteLine(string.Format("{0} el nivel de pelea de trunks es {1}", numero, elevadoAlCuadrado));
            Console.WriteLine("el nivel de juego favorito es: " + clase4.juegos);
            Console.WriteLine("el nombre del platena es: " + clase4.planeta);
            Console.WriteLine("el nombre de la montaña es: " + clase4.montaña);
            Console.WriteLine("el nombre del hermano es : " + clase4.hermano);
            Console.WriteLine("el nivel mas dificil es: " + clase4.dificil);
            Console.WriteLine("el escenario con mas gravedad es: " + clase4.gravedad);
            Console.WriteLine(string.Format("{0} el nivel de pelea de trunks es: {1}", numero, poder));
            Console.WriteLine(string.Format("{0} el nivel de ki de los judadores es: {1}", numero, elevado));
            Console.WriteLine(string.Format("{0} el nivel de transformaciones es: {1}", numero, maximo));
            Console.WriteLine(string.Format("{0} el maestro roshi llega a tener un poder de: {1}", numero, hit));
            Console.Write($"el numero de victorias de bills es:  " + clase5.victoria + "\n");
            Console.Write($"el precio de los equipos es:  " + clase5.equipos + "\n");
            Console.Write("el costo de la maquina para regenerar es: " + clase5.regenerar + "\n");
            Console.Write("los panes que come goku cuestan: " + clase5.panes + "\n");
            Console.WriteLine("los tipos de trajes que hay son: " + clase5.tipos);
            Console.WriteLine("el nombre del villano es: " + clase5.poderoso);
            Console.WriteLine("la nube se llama: " + clase5.nube);
            Console.WriteLine("la hija de gohan se llama: " + clase5.hija);
            Console.WriteLine(string.Format("{0} el nivel de ki alcanzado por su personaje es: {1}", numero, elevaciondekiactiva));

            Console.Write("Muchas gracias te esperamos hasta la proxima:) \ndigite cualquier tecla para terminar.");
            Console.ReadKey();



        }
    }


}



