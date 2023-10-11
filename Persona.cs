using metodologia_programacion;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodologia_programacion_clase_1
{
    
    public class Persona:comparable
    {
        private string nombre;
        private int dni;
        public Persona(string nombre, int dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }
        public string getNombre()
        { return nombre; }
        public int getDni() 
        {  return dni; }
        public virtual bool SosIgual(comparable c)
        {
            return dni == ((Persona)c).getDni();
        }
        public virtual bool SosMenor(comparable c)
        {
            return dni < ((Persona)c).getDni();
        }
        public virtual bool SosMayor(comparable c)
        {
            return dni > ((Persona)c).getDni();
        }
    }
}
