using OpenTK;
using OpenTK.Graphics.OpenGL;


namespace GameEngine
{
    /// <summary>
    /// Класс, отрисовывающий текстуры
    /// </summary>
    public class Sprite
    {
        /// <summary>
        /// Метод для отрисовки текстуры
        /// </summary>
        /// <param name="gameObject"></param>
        public static void Draw(GameObject gameObject)
        {
            var texture = gameObject.Texture.Texture;
            var scale = gameObject.Position.Scale;
            var location = gameObject.Position.Location;

            Vector2[] vertices = new Vector2[4]
            {
                new Vector2(0, 0),
                new Vector2(1, 0),
                new Vector2(1, 1),
                new Vector2(0, 1)
            };

            GL.BindTexture(TextureTarget.Texture2D, gameObject.Texture.Texture.ID);
            GL.Begin(PrimitiveType.Quads);

            for (int i = 0; i < 4; i++)
            {

                GL.TexCoord2(vertices[i]);

                vertices[i].X *= texture.Width;
                vertices[i].Y *= texture.Height;
                vertices[i] *= scale;
                vertices[i] -= location;

                GL.Vertex2(vertices[i]);
            }

            GL.End();
        }

    }
}
