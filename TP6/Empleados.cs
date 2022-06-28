public class Empleado{
    string nombre;
    string apellido;
    DateTime fechaNacimiento;
    char estadoCivil;
    char genero;
    DateTime fechaIngresoEmpresa;
    double sueldoBase;
    Cargo cargo;

    public Empleado(string nombre, string apellido, DateTime fechaNacimiento, DateTime fechaIngresoEmpresa, char estadoCivil, char genero, double sueldoBase){
        this.nombre = nombre;
        this.apellido = apellido;
        this.fechaNacimiento = fechaNacimiento;
        this.fechaIngresoEmpresa = fechaIngresoEmpresa;
        this.estadoCivil = estadoCivil;
        this.genero = genero;
        this.sueldoBase = sueldoBase;
        //this.cargo = cargo;
    }

    public void antiguedad(){
        DateTime fechaHoy = new DateTime();
        fechaHoy = DateTime.Now;
        int Antiguedad = fechaHoy.Year - this.fechaIngresoEmpresa.Year;
            
        Console.WriteLine($"El empleado {this.nombre} {this.apellido} lleva: {Antiguedad} Dias en la empresa");

    }

    public int edad(){
        int edad;
        DateTime fechaHoy = new DateTime();
        fechaHoy = DateTime.Now; 
        edad = fechaHoy.Year - this.fechaNacimiento.Year;
        
        return edad;
    }

    public int jubilacio(){
        int jubilacion;

        if(this.genero == 'm'){
            jubilacion = 65 - Convert.ToInt32(edad());
        }else{
            jubilacion = 60 - Convert.ToInt32(edad());
        }

        return jubilacion;
    }
    
    
}
