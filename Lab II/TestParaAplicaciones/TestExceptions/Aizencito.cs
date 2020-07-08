using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace TestExceptions
{
    public class Aizencito
    {
        int ganasjugar;
        string novia;

        public Aizencito(string novia, int ganasJugar)
        {
            this.ganasjugar = ganasjugar;
            this.novia = novia;
        }

        public static void AizenMasAizen(Aizencito a1, Aizencito a2)
        {
            try
            {
                bool a = a1 == a2;
            }
            catch (Exception e)
            {
                throw new Exception("A este Aizencito no le sumo otro", e);
            }
            finally
            {

            }
            
                
        }

        public static bool operator ==(Aizencito a1, Aizencito a2)
        {
            bool soniguales = false;
            try
            {
                if (a1.novia == a2.novia && a1.ganasjugar == a2.ganasjugar)
                {
                    soniguales = true;
                }
            }
            catch (Exception e)
            {
                throw new idRepetidoExcp("Este Aizencito es igual al otro Aizencito", e);
            }
            
            return soniguales;
        }

        public static bool operator !=(Aizencito a1, Aizencito a2)
        {
            return !(a1 == a2);
        }
    }
}
