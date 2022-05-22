using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ex03_CampeonDeBarrio;

namespace PruebaUnitaria
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DeberíaIdentificarCampeonEnlaPosicion4()
        {
            Jugador[] arregloJugadores = new Jugador[5]
            {
                new Jugador { Nombre = "Alicia", Campañas = 5, Puntos = 400 },
                new Jugador { Nombre = "Bernardo", Campañas = 3, Puntos = 300 },
                new Jugador { Nombre = "Camila", Campañas = 4, Puntos = 240 },
                new Jugador { Nombre = "Diego", Campañas = 7, Puntos = 140 },
                new Jugador { Nombre = "Elena", Campañas = 2, Puntos = 400 }
            };

            Jugador jugadorCampeon = arregloJugadores[4];

            float expeted = jugadorCampeon.Promedio;

            float actual = Program.IdentificaCampeon(arregloJugadores);

            Assert.AreEqual(expeted, actual);
        }


        [TestMethod]
        public void DeberíaIdentificarCampeónUnico()
        {
            Jugador[] arregloJugadores = new Jugador[5]
            {
                new Jugador { Nombre = "Alicia", Campañas = 1, Puntos = 50 },
                new Jugador { Nombre = "Bernardo", Campañas = 4, Puntos = 100 },
                new Jugador { Nombre = "Camila", Campañas = 5, Puntos = 300 },
                new Jugador { Nombre = "Diego", Campañas = 4, Puntos = 200 },
                new Jugador { Nombre = "Elena", Campañas = 3, Puntos = 300 }
            };

            int contador = 0;
            float promedioMax = 0;

            Jugador jugadorCampeon = arregloJugadores[0];

            for (int i = 0; i < arregloJugadores.Length; i++)
            {
                if (promedioMax < arregloJugadores[i].Promedio)
                    promedioMax = arregloJugadores[i].Promedio;
            }

            for (int i = 0; i < arregloJugadores.Length; i++)
            {
                if (promedioMax == arregloJugadores[i].Promedio)
                {
                    contador++;
                }

            }

            Assert.AreEqual(contador, 1);

        }


        [TestMethod]
        public void DeberíaIdentificarEmpateTriple()
        {
            Jugador[] arregloJugadores = new Jugador[5]
            {
                new Jugador { Nombre = "Alicia", Campañas = 5, Puntos = 600 },
                new Jugador { Nombre = "Bernardo", Campañas = 4, Puntos = 200 },
                new Jugador { Nombre = "Camila", Campañas = 3, Puntos = 180 },
                new Jugador { Nombre = "Diego", Campañas = 4, Puntos = 480 },
                new Jugador { Nombre = "Elena", Campañas = 1, Puntos = 120 }
            };

            int contador = 0;
            float promedioMax = 0;

            Jugador jugadorCampeon = arregloJugadores[0];

            for (int i = 0; i < arregloJugadores.Length; i++)
            {
                if (promedioMax < arregloJugadores[i].Promedio)
                    promedioMax = arregloJugadores[i].Promedio;
            }

            for (int i = 0; i < arregloJugadores.Length; i++)
            {
                if (promedioMax == arregloJugadores[i].Promedio)
                {
                    contador++;
                }

            }
        }
    }
}