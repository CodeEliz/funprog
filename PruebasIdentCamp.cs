using Microsoft.VisualStudio.TestTools.UnitTesting;
using CampeonDeBarrio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CampeonDeBarrio.Tests
{
    [TestClass()]
    public class PruebasIdentCamp
    {
        [TestMethod()]
        public void IdentificaUnCampeon()
        {
            //Arrange
            Jugador[] jugadoresPrueba = new Jugador[5]
            {
                new Jugador { Nombre = "Simon", Campañas = 5,Puntos = 300},
                new Jugador { Nombre = "Mateo", Campañas = 4,Puntos = 280},
                new Jugador { Nombre = "Alejandro", Campañas = 3,Puntos = 260},
                new Jugador { Nombre = "Sara", Campañas = 2,Puntos = 240},
                new Jugador { Nombre = "Sofia", Campañas = 1,Puntos = 380}
            };
            //Act
            int cantidadEsperada = 1;
            int cantidadObtenida = Program.IdentificaCampeon(jugadoresPrueba).Length;
            //Assert
            Assert.AreEqual(cantidadEsperada,cantidadObtenida);
        }

        [TestMethod()]
        public void IdentificaVariosCampeones()
        {
            //Arrange
            Jugador[] jugadoresPrueba = new Jugador[5]
            {
                new Jugador { Nombre = "Simon", Campañas = 5,Puntos = 300},
                new Jugador { Nombre = "Mateo", Campañas = 4,Puntos = 280},
                new Jugador { Nombre = "Alejandro", Campañas = 3,Puntos = 260},
                new Jugador { Nombre = "Sara", Campañas = 2,Puntos = 400},
                new Jugador { Nombre = "Sofia", Campañas = 1,Puntos = 200}
            };
            //Act
            int cantidadEsperada = 1;
            int cantidadObtenida = Program.IdentificaCampeon(jugadoresPrueba).Length;
            //Assert
            Assert.AreNotEqual(cantidadEsperada, cantidadObtenida);
        }

        [TestMethod()]
        public void TraePromedioEsperado()
        {
            //Arrange
            Jugador[] jugadoresPrueba = new Jugador[5]
            {
                new Jugador { Nombre = "Simon", Campañas = 5,Puntos = 300},
                new Jugador { Nombre = "Mateo", Campañas = 4,Puntos = 280},
                new Jugador { Nombre = "Alejandro", Campañas = 3,Puntos = 260},
                new Jugador { Nombre = "Sara", Campañas = 2,Puntos = 240},
                new Jugador { Nombre = "Sofia", Campañas = 2,Puntos = 377}
            };
            //Act
            float promedioEsperado = 188.5f;
            float promedioObtenido = Program.IdentificaCampeon(jugadoresPrueba)[0].Promedio;
            //Assert
            Assert.AreEqual(promedioEsperado, promedioObtenido);
        }

        [TestMethod()]
        public void IdentificaCampeonEsperado()
        {
            //Arrange
            Jugador[] jugadoresPrueba = new Jugador[5]
            {
                new Jugador { Nombre = "Simon", Campañas = 5,Puntos = 300},
                new Jugador { Nombre = "Mateo", Campañas = 4,Puntos = 280},
                new Jugador { Nombre = "Alejandro", Campañas = 3,Puntos = 260},
                new Jugador { Nombre = "Sara", Campañas = 2,Puntos = 240},
                new Jugador { Nombre = "Sofia", Campañas = 1,Puntos = 377}
            };
            //Act
            string jugadorEsperado = jugadoresPrueba[4].ToString();
            string jugadorObtenido = Program.IdentificaCampeon(jugadoresPrueba)[0].ToString();
            //Assert
            Assert.AreEqual(jugadorEsperado, jugadorObtenido);
        }
    }
}