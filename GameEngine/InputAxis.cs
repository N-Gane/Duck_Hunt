using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK.Input;

namespace GameEngine
{
    public static class InputAxis
    {
        /// <summary>
        /// Метод, возвращающий значение ввода основных осей направления
        /// </summary>
        /// <param name="axis">Ось направления</param>
        /// <returns>Положительное/отрицательное значение оси</returns>
        public static int GetAxis(AxisOfInput axis)
        {

            KeyboardState keyState = new KeyboardState();
            int move = 0;

            //try
            //{
            keyState = Keyboard.GetState();
            //}
            //catch { }

            switch (axis)
            {
                case AxisOfInput.Horizontal:
                    if (keyState.IsKeyDown(Key.D)) move--;
                    if (keyState.IsKeyDown(Key.A)) move++;
                    break;
                case AxisOfInput.Vertical:
                    if (keyState.IsKeyDown(Key.W)) move++;
                    if (keyState.IsKeyDown(Key.S)) move--;
                    break;
                case AxisOfInput.AlternativeHorizontal:
                    if (keyState.IsKeyDown(Key.Right)) move--;
                    if (keyState.IsKeyDown(Key.Left)) move++;
                    break;
                case AxisOfInput.AlternativeVertical:
                    if (keyState.IsKeyDown(Key.Up)) move++;
                    if (keyState.IsKeyDown(Key.Down)) move--;
                    break;
            }

            return move;
        }

        /// <summary>
        /// Метод, возвращающий реакцию на нажатие клавиши ввода
        /// </summary>
        /// <param name="key">Клавиша ввода</param>
        /// <returns>Реакция true или false</returns>
        public static bool GetButtonDown(Key key)
        {
            KeyboardState keyState = new KeyboardState();

            //try
            //{
                keyState = Keyboard.GetState();
            //}
            //catch { }

            return keyState.IsKeyDown(key);
        }

        /// <summary>
        /// Ось направления ввода
        /// </summary>
        public enum AxisOfInput
        {
            /// <summary>
            /// Горизонтальная ось
            /// </summary>
            Horizontal = 0,
            /// <summary>
            /// Вертикальная ось
            /// </summary>
            Vertical = 1,
            /// <summary>
            /// Альтернативная горизонтальная ось
            /// </summary>
            AlternativeHorizontal = 2,
            /// <summary>
            /// Альтернативная вертикальная ось
            /// </summary>
            AlternativeVertical = 3,
        }

    }
}
