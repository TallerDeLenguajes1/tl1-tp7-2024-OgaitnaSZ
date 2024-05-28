namespace EspacioEmpleado{
    public class Empleado(){
        private string nombre;
        public string Nombre{
            get => nombre;
            set => nombre = value;
        }
        private string apellido;
        public string Apellido{
            get => apellido;
            set => apellido = value;
        }
            
        private DateTime fechaNacimiento;
        public DateTime FechaNacimiento{
            get => fechaNacimiento;
            set => fechaNacimiento = value;
        }

        private char estadoCivil;
        public char EstadoCivil{
            get => estadoCivil;
            set => estadoCivil = value;
        }

        private DateTime fechaIngreso;
        public DateTime FechaIngreso{
            get => fechaIngreso;
            set => fechaIngreso = value;
        }

        private double sueldoBasico;
        public double SueldoBasico{
            get => sueldoBasico;
            set => sueldoBasico = value;
        }

        public Cargos cargo{
            get;
            set;
        }
        public enum Cargos{
            Auxiliar,
            Administrativo,
            Ingeniero,
            Especialista,
            Investigador
        }

        public int antiguedad;
        DateTime fechaActual = DateTime.Now;
        public void calcularAntiguedad(){ //antiguedad en la empresa
            antiguedad = fechaActual.Year - fechaIngreso.Year;
        }

        public int edad;
        public void calcularEdad(){ //edad
            edad = fechaActual.Year - fechaNacimiento.Year;
        }

        public int cantAniosJubilacion;

        public void calcularJubilacion(){  //jubilacion
            if(antiguedad < 65){
                cantAniosJubilacion = 65 - antiguedad;
            }else{
                cantAniosJubilacion = 0;
            }
        }

        public double salario;
        public double adicional;
        public void calcularSalario(){
            if(antiguedad<20 && antiguedad>0){
                adicional = (sueldoBasico*0.01)*antiguedad;
            }else{
                adicional = (sueldoBasico*0.25)*antiguedad;
            }
            if(cargo == Cargos.Ingeniero || cargo == Cargos.Especialista){
                adicional *= 1.5;
            }
            if(estadoCivil == 'c'){
                adicional += 150000;
            }
            salario = sueldoBasico + adicional;
        }

    }
}