public class Empleado{
    string nombre;
    string apellido;
    DateTime fechaNacimiento;
    char estadoCivil;
    char genero;
    DateTime fechaIngresoEmpresa;
    double sueldoBase;
    Cargo cargo;

    public Empleado(string nombre, string apellido, DateTime fechaNacimiento, DateTime fechaIngresoEmpresa){
        this.nombre = nombre;
        this.apellido = apellido;
        this.fechaNacimiento = fechaNacimiento;
        this.fechaIngresoEmpresa = fechaIngresoEmpresa;
    }
}
