using Gas_Laws.Base;
using Gas_Laws.Pages;
using System.Windows.Controls;

namespace Gas_Laws.ViewModels
{
    public class MainViewModel : BaseViewModel
    {
        public BoylesVM MyBoylesVM;
        public Page MyBoylesPage;

        public Page MyLussacsPage;


        public Page MyCharlesPage;

        private Page _curentPage;
        public Page CurentPage
        {
            get { return _curentPage; }
            set { _curentPage = value; OnPropertyChanged("CurentPage"); }
        }


        public MainViewModel()
        {
            MyBoylesPage = ViewModelLocator.Boyles_Law;
            MyBoylesVM = ViewModelLocator.BoylesVM;

            MyLussacsPage = ViewModelLocator.Gay_Lussacs_Law;

            MyCharlesPage = ViewModelLocator.Charles_Law;

            CurentPage = MyBoylesPage;
        }


        private RelayCommand goToBoylesPage;
        public RelayCommand GoToBoylesPage
        {
            get
            {
                return goToBoylesPage ??
                    (goToBoylesPage = new RelayCommand(obj =>
                    {
                        this.CurentPage = MyBoylesPage;
                    }));
            }
        }

        private RelayCommand goToLussacsPage;
        public RelayCommand GoToLussacsPage
        {
            get
            {
                return goToLussacsPage ??
                    (goToLussacsPage = new RelayCommand(obj =>
                    {
                        this.CurentPage = MyLussacsPage;
                    }));
            }
        }

        private RelayCommand goToCharlesPage;
        public RelayCommand GoToCharlesPage
        {
            get
            {
                return goToCharlesPage ??
                    (goToCharlesPage = new RelayCommand(obj =>
                    {
                        this.CurentPage = MyCharlesPage;
                    }));
            }
        }

        private RelayCommand goToBrowser;
        public RelayCommand GoToBrowser
        {
            get
            {
                return goToBrowser ??
                    (goToBrowser = new RelayCommand(obj =>
                    {
                        System.Diagnostics.Process.Start("https://en.wikipedia.org/wiki/Gas_laws#Charles'_law");
                    }));
            }
        }

        private RelayCommand openAP;
        public RelayCommand OpenAP
        {
            get
            {
                return openAP ??
                    (openAP = new RelayCommand(obj =>
                    {
                        About_Program a = new About_Program();
                        a.Show();
                    }));
            }
        }

        private RelayCommand openVis;
        public RelayCommand OpenVis
        {
            get
            {
                return openVis ??
                    (openVis = new RelayCommand(obj =>
                    {
                        Porshen a = new Porshen();
                        a.Show();
                    }));
            }
        }

    }
}
