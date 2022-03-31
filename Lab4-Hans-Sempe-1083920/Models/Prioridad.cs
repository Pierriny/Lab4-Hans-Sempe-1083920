using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab4_Hans_Sempe_1083920.Models
{
    public class Prioridad : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x == y)
            {
                return 0;
            }
            else if (x > y)
            {
                return 1;
            }
            else
            {
                return -1;
            }
        }
        
        // Define la prioridad segun los datos registrados y luego los suma dando el total de prioridad
        public int CalculoDePrioridad(Pacientes x)
        {
            int PrioridadSexo = 0, PrioridadEspe = 0, PrioridadIngre = 0;

            if (x.Sexo.CompareTo("Hombre") == 0) { PrioridadSexo = 3; }

            else { PrioridadSexo = 5; }

            if (x.Especialidad.CompareTo("Neumologia") == 0) { PrioridadEspe = 8; }  
            
            else if (x.Especialidad.CompareTo("Cardiogia") == 0) { PrioridadEspe = 10; }
                
            else if (x.Especialidad == "Ginecologia") { PrioridadEspe = 5; }
                
            else if (x.Especialidad.CompareTo("Traumatologia (externa)") == 0) { PrioridadEspe = 8; }
                
            else { PrioridadEspe = 3; }

            if (x.Ingreso.CompareTo("Ambulancia") == 0) { PrioridadIngre = 5; }
                
            else { PrioridadIngre = 3; }
                
            return PrioridadSexo + PrioridadEspe + PrioridadIngre + edad(x);

        }

        // Define el nivel de prioridad segun la edad
        private int edad(Pacientes x)
        {
            int P_edad = 0;
            int edad = x.Edad;
            if (edad < 6) { P_edad = 8; }
            else if (edad < 18) { P_edad = 5; }
            else if (edad < 50) { P_edad = 3; }
            else { P_edad = 10; }
            return P_edad;
        }  
    }
}
