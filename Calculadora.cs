namespace EspacioCalculadora;

public class Calculadora(){
    private int n1;
    public int N1{
        get;
        set;
    }
    private int n2;
    public int N2{
        get;
        set;
    }
        
    private float resultado;
    public float R{
        get;
        set;
    }
    int sum, res, mul, div;

    void sumar(){
        sum = n1 + n2;
    }
    void restar(){
        res = n1 - n2;
    }
    void multiplicar(){
        mul = n1 * n2;
    }
    void dividir(){
        div = n1 / n2;
    }
}

Calculadora calc1 = new Calculadora();
calc1.sumar(2.3);