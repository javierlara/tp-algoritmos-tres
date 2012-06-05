﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TP2_Bomberman.src;
using TP2_Bomberman.src.Bombas;
using TP2_Bomberman.src.Excepciones;
using TP2_Bomberman.src.Articulos;

namespace TP2_Bomberman
{
    public class Bombita : Personaje
    {
        private int vidas = 3;
        private double porcentajeDeRetardo = 1; //Empieza con un retardo normal de la bomba incorporada (100%)
        
        public Bombita()
            :base()
        {
            this.resistencia = 1;
            Casillero casilleroInicial = new Casillero(0, 0);
            this.posicion = casilleroInicial; //Que bombita empiece siempre en el casillero (0,0)
            casilleroInicial.Personaje = this;
            this.bomba = new Molotov(); //Inicialmente tiene una molotov
        }

        // Bombita pierde una vida con cualquier bomba que se lo danie
        public override void DaniarConMolotov(Molotov molotov) 
        {
            if(FueDestruido()) throw new EntidadYaDestruidaException();
            this.vidas--;
        }
        public override void DaniarConToleTole(ToleTole toleTole) 
        {
            if (FueDestruido()) throw new EntidadYaDestruidaException();
            this.vidas--;
        }
        public override void DaniarConProyectil(Proyectil proyectil) 
        {
            if (FueDestruido()) throw new EntidadYaDestruidaException();
            this.vidas--;
        }
        

        // Devuelve si no tiene mas vidas o no
        public override bool FueDestruido()
        {
            if (this.vidas == 0) return true;
            return false;
        }


        public void LanzarBomba()
        {
            // FALTA IMPLEMENTAR
            // LO QUE PENSE ES QUE CUANDO LANCE UNA BOMBA, TIRE LA QUE TIENE GUARDADA EN EL ATRIBUTO "bomba"
            // E INMEDIATAMENTE CREE UNA NUEVA INSTANCIA Y LA GUARDE EN EL ATRIBUTO

            //TENER EN CUENTA EL TIEMPO DEL RETARDO, ANTES DE LANZAR LA BOMBA MULTIPLICARLO POR EL RETARDO QUE
            //ESTA EN EL ATRIBUTO "retardo". ESTO ES POR SI AGARRA EL ARTICULO TIMER Y LAS BOMBAS SE LANZAN CON
            // UN RETARDO DEL 15% MENOS ENTONCES MODIFICA EL ATRIBUTO Y LO PONE EN 0.85 Y AL MULTIPLICARLO POR ESTO
            // SE CAMBIA EL RETARDO DE LA BOMBA
            bomba.Explotar(porcentajeDeRetardo);
        }



        public void AgarrarArticulo(Articulo articulo)
        {
            articulo.UtilizarArticuloEn(this);
        }
        

        //Propiedades
        public int Vidas
        {
            get { return this.vidas;}
        }

        public double PorcentajeDeRetardo
        {
            get { return this.porcentajeDeRetardo; }
            set { this.porcentajeDeRetardo = value; }
        }
    }
}