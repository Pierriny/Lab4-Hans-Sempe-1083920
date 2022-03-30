﻿using System;
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
        // Calcula el nivel de prioridad segun la edad del paciente
        private int PrioridadPorEdad(Pacientes x)
        {
            int P_edad = 0;
            DateTime Hoy = DateTime.Now;
            int CantAños = Hoy.Year - x.Fnacimiento.DayOfYear;
            if (Hoy.DayOfYear < x.Fnacimiento.DayOfYear) { CantAños = CantAños - 1; }
            if (CantAños < 6) { P_edad = 8; }
            else if (CantAños < 18) { P_edad = 5; }
            else if (CantAños < 50) { P_edad = 3; }
            else { P_edad = 10; }
            return P_edad;
        }

        // Suma total de prioridad del paciente
        public int CalcularPrioridad(Pacientes x)
        {
            return x.Sexo + x.Especialidad + x.Ingreso + PrioridadPorEdad(x);
        }

        
    }
}