using System.Collections.Generic;

namespace tp_final_bimestre_1.Models
{
    public class Grupo
    {
        private Dictionary<int, Integrante> Integrantes;
        //Integrante miIntegrante = new Integrante(50237129, theo, new DateTime(2010,2,3), perro, );
        //Integrantes.Add(50237129, miIntegrante)
        public Grupo
        {
            Integrantes = new Dictionary();
        }
    }
}