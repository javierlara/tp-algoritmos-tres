﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TP2.Excepciones;

namespace TP2.Elementales
{
    /// <summary>
    /// Esta clase contendra todos los casilleros tanto los vacios como los 
    /// ocupados por las entidades (personajes, bombas, obstaculos o articulos)
    /// Implementa el patron singleton
    /// </summary>
    public class Tablero
    {
        private static int MAXIMO_FILA = 30;
        private static int MAXIMO_COLUMNA = 30;
        private static Tablero INSTANCIA = null;
        private Casilla[,] casillas;

        // inicializa los casilleros que compondran al tablero, en principio vacios
        private void InicializarCasillas()
        {
            int indiceFila = 0;
            int indiceColumna = 0;
            while (indiceFila < MAXIMO_FILA)
            {
                indiceColumna = 0;
                while (indiceColumna < MAXIMO_COLUMNA)
                {
                    casillas [indiceFila, indiceColumna] = new Casilla (indiceFila, indiceColumna);
                    indiceColumna++;
                }
                indiceFila++;
            }
        }

        // solo puede crearse una instancia de esta clase
        private Tablero()
        {
            this.casillas = new Casilla [MAXIMO_FILA, MAXIMO_COLUMNA];
            this.InicializarCasillas();
        }

        // retorna la instancia de tablero
        public static Tablero GetInstancia()
        {
            if (INSTANCIA == null)
                INSTANCIA = new Tablero();
            return (INSTANCIA);
        }

        // retorna la cantidad de casillas que tiene
        public int GetTamanio()
        {
            return (MAXIMO_FILA * MAXIMO_COLUMNA);
        }

        // retorna la casilla coincidente con la fila y columna pasada;
        // en caso de que la casilla solicitada exceda los limites del tablero,
        // se lanzara una casilla nula
        public Casilla GetCasilla(int fila, int columna)
        {
            if (fila > MAXIMO_FILA || fila < 0 ||
                columna > MAXIMO_COLUMNA || columna < 0)
            {
                CasillaNull.GetInstancia();
            }
            return (casillas [fila, columna]);
        }
    }
}
