using EspacioCalculadora;

Calculadora calc1 = new Calculadora();

//Calculadora V1 full string
int bandera = 0;
int num1;
int num2;

do{
    Console.WriteLine("--- CALCULADORA FULL STRING ---");
    Console.WriteLine("Ingrese una operacion matematica");
    string opMat = Console.ReadLine();

    if(opMat.IndexOf("+", StringComparison.OrdinalIgnoreCase)>=0){
        string[] op = opMat.Split('+');       
        int.TryParse(op[0], out num1);
        int.TryParse(op[1], out num2);
        calc1.N1 = num1;
        calc1.N2 = num2;
        calc1.sumar();
        Console.WriteLine("La suma es: " + calc1.R);     
    }else if(opMat.IndexOf("-", StringComparison.OrdinalIgnoreCase)>=0){
        string[] op = opMat.Split('-');        
        int.TryParse(op[0], out num1);
        int.TryParse(op[1], out num2);
        calc1.N1 = num1;
        calc1.N2 = num2;
        calc1.restar();
        Console.WriteLine("La diferencia es: " + calc1.R);
    }else if(opMat.IndexOf("*", StringComparison.OrdinalIgnoreCase)>=0){
        string[] op = opMat.Split('*');  
        int.TryParse(op[0], out num1);
        int.TryParse(op[1], out num2);      
        calc1.N1 = num1;
        calc1.N2 = num2;
        calc1.multiplicar();
        Console.WriteLine("El producto es: "+ calc1.R);
    }else if(opMat.IndexOf("/", StringComparison.OrdinalIgnoreCase)>=0){
        string[] op = opMat.Split('/');  
        int.TryParse(op[0], out num1);
        int.TryParse(op[1], out num2);    
        calc1.N1 = num1;
        calc1.N2 = num2;
        if(calc1.N2 != 0){
            calc1.dividir(); 
            Console.WriteLine("El cociente es: "+ calc1.R); 
        }else{
            Console.WriteLine("No se puede dividir en 0"); 
        }
    }else{
        Console.WriteLine("Ingrese una operacion valida");
    }
    Console.WriteLine("Quiere realizar otra operacion? 1:Si / 0: No");
    string buff3 = Console.ReadLine();
    int.TryParse(buff3, out bandera);
}while(bandera==1);