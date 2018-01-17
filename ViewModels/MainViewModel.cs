namespace MultiplataformApp.MainViewModel
{
    using ViewModels;

    public class MainViewModel
    {
        #region Propierties
        public ConvertViewModel Convert
        {
            get;
            set;
        }

        public CategoriesViewModel Categories
        {
            get;
            set;
        }
        #endregion

        #region Constructors
        public MainViewModel()
        {
            instance = this;
            Convert = new ConvertViewModel();
        }
        #endregion

        #region Singleton
        static MainViewModel instance;

        public static MainViewModel GetInstance()
        {
            if(instance == null)
            {
                return new MainViewModel();
            }

            return instance;
        }
        #endregion
    }
}
