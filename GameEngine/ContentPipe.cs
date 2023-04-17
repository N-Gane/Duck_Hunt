using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;
using OpenTK.Graphics.OpenGL;
using System.IO;
using System.Drawing;
using System.Drawing.Imaging;

namespace GameEngine
{
    /// <summary>
    /// Класс для работы с текстурами
    /// </summary>
    public class ContentPipe
    {
        /// <summary>
        /// Загрузка текстуры в память
        /// </summary>
        /// <param name="path"></param>
        /// <returns></returns>
        public static Texture2D LoadTexture(string path)
        {
            if (!File.Exists(@"Content\" + path))
                throw new FileNotFoundException(@"File not found at 'Content\" + path + "'")
        }

    }
}
