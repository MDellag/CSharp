using Microsoft.VisualStudio.TestTools.UnitTesting;
using Formula1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Formula1
{
    [TestClass()]
    public class Competencia_Test
    {
        [TestMethod()]
        public void Competencia_AniadirVehiculoNoCorrespondidoTest()
        {
            bool pudo = false;
            Competencia comp = new Competencia(15,10, Competencia.TipoCompetencia.MotoCross);
            AutoF1 lamb = new AutoF1(01, "Lamborghini");

            try
            {
                comp += lamb;
            }
            catch (CompetenciaNoDisponibleException e)
            {
                Console.WriteLine(e.ToString());
                
            }

            Assert.Fail("Fallo la carga de un vehiculo no correspondido");
        }

        [TestMethod()]
        public void Test_ListaDeVehiculosInstanciada()
        {
            bool success = false;
            Competencia comp = new Competencia(10, 10, Competencia.TipoCompetencia.F1);
            if (comp.Competidores != null)
            {
                success = true;
            }
            Assert.IsTrue(success);
        }
    }
}