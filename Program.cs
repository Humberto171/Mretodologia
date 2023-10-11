using metodologia_programacion;
using metodologia_programacion_clase_1;
using Mretodologia;

internal class Program
{
    public static void Main(string[] args)
    {
        //ejercicio 2
        /*
         pila a = new pila();
         cola b = new cola();
         llenar(a);
         llenar(b);
         ColeccionMultiple cole1 = new ColeccionMultiple(a, b);
         informar(a);
         informar(b);
         informar(cole1);
         pila c = new pila();
         cola d = new cola();
         llenarPersonas(c);
         llenarPersonas(d);
         ColeccionMultiple cole2 = new ColeccionMultiple(c, d);
         informarPersona(c);
         informarPersona(d);
         pila e = new pila();
         cola f = new cola();
         llenarAlumnos(e);
         llenarAlumnos(f);
         ColeccionMultiple cole3 = new ColeccionMultiple(e, f);
        comparable comparable = new numero(2);
         conjunto con = new conjunto();
         con.agregar(comparable);
         con.pertenece(comparable);
         Console.WriteLine(comparable);*/

        //respuesta 11: no se tendria que hacer ninguna modificacion
        //respuesta 12: se le agrega un condicional en el cual se impriman solamente los que
        //tienen un promedio mayor
        //respuesta 8
        //respuesta 10
        cola c = new cola();
        conjunto con = new conjunto();
        Diccionario dic = new Diccionario();
        pila p = new pila();
        llenarAlumnos(p);
        CambiarEstrategia(p,new porNombre());

        informarAlumno(p);
        CambiarEstrategia(p, new porLegajo());

        informarAlumno(p);
        CambiarEstrategia(p, new porPromedio());

        informarAlumno(p);
        CambiarEstrategia(p, new porDni());
        informarAlumno(p);


        llenarAlumnos(c);
        llenarAlumnos(con);
        llenarAlumnos(dic);
        imprimir(p);
        imprimir(c);
        imprimir(con);
        imprimir(dic);

    }
    public static void llenar(coleccionable c)
    {
        int i = 0;

        while (i < 19)
        {
            Random rdn = new Random();
            comparable numero = new numero(rdn.Next(200));
            c.agregar(numero);
            i++;
        }
    }

    public static void llenarPersonas(coleccionable c)
    {
        int i = 0;

        while (i < 19)
        {
            Random rdn = new Random();
            Console.WriteLine("ingrese nombre");
            string nombre = Console.ReadLine();
            comparable Per = new Persona(nombre, rdn.Next(100000000));
            c.agregar(Per);
            i++;
        }
    }

    public static void llenarAlumnos(coleccionable c)
    {
        int i = 0;

        while (i < 19)
        {
            Random rdn1 = new Random();
            Random rdn2 = new Random();
            Random rdn3 = new Random();
            Console.WriteLine("ingrese nombre");
            string nombre = Console.ReadLine();
            comparable Alum = new Alumno(nombre, rdn1.Next(100000000), rdn2.Next(50000), rdn3.Next(100));
            c.agregar(Alum);
            i++;
        }
    }
    public static void informar(coleccionable c)
    {
        Console.WriteLine(c.cuantos());
        Console.WriteLine(((numero)c.maximo()).getValor());
        Console.WriteLine(((numero)c.minimo()).getValor());
        Console.WriteLine("ingrese un numero: ");
        int nm = int.Parse(Console.ReadLine());
        comparable n = new numero(nm);
        if (c.contiene(n))
        {
            Console.WriteLine("el elemento leido esta en la coleccion");
        }
        else { Console.WriteLine("el elemento no esta en la coleccion"); }
    }
    public static void informarPersona(coleccionable c)
    {
        Console.WriteLine(c.cuantos());
        Console.WriteLine(((Persona)c.maximo()).getDni());
        Console.WriteLine(((Persona)c.minimo()).getDni());
        Console.WriteLine("ingrese un numero de dni: ");
        int dni = int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese nombre: ");
        string nombre = Console.ReadLine();

        comparable n = new Persona(nombre, dni);
        if (c.contiene(n))
        {
            Console.WriteLine("el elemento leido esta en la coleccion");
        }
        else { Console.WriteLine("el elemento no esta en la coleccion"); }
    }
    public static void informarAlumno(coleccionable c)
    {
        Console.WriteLine(c.cuantos());
        Console.WriteLine(((Alumno)c.maximo()).getLegajo());
        Console.WriteLine(((Alumno)c.minimo()).getLegajo());
        Console.WriteLine("ingrese un numero de dni: ");
        int dni = int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese nombre: ");
        string nombre = Console.ReadLine();
        Console.WriteLine("ingrese legajo: ");
        int lej = int.Parse(Console.ReadLine());
        Console.WriteLine("ingrese promedio: ");
        int pro = int.Parse(Console.ReadLine());

        comparable n = new Alumno(nombre, dni, lej, pro);
        if (c.contiene(n))
        {
            Console.WriteLine("el elemento leido esta en la coleccion");
        }
        else { Console.WriteLine("el elemento no esta en la coleccion"); }
    }
    //Paso 5: usar dichos iteradores
    //respuesta 7
    public static void imprimir(Iterable i)
    {
        Iterador iterador = i.crearIterador();
        while(!iterador.fin())
        {
            comparable elemento = iterador.actual();
            Console.WriteLine(elemento);
            iterador.siguiente();
        }
    }
    //respuesta 9
    public static void CambiarEstrategia(Iterable c, estrategia s)
    {
        Iterador iterador = c.crearIterador();
        while (!iterador.fin())
        {
            comparable elemento = iterador.actual();
            ((Alumno)elemento).setEstrategia(s);
            iterador.siguiente();
        }
    }
    
}