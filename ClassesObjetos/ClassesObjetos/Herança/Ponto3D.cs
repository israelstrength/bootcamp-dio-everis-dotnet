﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesObjetos.Herança
{
    public class Ponto3D : Ponto
    {
        public int z;
        public Ponto3D(int x, int y, int z) : base(x, y)
        {
            this.z = z;
            CalcularDistancia();
        }

        public static void Calcular() //metodo
        {
            //Faz alguma coisa...
        }
        public override void CalcularDistancia3()
        {
            //Faz outra coisa ...
            base.CalcularDistancia3();
        }
    }
}
