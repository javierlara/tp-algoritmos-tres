﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TP2.src.interfaces
{
    public interface ILanzador
    {
        void NotificarExplosion(bool exploto);

        void LanzarExplosivo();
    }
}
