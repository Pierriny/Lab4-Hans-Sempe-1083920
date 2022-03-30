using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4_Hans_Sempe_1083920.Models
{
    public class Pacientes
    {
        // constructor
        public Pacientes() { }

        // obtiene y define el nombre del paciente
        public String Nombre { get; set; }
        // obtiene y define el apellido del paciente
        public String Apellido { get; set; }
        // obtiene y define la fecha de nacimiento del cliente
        public DateTime Fnacimiento { get; set; }
        // obtiene y define el sexo (masculino o femenino) del paciente 
        public int Sexo { get; set; }
        // obtiene y define por cual medio ingreso el cliente 
        public int Ingreso { get; set; }
        // obtiene y define en que se especializa el cliente
        public int Especialidad { get; set; }

        public Pacientes(String name, String lastname, DateTime nacimiento, int sexo, int ingreso, int especialidad)
        {
            this.Nombre = name;
            this.Apellido = lastname;
            this.Fnacimiento = nacimiento;
            this.Sexo = sexo;
            this.Ingreso = ingreso;
            this.Especialidad = especialidad;
        }

    }
}
