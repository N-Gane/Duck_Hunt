using System.Collections.Generic;


namespace GameLibrary.Bullet
{
    public class BulletBox
    {
        /// <summary>
        /// Текущий тип пуль
        /// </summary>
        public Bullet Bullet { get; set; }

        int indexBullet;

        /// <summary>
        /// Лист с различными видами пуль
        /// </summary>
        List<Bullet> Bullets;

        /// <summary>
        /// Конструктор класса
        /// </summary>
        public BulletBox()
        {
            Bullets = new List<Bullet>();
            indexBullet = 0;
        }

        /// <summary>
        /// Добавление пуль
        /// </summary>
        /// <param name="bullet"></param>
        public void Add(Bullet bullet)
        {
            foreach (var bull in Bullets)
            {
                if (bull.GetType() == bullet.GetType())
                {
                    Bullets[Bullets.IndexOf(bull)].Add(bullet.Count);

                    return;
                }
            }

            if (Bullet == null)
                Bullet = bullet;

            Bullets.Add(bullet);
        }

        /// <summary>
        /// Удаления пуль
        /// </summary>
        /// <param name="bullet"></param>
        public void Del(Bullet bullet)
        {
            Bullets.Remove(bullet);
        }

        /// <summary>
        /// Замена типа пуль
        /// </summary>
        public void Switch()
        {

            if(Bullet.Count != 0)
            {
                indexBullet++;
                Bullet = Bullets[indexBullet];
            }
            else
            {
                indexBullet = 0;
                Bullet = Bullets[indexBullet];
            }
        }

        /// <summary>
        /// Установка типа пуль
        /// </summary>
        /// <param name="index"></param>
        public void Set(int index)
        {
            Bullet = Bullets[index];
        }

    }
}
