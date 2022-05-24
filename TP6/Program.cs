// See https://aka.ms/new-console-template for more information;

int opcion=999;
double numero;
Calculadora cal = new Calculadora(0);

while(opcion != 0){
    Console.WriteLine("---------CALCULADORA-----------");

    Console.WriteLine("1.- Sumar");
    Console.WriteLine("2.- Restar");
    Console.WriteLine("3.- Multiplicar");
    Console.WriteLine("4.- Dividir");
    Console.WriteLine("5.- Limpiar");
    Console.WriteLine("6.- Salir");
    Console.WriteLine("Ingrese la tarea a realizar: ");
    opcion = Convert.ToInt32(Console.ReadLine());

    switch(opcion){
        case 1:
            Console.WriteLine("Ingrese un numero: ");
            numero = Convert.ToDouble(Console.ReadLine());
            cal.Sumar(numero);
            Console.WriteLine("RESULTADO: " + cal.resultado);
            break;
        case 2:
            Console.WriteLine("Ingrese un numero: ");
            numero = Convert.ToDouble(Console.ReadLine());
            cal.Restar(numero);
            Console.WriteLine("RESULTADO: " + cal.resultado);
            break;
        case 3:
            Console.WriteLine("Ingrese un numero: ");
            numero = Convert.ToDouble(Console.ReadLine());
            cal.Multiplciar(numero);
            Console.WriteLine("RESULTADO: " + cal.resultado);
            break;
        case 4:
            Console.WriteLine("Ingrese un numero: ");
            numero = Convert.ToDouble(Console.ReadLine());
            cal.Dividir(numero);
            Console.WriteLine("RESULTADO: " + cal.resultado);
            break;
        case 5:
            Console.WriteLine("Se limpio la calculadora");
            cal = new Calculadora(0);
            break;
        case 6:
            Console.WriteLine("Usted salio del programa");
            opcion = 0;
            break;
        default:
            Console.WriteLine("OPCION NO VALIDA");
            break; 
    }  
}



