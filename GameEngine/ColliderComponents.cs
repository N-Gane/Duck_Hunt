using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace GameEngine
{
    public class ColliderComponents
    {
        /// <summary>
        /// Конструктор класса
        /// </summary>
        /// <param name="scale">Размер коллайдера</param>
        /// <param name="offset">Смещения коллайдера от центра</param>
        public ColliderComponents(float scale = 1, Vector2 offset = new Vector2())
        {
            if (_colliderOfGameObjects == null)
                _colliderOfGameObjects = new List<GameObject>(50);

            _colliderScale = scale;
            _offsetCollider = offset;

            IsInactive = false;

            BoundCorners = new Vector2[4];
        }

        /// <summary>
        /// Список игровых объектов, имеющих твёрдое тело
        /// </summary>
        private static List<GameObject> _colliderOfGameObjects;

        /// <summary>
        /// Игровой объект, имеющий твёрдое тело
        /// </summary>
        private GameObject _gameObject;

        /// <summary>
        /// Масштаб твёрдого тела
        /// </summary>
        private float _colliderScale;

        /// <summary>
        /// Смещение твёрдого тела
        /// </summary>
        private Vector2 _offsetCollider;

        /// <summary>
        /// Вершины твёрдого тела
        /// </summary>
        public Vector2[] BoundCorners { get; private set; }

        /// <summary>
        /// Активность/неактивность объекта
        /// </summary>
        public bool IsInactive { get; private set; }

        /// <summary>
        /// Изменение активности твёрдого тела
        /// </summary>
        /// <param name="active"></param>
        public virtual void SetIsInactive(bool active)
        {
            IsInactive = active;
        }

        /// <summary>
        /// Изменение игрового объекта
        /// </summary>
        /// <param name="gameObject"></param>
        public virtual void SetGameObject(GameObject gameObject)
        {
            this._gameObject = gameObject;
            _colliderOfGameObjects.Add(gameObject);
        }

        /// <summary>
        /// Удаление игрового объекта из списка
        /// </summary>
        /// <param name="gameObject"></param>
        public virtual void DeleteGameObject(GameObject gameObject)
        {
            _colliderOfGameObjects.Remove(gameObject);
        }

        /// <summary>
        /// Проверка на пересечение со всеми объектами
        /// </summary>
        /// <returns></returns>
        public virtual bool CheckGameObjectIntersection()
        {
            foreach (var otherObject in _colliderOfGameObjects)
            {
                if (otherObject == _gameObject || otherObject.Collider.IsInactive)
                    continue;

                float otherGameObjectX = otherObject.Position.Location.X + (otherObject.Texture.Texture.Width * otherObject.Position.Scale.X);
                float otherGameObjectY = otherObject.Position.Location.Y + (otherObject.Texture.Texture.Height * otherObject.Position.Scale.Y) / 2;

                if (otherGameObjectX <= _gameObject.Position.Location.X + (_gameObject.Texture?.Texture.Width ?? 1) * _gameObject.Position.Scale.X && otherGameObjectX >= _gameObject.Position.Location.X)
                {
                    if (otherGameObjectY <= _gameObject.Position.Location.Y + (_gameObject.Texture?.Texture.Height ?? 1) * _gameObject.Position.Scale.Y && otherGameObjectX >= _gameObject.Position.Location.Y)
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Проверка на пересечение с данным объектом
        /// </summary>
        /// <param name="otherGameObject"></param>
        /// <returns></returns>
        public virtual bool CheckGameObjectIntersection(GameObject otherGameObject)
        {
            if (otherGameObject.Collider == null || otherGameObject == _gameObject || otherGameObject.Collider.IsInactive)
                return false;

            UpdateBounds();
            List<Vector2[]> otherBoundCornersList = otherGameObject.Collider.GetBoundCorners();

            foreach(var otherBoundCorners in otherBoundCornersList)
            {
                if (BoundCorners[1].X >= otherBoundCorners[0].X && BoundCorners[0].X <= otherBoundCorners[1].X
                    && BoundCorners[0].Y <= otherBoundCorners[1].Y && BoundCorners[1].Y >= otherBoundCorners[0].Y)
                    return true; 
            }

            return false;
        }

        /// <summary>
        /// Проверка на пересечение с данными объектами
        /// </summary>
        /// <param name="intersecctedGameObject"></param>
        /// <returns></returns>
        public virtual bool CheckGameObjectIntersection(out GameObject intersecctedGameObject)
        {
            foreach (var otherGameObject in _colliderOfGameObjects)
            {
                if (otherGameObject.Collider == null || otherGameObject == _gameObject || otherGameObject.Collider.IsInactive)
                    continue;

                UpdateBounds();
                List<Vector2[]> otherBoundCornersList = otherGameObject.Collider.GetBoundCorners();

                foreach (var otherBoundCorners in otherBoundCornersList)
                {
                    if (BoundCorners[1].X >= otherBoundCorners[0].X && BoundCorners[0].X <= otherBoundCorners[1].X
                        && BoundCorners[0].Y <= otherBoundCorners[1].Y && BoundCorners[1].Y >= otherBoundCorners[0].Y)
                    {
                        intersecctedGameObject = otherGameObject;
                        return true;
                    }
                }
            }

            intersecctedGameObject = null;
            return false;
        }


        /// <summary>
        /// Обновление вершин твёрдого тела
        /// </summary>
        public virtual void UpdateBounds()
        {
            Vector2 position = _gameObject.Position.Location;

            BoundCorners[0] = new Vector2((_offsetCollider.X - position.X), (_offsetCollider.Y - position.Y));
            BoundCorners[1] = new Vector2(((_gameObject.Texture?.Texture.Width ?? 1) * _gameObject.Position.Scale.X * _colliderScale + _offsetCollider.X - position.X),
               ((_gameObject.Texture?.Texture.Height ?? 1) * _gameObject.Position.Scale.Y * _colliderScale + _offsetCollider.Y - position.Y));
        }
    }
}
