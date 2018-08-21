﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace tryRT
{
    class Capacity : INotifyPropertyChanged
    {
        private Node _start;
        public Node Start
        {
            get { return _start; }
            set
            {
                _start = value;
                OnPropertyChanged("Start");
            }
        }
        private Rect _end;
        public Rect End
        {
            get { return _end; }
            set
            {
                _end = value;
                OnPropertyChanged("End");
            }
        }
        private double _length = 0;
        public double Length
        {
            get { return _length; }
            set
            {
                _length = value;
                OnPropertyChanged("Length");
            }
        }
        private double _diameter = 0;
        public double Diameter
        {
            get { return _diameter; }
            set
            {
                _diameter = value;
                OnPropertyChanged("Diameter");
            }
        }


        public double X
        {
            get { return 0; }
            set { }
        }

        public double Y
        {
            get { return 0; }
            set { }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }

}