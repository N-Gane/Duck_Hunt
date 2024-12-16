namespace GameEngine
{
    public abstract class FPS
    {

        static float timer;
        static int currAccoun;

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
