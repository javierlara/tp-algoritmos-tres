﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TP2.Juego.personajes;
using TP2.Elementales;
using TP2.src.Juego.bombas;
using TP2.src.estrategias;
using TP2.src.juego.personajes;

namespace TP2.src.Juego.personajes
{
    public class LopezReggae : Enemigo
    {
        private static int RESISTENCIA_INICIAL = 10;
        private static int VELOCIDAD_INICIAL = 2;

        // inicializa los atributos
        private void Inicializar()
        {
            this.estrategiaDeLanzamiento = new LanzarProyectil(this);
        }


        // crea a Lopez Reggae
        public LopezReggae()
            : base(RESISTENCIA_INICIAL, VELOCIDAD_INICIAL)
        {
            this.Inicializar();
        }


        // crea a Lopez Reggae
        public LopezReggae(Casilla posicion)
            : base(posicion, RESISTENCIA_INICIAL, VELOCIDAD_INICIAL)
        {
            this.Inicializar();
        }


        // este metodo es utilizado por el controlador para solicitar su actual imagen que la representa
        public override string GetDescripcion()
        {
            return "Vacio";
        }

    }
}
