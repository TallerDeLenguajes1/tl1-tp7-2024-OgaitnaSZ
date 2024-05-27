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
    }
}