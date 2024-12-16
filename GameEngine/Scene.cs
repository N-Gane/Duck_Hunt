using OpenTK;
using System;
using System.Collections.Generic;

namespace GameEngine
{
    public abstract class Scene : GameWindow
    {
        /// <summary>
        /// Главный список игровых объектов
        /// </summary>
        public List<GameObject> gameObjects = new List<GameObject>(20);

        /// <summary>
        /// Список игровых объектов на удаление из основного списка
        /// </summary>
        protected List<GameObject> gameObjectsToRemove = new List<GameObject>(20);

        /// <summary>
        /// Список игровых объектов на добавление в основной список
        /// </summary>
        protected List<GameObject> gameObjectsToAdd = new List<GameObject>(20);

        /// <summary>
        /// Ширина игровой сцены
        /// </summary>
        public int WidthOfApplication { get; private set; } = 1280;

        /// <summary>
        /// Высота игровой сцены
        /// </summary>
        public int HeightOfApplication { get; private set; } = 720;

        /// <summary>
        /// Метод для удаления игровых объектов из главного списка
        /// </summary>
        protected void RemoveRenderingGameObjects()
        {
            foreach (GameObject removeGameObject in gameObjectsToRemove)
            {
                gameObjects.Remove(removeGameObject);

                removeGameObject.Dispose();
            }

            gameObjectsToRemove.Clear();
        }

        /// <summary>
        /// Метод для добавления игровых объектов в главный список
        /// </summary>
        protected void AddRenderingGameObjects()
        {
            gameObjects.AddRange(gameObjectsToAdd);
            gameObjectsToAdd.Clear();
        }

        /// <summary>
        /// Метод для добавления объктов в список на удаление
        /// </summary>
        /// <param name="gameObject"></param>
        public void AddObjectsToRemove(GameObject gameObject)
        {
            gameObjectsToRemove.Add(gameObject);
        }

        /// <summary>
        /// Метод для для добавления объектов в список добавлений 
        /// </summary>
        /// <param name="gameObject"></param>
        public void AddObjectsToAdd(GameObject gameObject)
        {
            gameObjectsToAdd.Add(gameObject);
        }

        /// <summary>
        /// Метод для подсчёта игровых объектов
        /// </summary>
        /// <param name="typeObjects">Тип объекта</param>
        /// <returns></returns>
        public int CountGameObject(params Type[] typeObjects)
        {
            int countObjects = 0;

            foreach (var gameObject in gameObjects)
            {
                foreach (var typeObject in typeObjects)
                {
                    if (gameObject.GetType() == typeObject)
                    {
                        countObjects++;
                    }
                }
            }

            return countObjects;
        }

        /// <summary>
        /// Метод для отрисовки игровых объектов
        /// </summary>
        public abstract void Rendering();

        /// <summary>
        /// Метод, завершающий игру
        /// </summary>
        protected abstract void EndGame();

    }
}
