using GameEngine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameLibrary.Duck
{
    /// <summary>
    /// Класс, характеризующий конструтор большой утки
    /// </summary>
    internal class BigDuckConstructor : DuckConstructor
    {

        public override Duck CreateDuck()
        {


            textureDuck = new TextureBox(ContentPipe.LoadTexture("BigDuckDown.png"));
            textureDuck.Add("Down", ContentPipe.LoadTexture("BigDuckDown.png"));
            textureDuck.Add("Up", ContentPipe.LoadTexture("BigDuckUp.png"));
            textureDuck.Add("Tuch", ContentPipe.LoadTexture("BigDuckTuch.png"));

        }

    }
}
