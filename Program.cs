using EspacioEmpleado;
Empleado[] empleados = new Empleado[3];
double montoTotalSalarios = 0;

//Cargar empleados
for(int i=0 ; i<3 ; i++){
    Empleado empleado = new Empleado();
    Console.WriteLine("Ingrese el nombre del empleado " + i);
    empleado.Nombre = Console.ReadLine();

    Console.WriteLine("Ingrese el apellido del empleado " + i);
    empleado.Apellido = Console.ReadLine();

    Console.WriteLine("Ingrese la fecha de nacimiento (anio/mes/dia) del empleado " + i);
    string fecha = Console.ReadLine();
    string[] fecha1 = fecha.Split('/'); 
    int dia,mes,anio;
    int.TryParse(fecha1[0], out anio);
    int.TryParse(fecha1[1], out mes);
    int.TryParse(fecha1[2], out dia);

    empleado.FechaNacimiento = new DateTime(anio,mes,dia);

    Console.WriteLine("Ingrese el estado civil (c/s) del empleado " + i);
    empleado.EstadoCivil = char.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese la fecha de ingreso a la empresa (anio/mes/dia) del empleado " + i);
    fecha = Console.ReadLine();
    fecha1 = fecha.Split('/'); 
    int.TryParse(fecha1[0], out anio);
    int.TryParse(fecha1[1], out mes);
    int.TryParse(fecha1[2], out dia);

    empleado.FechaIngreso = new DateTime(anio,mes,dia);

    Console.WriteLine("Ingrese el sueldo basico del empleado " + i);
    empleado.SueldoBasico = int.Parse(Console.ReadLine());

    Console.WriteLine("Ingrese el cargo del empleado " + i);
    Console.WriteLine("0:Auxiliar 1:Administrativo 2:Ingeniero 3:Especialista 4:Investigador");
    int cargo = int.Parse(Console.ReadLine());
    switch(cargo){
        case 0:
            empleado.cargo = Empleado.Cargos.Auxiliar;
        break;
        case 1:
            empleado.cargo = Empleado.Cargos.Administrativo;
        break;
        case 2:
            empleado.cargo = Empleado.Cargos.Ingeniero;
        break;
        case 3:
            empleado.cargo = Empleado.Cargos.Especialista;
        break;
        case 4:
            empleado.cargo = Empleado.Cargos.Investigador;
        break;
    }
    empleado.calcularAntiguedad();
    empleado.calcularEdad();
    empleado.calcularJubilacion();
    empleado.calcularSalario();
    empleados[i] = empleado;
    montoTotalSalarios =+ empleado.salario;
}

//Mostrar monto total en salarios
Console.WriteLine("Monto total en salarios $" + montoTotalSalarios);

//Empleado proximo a jubilarse
int aniosJub = 65;
int max = 0;
for(int i=0 ; i<3 ; i++){
    if(empleados[i].cantAniosJubilacion < aniosJub){
        aniosJub = empleados[i].cantAniosJubilacion;
        max = i;
    }
}

Console.WriteLine("El empleado proximo a jubilarse es el " + max);
Console.WriteLine("Nombre: " + empleados[max].Nombre);
Console.WriteLine("Apellido: " + empleados[max].Apellido);
Console.WriteLine("Nacimiento: " + empleados[max].FechaNacimiento);
Console.WriteLine("Estado civil: " + empleados[max].EstadoCivil);
Console.WriteLine("Fecha de ingreso a la empresa: " + empleados[max].FechaIngreso);
Console.WriteLine("Sueldo basico: $" + empleados[max].SueldoBasico);
Console.WriteLine("Cargo: " + empleados[max].cargo);
Console.WriteLine("Antiguedad en la empresa: " + empleados[max].antiguedad);
Console.WriteLine("Edad: " + empleados[max].edad);
Console.WriteLine("Anios para jubilarse: " + empleados[max].cantAniosJubilacion);
Console.WriteLine("Salario: $" + empleados[max].salario);