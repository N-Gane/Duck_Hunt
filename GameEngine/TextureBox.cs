using System;
using System.Collections.Generic;

namespace GameEngine
{
    public class TextureBox : IDisposable
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="texture"></param>
        public TextureBox(Texture2D texture)
        {
            TextureDictionary = new Dictionary<string, Texture2D>();
            TextureDictionary.Add("default", texture);
            Texture = texture;
        }

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public TextureBox()
        {
            TextureDictionary = new Dictionary<string, Texture2D>();
        }

        float delta = 0;
        float currTime = 0;

        /// <summary>
        /// Текущая текстура 
        /// </summary>
        public Texture2D Texture { get; private set; }

        /// <summary>
        /// Список всех текстур
        /// </summary>
        private Dictionary<string, Texture2D> TextureDictionary;

        /// <summary>
        /// Метод для добавления текстуры в список
        /// </summary>
        /// <param name="name"></param>
        /// <param name="texture"></param>
        public void Add(string name, Texture2D texture)
        {
            TextureDictionary.Add(name, texture);
        }

        /// <summary>
        /// Метод для удаления текстуры из списка
        /// </summary>
        /// <param name="name"></param>
        public void Delete(string name)
        {
            TextureDictionary.Remove(name);
        }

        /// <summary>
        /// Метод для замены текстуры по тегу
        /// </summary>
        /// <param name="name"></param>
        /// <param name="texture"></param>
        public void Edit(string name, Texture2D texture)
        {
            TextureDictionary[name] = texture;
        }

        /// <summary>
        /// Установка текущей текстуры
        /// </summary>
        /// <param name="name"></param>
        public void Set(string name)
        {
            if (Time.CurrentTime - currTime >= delta)
            {
                Texture = TextureDictionary[name];
                currTime = Time.CurrentTime;
                delta = 0;
            }
        }

        /// <summary>
        /// Установка текущей текстуры но отведённое время
        /// </summary>
        /// <param name="name">Тэг текстуры</param>
        /// <param name="delta">время установки</param>
        public void Set(string name, float delta)
        {
            if (Time.CurrentTime - currTime >= this.delta)
            {
                Texture = TextureDictionary[name];
                this.delta = delta;
                currTime = Time.CurrentTime;
            }
        }

        /// <summary>
        /// Формирование списка id текстур
        /// </summary>
        /// <returns>Список id текстур</returns>
        public List<int> GetIdTextures()
        {
            List<int> result = new List<int>(10);

            foreach (var texture in TextureDictionary)
                result.Add(texture.Value.ID);

            return result;
        }

        /// <summary>
        /// Метод для освобождения памяти
        /// </summary>
        public void Dispose()
        {
            ContentPipe.DelTexture(GetIdTextures());
            TextureDictionary.Clear();
        }
    }
}
