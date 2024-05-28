using EspacioEmpleado;

Empleado emp1 = new Empleado();

emp1.Nombre = "Santiago";
emp1.Apellido = "Zelaya";
emp1.cargo = Empleado.Cargos.Ingeniero;
emp1.FechaNacimiento = new DateTime(1999,10,7);
emp1.FechaIngreso = new DateTime(2012,5,3);

Console.WriteLine("Fecha de ingreso: "+ emp1.FechaIngreso);
emp1.calcularAntiguedad();
Console.WriteLine("Antiguedad: " + emp1.antiguedad + " anios");
emp1.calcularEdad();
Console.WriteLine("Edad: " + emp1.edad);
emp1.calcularJubilacion();
Console.WriteLine("Anios para jubilarse: " + emp1.cantAniosJubilacion);