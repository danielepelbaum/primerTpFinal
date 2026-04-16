using System.Collections.Generic;

namespace tp_final_bimestre_1.Models
{
    public class Integrante
    {
        private int dni;
        private string nombre;
        private DateTime fechaNacimiento;
        private string foto;
        private List<string> familiares;
        private List<string> intereses;
        public Integrante(int dni, string nombre, DateTime fechaNacimiento, string foto, List<string> intereses, List<string> familiares)
        {
         this.dni=dni;
         this.nombre=nombre;
         this.foto=foto;
         this.fechaNacimiento=fechaNacimiento;
         this.familiares= familiares;
         this.intereses = intereses;
        } 
    }
}