// See https://aka.ms/new-console-template for more information;
DateTime fechaNac1 = new DateTime(1998, 10, 16);
DateTime fechaIngreso1 = new DateTime(2022, 05, 24);
DateTime fechaNac2 = new DateTime(2000, 10, 16);
DateTime fechaIngreso2 = new DateTime(2022, 05, 24);
DateTime fechaNac3 = new DateTime(2002, 7, 29);
DateTime fechaIngreso3 = new DateTime(2022, 05, 24);
DateTime fechaNac4 = new DateTime(1996, 7, 30);
DateTime fechaIngreso4 = new DateTime(2022, 05, 24);

Empleado empleado1 = new Empleado("Santiago","Castillo", fechaNac1, fechaIngreso1, 's', 'm', 60000, Cargos.Ingeniero);
Empleado empleado2 = new Empleado("Agustin","Lobo", fechaNac2, fechaIngreso2, 's', 'm', 60000, Cargos.Investigador);
Empleado empleado3 = new Empleado("Nestor","Campos", fechaNac3, fechaIngreso3,  's', 'm', 60000, Cargos.Auxliar);
Empleado empleado4 = new Empleado("Emanuel","Bilkis", fechaNac4, fechaIngreso4,  'c', 'm', 60000, Cargos.Ingeniero);


//Console.WriteLine("El salario es: " + empleado1.salario());
//empleado1.infomacionEmpleado();


Console.WriteLine("La empresa gasta un total de: $" + salariosTotales() + " en salarios");
jubacionCercana();




double salariosTotales(){
    double total = empleado1.salario() + empleado2.salario() + empleado3.salario() + empleado4.salario();   
    return total;
}


void jubacionCercana(){
    Empleado[] jubilaciones = {empleado1, empleado2, empleado3, empleado4};
    int anterior=0;
    
    for(int i=0; i<4; i++){
        if(jubilaciones[i].edad() > anterior){
            anterior = jubilaciones[i].edad();
        }
    }
    
    for(int i=0; i<4; i++){
        if(jubilaciones[i].edad() == anterior){
            Console.WriteLine("Empleado mas proximo  jubilarse");
            jubilaciones[i].infomacionEmpleado();
        }
    }
    
}