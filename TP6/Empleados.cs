
public class Empleado{
    string nombre;
    string apellido;
    DateTime fechaNacimiento;
    char estadoCivil;
    char genero;
    DateTime fechaIngresoEmpresa;
    double sueldoBase;
    Cargos cargo;

    public Empleado(string nombre, string apellido, DateTime fechaNacimiento, DateTime fechaIngresoEmpresa, char estadoCivil, char genero, double sueldoBase, Cargos cargo){
        this.nombre = nombre;
        this.apellido = apellido;
        this.fechaNacimiento = fechaNacimiento;
        this.fechaIngresoEmpresa = fechaIngresoEmpresa;
        this.estadoCivil = estadoCivil;
        this.genero = genero;
        this.sueldoBase = sueldoBase;
        this.cargo = cargo;
    }

    public int antiguedad(){
        DateTime fechaHoy = new DateTime();
        fechaHoy = DateTime.Now;
        int Antiguedad = fechaHoy.Year - this.fechaIngresoEmpresa.Year;
            
        return Antiguedad;
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
    
    public double salario(){
        double salario, adicional=0;
        
        if(antiguedad()<20){
            adicional = ((antiguedad()*0.1) * this.sueldoBase);
        }else{
            if(antiguedad()>25){
                adicional = this.sueldoBase*0.25;
            }
        }

        if(this.cargo == Cargos.Ingeniero || this.cargo == Cargos.Especialista){
            adicional = adicional * 1.50;
        }

        if(this.estadoCivil == 'c'){
            adicional = adicional + 15000;
        }
        
        salario = this.sueldoBase + adicional;

        return salario;
    }

}
