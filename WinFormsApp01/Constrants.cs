namespace WinFormsApp01
{
    public class Constrants
    {
        // 单例模式
        private static Constrants _instance = null;

        public static Constrants INSTANCE
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Constrants();
                }

                return _instance;
            }
        }

        public string username;
    }
}
