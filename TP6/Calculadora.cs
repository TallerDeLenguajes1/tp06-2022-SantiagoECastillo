public class Calculadora{
    public double resultado;

    public Calculadora(double valorInicial){
        resultado = valorInicial;
    }

    public void suma(double valor){
        resultado += valor;
    }
}