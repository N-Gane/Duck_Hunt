using GameEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Duck
{
    /// <summary>
    /// Абстрактный класс конструктора уток 
    /// </summary>
    public abstract class DuckConstructor
    {
        protected Duck duck;

        protected TextureBox textureDuck;
        protected ObjectScript script;
        protected SystemCollider collider;
        protected ColliderComponents colliderComponents1;
        protected ColliderComponents colliderComponents2;
        protected Random random = new Random();

        public abstract Duck CreateDuck();

    }
}
