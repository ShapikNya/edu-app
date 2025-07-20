using Gas_Laws.Base;
using Gas_Laws.Models;
using System.Collections.Generic;

namespace Gas_Laws.ViewModels
{
    public class CharlesVM : BaseViewModel
    {
        private CharlesModel MyCharlesModel = new CharlesModel();

        private int mtx_row;
        private int mtx_col;
        private string _ex;

        private Dictionary<int, bool> _vis = new Dictionary<int, bool>();

        private Dictionary<int, double> _val = new Dictionary<int, double>();

        public CharlesVM()
        {
            mtx_row = 2;
            mtx_col = 2;



            for (int i = 1; i < mtx_row + 1; i++)
            {
                for (int j = 1; j < mtx_col + 1; j++)
                {
                    _vis[i * 10 + j] = true;
                    _val[i * 10 + j] = 0;
                }
            }
        }


        public bool Vis11
        {
            get
            {
                return _vis[11];
            }
            set
            {
                _vis[11] = value;
            }
        }
        public bool Vis12
        {
            get
            {
                return _vis[12];
            }
            set
            {
                _vis[12] = value;
            }
        }
        public bool Vis21
        {
            get
            {
                return _vis[21];
            }
            set
            {
                _vis[21] = value;
            }
        }
        public bool Vis22
        {
            get
            {
                return _vis[22];
            }
            set
            {
                _vis[22] = value;
            }
        }

        public double Val11
        {
            get
            {
                return _val[11];
            }
            set
            {
                _val[11] = value; SetVisible();
            }
        }
        public double Val12
        {
            get
            {
                return _val[12];
            }
            set
            {
                _val[12] = value; SetVisible();
            }
        }
        public double Val21
        {
            get
            {
                return _val[21];
            }
            set
            {
                _val[21] = value; SetVisible();
            }
        }
        public double Val22
        {
            get
            {
                return _val[22];
            }
            set
            {
                _val[22] = value; SetVisible();
            }
        }

        public string Ex
        {
            set { _ex = value; }
            get { return _ex; }
        }

        private RelayCommand showRes;
        public RelayCommand ShowRes
        {
            get
            {
                return showRes ??
                    (showRes = new RelayCommand(obj =>
                    {
                        OnPropertyChanged("Ex");
                    }));
            }
        }


        public void SetVisible()
        {
            int _emptyCell = 0;

            for (int i = 1; i < mtx_row + 1; i++)
            {
                for (int j = 1; j < mtx_col + 1; j++)
                {
                    if (_val[i * 10 + j] == 0) _emptyCell++;
                }
            }

            if (_emptyCell == 1)
            {
                for (int i = 1; i < mtx_row + 1; i++)
                {
                    for (int j = 1; j < mtx_col + 1; j++)
                    {
                        if (_val[i * 10 + j] == 0)
                        {
                            _vis[i * 10 + j] = false;
                            OnPropertyChanged("Vis" + (i * 10 + j));
                            Ex = MyCharlesModel.GetEx(_val);
                            break;
                        }
                    }
                }
            }
            else
            {
                for (int i = 1; i < mtx_row + 1; i++)
                {
                    for (int j = 1; j < mtx_col + 1; j++)
                    {
                        if (_vis[i * 10 + j] == false)
                        {
                            _vis[i * 10 + j] = true;
                            OnPropertyChanged("Vis" + (i * 10 + j));
                            Ex = "";
                            OnPropertyChanged("Ex");
                            break;
                        }
                    }
                }
            }

        }
    }
}
