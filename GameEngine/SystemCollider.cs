using System;
using System.Collections.Generic;
using OpenTK;

namespace GameEngine
{
    public class SystemCollider : IDisposable
    {
        private Dictionary<string, ColliderComponents> collider;

        /// <summary>
        /// Активность/неактивность элемента
        /// </summary>
        public bool IsInactive { get; private set; }

        /// <summary>
        /// Изменение активности элемента
        /// </summary>
        /// <param name="active"></param>
        public void SetIsInactive(bool active)
        {
            foreach (var obj in collider)
                obj.Value.SetIsInactive(active);

            IsInactive = active;
        }

        /// <summary>
        /// Добавление коллайдера
        /// </summary>
        /// <param name="colliders">Коллайдер</param>
        /// <param name="tag">Тэг коллайдера</param>
        public void Add(ColliderComponents colliders, string tag)
        {
            if (collider == null)
                collider = new Dictionary<string, ColliderComponents>();

            if (colliders != null)
                collider.Add(tag, colliders);
        }

        /// <summary>
        /// Удаление коллайдера по тегу
        /// </summary>
        /// <param name="tag"></param>
        public void Del(string tag)
        {
            if (collider != null && collider.Count != 0)
                collider.Remove(tag);
        }

        /// <summary>
        /// Обновление вершин всех коллайдеров
        /// </summary>
        /// <returns></returns>
        public List<Vector2[]> GetBoundCorners()
        {
            List<Vector2[]> BoundCorners = new List<Vector2[]>();

            foreach (var obj in collider)
            {
                obj.Value.UpdateBounds();
                BoundCorners.Add(obj.Value.BoundCorners);
            }

            return BoundCorners;
        }

        /// <summary>
        /// Проверка на пересечение со всеми объектами
        /// </summary>
        /// <returns>true, если есть пересечение </returns>
        public bool CheckGameObjectIntersection()
        {
            foreach (var obj in collider)
                if (obj.Value.CheckGameObjectIntersection())
                    return true;
            return false;
        }

        /// <summary>
        /// Проверка на пересечение с данными объектами
        /// </summary>
        /// <param name="otherGameObject"></param>
        /// <returns>true, если есть пересечение</returns>
        public bool CheckGameObjectIntersection(GameObject otherGameObject)
        {
            foreach (var obj in collider)
                if (obj.Value.CheckGameObjectIntersection(otherGameObject))
                    return true;

            return false;
        }

        /// <summary>
        /// Проверка на пересечение с данными объектами
        /// </summary>
        /// <param name="otherGameObject"></param>
        /// <returns>true, если есть пересечение</returns>
        public bool CheckGameObjectIntersection(out GameObject otherGameObject)
        {
            foreach (var obj in collider)
                if (obj.Value.CheckGameObjectIntersection(out otherGameObject))
                    return true;

            otherGameObject = null;
            return false;
        }

        /// <summary>
        /// Метод, находящий номер пересечённого коллайдера
        /// </summary>
        /// <param name="intersecredGameObject"></param>
        /// <returns></returns>
        public virtual int? GetNumberColliderIntersection(GameObject intersecredGameObject)
        {
            int number = 0;

            foreach(var obj in collider)
            {
                number++;
                if (obj.Value.CheckGameObjectIntersection(intersecredGameObject))
                    return number;
            }

            return null;
        }


        public void DeleteGameObject(GameObject gameObject)
        {
            foreach (var obj in collider)
                obj.Value.DeleteGameObject(gameObject);
        }

        /// <summary>
        /// Освобождение ресурсов
        /// </summary>
        public void Dispose()
        {
            collider.Clear();
        }

    }
}
