namespace GameEngine
{
    public abstract class FPS
    {
        private static float timer;
        private static int currAccoun;

        public static int CurrAccount { get; private set; }

        public static void Update(float deltatime)
        {
            timer += deltatime;
            currAccoun++;

            if (timer >= 1)
            {
                timer = 0;
                CurrAccount = currAccoun;
                currAccoun = 0;
            }
        }
    }
}