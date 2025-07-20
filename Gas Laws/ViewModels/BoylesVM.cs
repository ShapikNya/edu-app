using Gas_Laws.Base;
using Gas_Laws.Models;
using System.Collections.Generic;
using LiveCharts;
using LiveCharts.Defaults;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;
using System.Windows;

using System.Threading;
using System.Threading.Tasks;
using System.Linq;
using LiveCharts.Geared;
using System;
using Gas_Laws.Pages;



namespace Gas_Laws.ViewModels
{
    public class BoylesVM : BaseViewModel
    {
        private BoylesModel MyBoylesModel = new BoylesModel();
        private double _trend;
        private int max_Values;
        private int max_Labels;
        private double x;
        private double y;
        private double shag;
        private bool flag;
        private double _V;
        private double _P;
        private double _VP;

        private string _axisX;
        private string _axisY;
        private string _series;

        private double _BasisPercent;
        private double _V_Length;
        private double _V_Length_old;

        private string _color;
        Porshen por;


        private Dictionary<int, bool> _vis;

        private bool _new;


        private List<string> _labels;
        public GearedValues<double> MyValues { get; set; }

        public double BasisPercent
        {
            get
            {
                _BasisPercent = _V / 100;
                return (_V / 100);
            }
        }

        public string Color
        {
            get
            {
                return _color;
            }
        }

        public double Ex
        {
            get
            {
                return x;
            }
        }

        public double Y
        {
            get
            {
                return y; 
            }
        }

        public double Vlength
        {
            get
            {
                double val = (x / _BasisPercent);
                //MessageBox.Show("Vlength get x per   "+ x.ToString() + " " + _BasisPercent.ToString() + " " + val.ToString());
                if (val >= 10 && val <= 200)
                {
                    _V_Length_old = val;

                    if (val > 150 && val <= 200)
                    {
                        _color = "#326da8"; OnPropertyChanged("Color");
                    }
                    else
                    {
                        if (val > 99 && val <= 150)
                        {
                            _color = "#7992ab"; OnPropertyChanged("Color");         
                        }
                        else
                        {
                            if (val > 50 && val <= 100)
                            {
                                _color = "#ab7981"; OnPropertyChanged("Color");
                            }
                            else
                            {
                                _color = "#a6293d"; OnPropertyChanged("Color");
                            }
                        }
                    }

                    return val;
                }
                return _V_Length_old;
            }
        }

        public bool Vis1
        {
            get
            {
                return _vis[1];
            }
            set
            {
                _vis[1] = value;
            }
        }

        public bool Vis2
        {
            get
            {
                return _vis[2];
            }
            set
            {
                _vis[2] = value;
            }
        }

        public bool Vis3
        {
            get
            {
                return _vis[3];
            }
            set
            {
                _vis[3] = value;
            }
        }

        public bool Vis4
        {
            get
            {
                return _vis[4];
            }
            set
            {
                _vis[4] = value;
            }
        }

        public bool Vis5
        {
            get
            {
                return _vis[5];
            }
            set
            {
                _vis[5] = value;
            }
        }

        public bool Vis6
        {
            get
            {
                return _vis[6];
            }
            set
            {
                _vis[6] = value;
            }
        }

        public bool Vis7
        {
            get
            {
                return _vis[7];
            }
            set
            {
                _vis[7] = value;
            }
        }

        private int _mode;
        public int Mode
        {
            get
            {
                return _mode;
            }
            set
            {
                _mode = value;
                switch (value)
                {
                    case 0:
                        break;
                    case 1:
                        break;
                }
            }
        }

        private int _par;
        public int Par
        {
            get
            {
                return _par;
            }
            set
            {
                _par = value;

                switch (value)
                {
                    case 0:
                        _axisX = "V (м³)"; OnPropertyChanged("axisX");
                        _axisY = "p (Па)"; OnPropertyChanged("axisY");
                        _series = "p ="; OnPropertyChanged("Series");
                        break;
                    case 1:
                        _axisX = "p (Па)"; OnPropertyChanged("axisX");
                        _axisY = "V (м³)"; OnPropertyChanged("axisY");
                        _series = "V ="; OnPropertyChanged("Series");
                        break;
                }
            }
        }

        public double Shag
        {
            get
            {
                return shag;
            }
            set
            {
                shag = value;
            }
        }

        public string axisX
        {
            get
            {
                return _axisX;
            }
            set
            {
                _axisX = value;
            }
        }

        public string axisY
        {
            get
            {
                return _axisY;
            }
            set
            {
                _axisY = value;
            }
        }

        public string Series
        {
            get
            {
                return _series;
            }
            set
            {
                _series = value;
            }
        }


        public double V 
        {
            get
            {
                return _V;
            }
            set
            {
                _V = value; _VP = _V * _P; OnPropertyChanged("BasisPercent");
            }
        }

        public double P
        {
            get
            {
                return _P;
            }
            set
            {
                _P = value; _VP = _V * _P;
            }
        }

        public double VP
        {
            get
            {
                return _VP;
            }
            set
            {
                _VP = value;
            }
        }



        public string[] Labels 
        { 
            get 
            {
                return _labels.ToArray();
            }
        }

        public string[] Values
        {
            get
            {
                string[] val =  new string[MyValues.Count];
                for (int i = 0; i < MyValues.Count; i++)
                {
                    val[i] = MyValues[i].ToString();
                }
                return val;
            }
        }



