using EspacioEmpleado;

Empleado emp1 = new Empleado();

emp1.Nombre = "Santiago";

emp1.Apellido = "Zelaya";

emp1.cargo = Empleado.Cargos.Ingeniero;

Console.WriteLine(emp1.Nombre);
Console.WriteLine(emp1.Apellido);
Console.WriteLine(emp1.cargo);