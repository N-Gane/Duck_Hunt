using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;

using OpenTK.Graphics.OpenGL;

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
            if (!File.Exists(@"..\..\Content\" + path))
                throw new FileNotFoundException(@"File not found at '..\..\Content\" + path + "'");

            int id = GL.GenTexture();
            GL.BindTexture(TextureTarget.Texture2D, id);

            Bitmap bmp = new Bitmap(@"..\..\Content\" + path);
            BitmapData bmpData = bmp.LockBits(new Rectangle(0, 0, bmp.Width, bmp.Height), ImageLockMode.ReadOnly, System.Drawing.Imaging.PixelFormat.Format32bppArgb);

            GL.TexImage2D(TextureTarget.Texture2D, 0, PixelInternalFormat.Rgba, bmpData.Width, bmpData.Height, 0, OpenTK.Graphics.OpenGL.PixelFormat.Bgra, PixelType.UnsignedByte, bmpData.Scan0);

            bmp.UnlockBits(bmpData);

            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapS, (int)TextureWrapMode.Clamp);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureWrapT, (int)TextureWrapMode.Clamp);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMinFilter, (int)TextureMinFilter.Linear);
            GL.TexParameter(TextureTarget.Texture2D, TextureParameterName.TextureMagFilter, (int)TextureMagFilter.Linear);

            int width = bmp.Width;
            int height = bmp.Height;

            bmp.Dispose();

            return new Texture2D(id, width, height);
        }

        /// <summary>
        /// Удаление текстуры из памяти
        /// </summary>
        /// <param name="texturesId"></param>
        public static void DelTexture(List<int> texturesId)
        {
            foreach (var id in texturesId)
                GL.DeleteTexture(id);
        }
    }
}