        public BoylesVM()
        {

            _labels = new List<string>();
            _vis = new Dictionary<int, bool>();

            MyValues = new GearedValues<double>().WithQuality(Quality.High);
            x = 0;

            _mode = 0;
            _axisX = "V (м³)";
            _axisY = "p (Па)";
            _series = "p =";
            shag = 0.3;
            _new = true;
            _vis[1] = true; _vis[2] = true; _vis[3] = true; _vis[4] = true; _vis[5] = true; _vis[6] = false; _vis[7] = false;
            _V_Length = 100;
            _V_Length_old = 101;
            _color = "#7992ab";
            y= 0;

        }



        public void add()
        {
            //MessageBox.Show(Vlength.ToString() + Color.ToString());
            if (_new  == true)
            {
                if (_V <= 0 || _P <= 0) 
                {
                   
                    MessageBox.Show("Параметры должны быть больше 0!");

                    return;
                }
                _vis[1] = false; OnPropertyChanged("Vis1");
                _vis[2] = false; OnPropertyChanged("Vis2");

                _vis[5] = false; OnPropertyChanged("Vis5");
                _vis[6] = true; OnPropertyChanged("Vis6");
                _vis[7] = false; OnPropertyChanged("Vis7");
                max_Values = 100;
                max_Labels = 100;

                if (_par == 0)
                {
                    x = _V; OnPropertyChanged("Ex");
                }
                else
                {
                    x = _P;
                }
                y = Math.Round(_VP / x, 3);
                MyValues.Add(Y); _labels.Add(x.ToString()); OnPropertyChanged("Labels"); OnPropertyChanged("Y");
            }
            flag = true;
            Task task1 = new Task(() =>
            {
                while ( flag== true)
                {
                    Thread.Sleep(1000);
                    switch (_par)
                    {
                        case 0:
                            switch (_mode)
                            {
                                 case 0:
                                 x = x + shag; OnPropertyChanged("Ex");
                                    break;

                                 case 1:
                                    if (x-shag <= 0.1)
                                    {
                                        MessageBox.Show("Достигнут физический предел параметра!");
                                        _new = false;
                                        _vis[5] = true; OnPropertyChanged("Vis5");
                                        _vis[6] = false; OnPropertyChanged("Vis6");
                                        _vis[7] = true; OnPropertyChanged("Vis7");
                                        return;
                                    }
                                    x = x - shag; OnPropertyChanged("Ex");
                                    break;
                             }
                           
                            y = Math.Round(_VP / x, 3);
                            MyValues.Add(Y); OnPropertyChanged("Y");
                            _labels.Add(x.ToString());
                            OnPropertyChanged("Vlength");
                            OnPropertyChanged(BasisPercent.ToString());
                            break;

                        case 1:
                            switch (_mode)
                            {
                                case 0:
                                    x = x + shag;
                                    break;

                                case 1:
                                    x = x - shag;
                                    break;
                            }
                            y = Math.Round(_VP / x, 3);
                            MyValues.Add(Y);
                            _labels.Add(x.ToString());
                            break;
                    }

                    OnPropertyChanged("Labels");
                    OnPropertyChanged("Values");

                    if (MyValues.Count > max_Values)
                    {
                        MyValues.RemoveAt(0);
                    }

                    if (_labels.Count > max_Labels)
                    {
                        _labels.RemoveAt(0);
                    }

                }
            });
            task1.Start();
        }




        private RelayCommand dataAdd;
        public RelayCommand DataAdd
        {
            get
            {
                return dataAdd ??
                    (dataAdd = new RelayCommand(obj =>
                    {
                            add();
                    }));
            }
        }


        private RelayCommand stop;
        public RelayCommand Stop
        {
            get
            {
                return stop ??
                    (stop = new RelayCommand(obj =>
                    {
                        flag=false;
                        _new=false;

                        _vis[5] = true; OnPropertyChanged("Vis5");
                        _vis[6] = false; OnPropertyChanged("Vis6");
                        _vis[7] = true; OnPropertyChanged("Vis7");

                    }));
            }
        }

        private RelayCommand clear;
        public RelayCommand Clear
        {
            get
            {
                return clear ??
                    (clear = new RelayCommand(obj =>
                    {
                        MyValues.Clear();
                        _labels.Clear(); 
                        _new = true;

                        _vis[1] = true; OnPropertyChanged("Vis1");
                        _vis[2] = true; OnPropertyChanged("Vis2");

                        _vis[5] = true; OnPropertyChanged("Vis5");
                        _vis[6] = false; OnPropertyChanged("Vis6");
                        _vis[7] = false; OnPropertyChanged("Vis7");

                        OnPropertyChanged(_V.ToString());
                        x = _V;
                        y = _P;
                        _V_Length = 101;
                        OnPropertyChanged("Ex");
                        OnPropertyChanged("Y");
                        OnPropertyChanged("BasisPercent");
                        OnPropertyChanged("Vlength");

                    }));
            }
        }

        private RelayCommand mode_min;
        public RelayCommand Mode_min
        {
            get
            {
                return mode_min ??
                    (mode_min = new RelayCommand(obj =>
                    {
                        _mode = 1;
                    }));
            }
        }


        private RelayCommand mode_plus;
        public RelayCommand Mode_plus
        {
            get
            {
                return mode_plus ??
                    (mode_plus = new RelayCommand(obj =>
                    {
                        _mode = 0;
                    }));
            }
        }
     
    }
}