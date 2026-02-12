//Ejercicio 1
        string nombre = "Juan";
        int nivel = 20;
        float vida = 100.0f;
        bool jefe = true;
        Console.WriteLine("Usted se enfrentará a " + nombre + " nivel " + nivel + " puntos vitales: " + vida + " boss: " + jefe);

//Ejercicio 2
        int numero= 50;
        long numerogrande = numero;
        double numerodecimal=numerogrande;
        Console.WriteLine("El numero es: " + numero);

//Ejercicio 3
        double precio = 19.99;
        int precioredondo=(int)precio;
        Console.WriteLine("El precio redondeado es: " + precioredondo);

//Ejercicio 4
        string numeroentero;
        Console.WriteLine("Ingrese un numero entero: ");    
        numeroentero = Console.ReadLine();
        int numeroentero2 = int.Parse(numeroentero);
        Console.WriteLine("El numero ingresado es: " + numeroentero2);
//Ejercicio 5
        string otronumero = "20.5";
        string valorbool="true";    
        Convert.ToBoolean(valorbool);
        Convert.ToDouble(otronumero);
        Console.WriteLine("El valor de la variable es " + valorbool + " y el número convertido es " + otronumero);
//Ejercicio 6
        double pi = 3.141592;
        Convert.ToString(pi);
        Console.WriteLine("El número convertido a texto es " + pi);
//Ejercicio 7
        double iva = 0.21;
        string valor;
        Console.WriteLine("Ingrese el precio de su producto: ");
        valor = Console.ReadLine();
        precio= Convert.ToDouble(valor);
        double preciototal = precio-(precio * iva)  ;
        int totalFinal = (int)preciototal;
        Console.WriteLine("El precio a pagar es de " + totalFinal);
