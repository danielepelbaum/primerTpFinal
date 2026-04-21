using System.Collections.Generic;

namespace tp_final_bimestre_1.Models
{
    public class Grupo
    {
        private Dictionary<int, Integrante> Integrantes = new Dictionary<int, Integrante>();

        public void CargaDatosManual()
        {
            List<string> intereses1 = new List<string>();
            intereses1.Add("jugar al futbol");
            intereses1.Add("mirar series");
            intereses1.Add("tomar mate");
            List<string> familiares1 = new List<string>();
            familiares1.Add("ezequiel");
            familiares1.Add("solange");
            familiares1.Add("emma");
            Integrante miIntegrante1 = new Integrante(50237129, "theo", new DateTime(2010,2,3), "perro", intereses1, familiares1);
            Integrantes.Add(50237129, miIntegrante1);
            List<string> intereses2 = new List<string>();
            intereses2.Add("jugar basquet");
            intereses2.Add("ir al gimnasio");
            intereses2.Add("tocar justin en la guitarra");
            List<string> familiares2 = new List<string>();
            familiares2.Add("andrea");
            familiares2.Add("ariel");
            familiares2.Add("ema");
            Integrante miIntegrante2 = new Integrante(50237157, "dani", new DateTime(2010,12,5), "gato", intereses2, familiares2);
            Integrantes.Add(50237157, miIntegrante2);
        }
        public Dic<int, Integrante> DevolverIntegrantes()
        {
            return Integrantes;
        }
        public Integrante GetIntegrante(int dni)
        {
            if (Integrantes.ContainsKey(dni)){
                return Integrantes[dni];
            }
            return null;
        }
    }
}