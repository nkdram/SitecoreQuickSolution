using System.Runtime.CompilerServices;

namespace AppName.Core.Infrastructure
{
    public class PenContext
    {
        #region Methods

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static IAppEngine Initialize()
        {
            if (Singleton<IAppEngine>.Instance == null)
            {
                Singleton<IAppEngine>.Instance = new PenEngine();
                Singleton<IAppEngine>.Instance.Initialize();
            }

            return Singleton<IAppEngine>.Instance;
        }

        #endregion

        #region Properties

        public static IAppEngine Current
        {
            get
            {
                if (Singleton<IAppEngine>.Instance == null)
                {
                    Initialize();
                }

                return Singleton<IAppEngine>.Instance;
            }
        }

        #endregion
    }
}
