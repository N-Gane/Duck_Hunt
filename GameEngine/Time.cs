using System;
using System.Diagnostics;

namespace GameEngine
{
    public static class Time
    {

        static Time()
        {
            _watch = new Stopwatch();
            Reset();
        }

        private static Stopwatch _watch;
        private static long _previousTicks;

        /// <summary>
        /// Текущее время с запуска приложения
        /// </summary>
        public static float CurrentTime { get; private set; }

        /// <summary>
        /// Разница во времени между кадрами
        /// </summary>
        public static float DeltaTime { get; private set; }

        /// <summary>
        /// Обновление подсчитанных значений
        /// </summary>
        public static void UpdateTime()
        {
            long ticks = _watch.Elapsed.Ticks;

            CurrentTime = (float)ticks / TimeSpan.TicksPerSecond;
            DeltaTime = (float)(ticks - _previousTicks) / TimeSpan.TicksPerSecond;

            _previousTicks = ticks;
        }

        /// <summary>
        /// Сброс таймера и счётчика
        /// </summary>
        public static void Reset()
        {
            _watch.Reset();
            _watch.Start();
            _previousTicks = _watch.Elapsed.Ticks;
        }
    }
}
