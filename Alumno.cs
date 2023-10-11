using metodologia_programacion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace metodologia_programacion_clase_1
{
    
    public class Alumno:Persona
    {
        private int legajo;
        private int promedio;
        private estrategia est;
        public Alumno(string n,int d,int l, int p):base(n,d)
        {
            this.legajo = legajo;
            this.promedio = promedio;
            est = new porPromedio();
        }
        public int getLegajo()
        {
            return this.legajo;
        }
        public override string ToString()
        {
            return this.getDni().ToString();
        }
        public int getPromedio() 
        {
            return this.promedio;
        }
        public void setEstrategia(estrategia e)
        { 
            this.est = e;
        }
        public bool SosIgual(comparable c)
        {
            return est.sosIgual(this, (Alumno)c);
        }
        public bool SosMenor(comparable c)
        {
            return est.sosMenor(this, (Alumno)c);
        }
        public bool SosMayor(comparable c)
        {
            return est.sosMayor(this, (Alumno)c);
        }
    }
}
