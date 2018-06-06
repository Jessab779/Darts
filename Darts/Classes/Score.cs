using System;
using System.ComponentModel;

namespace Darts.Classes
{
    public class Score : INotifyPropertyChanged
    {

        private int _intScoreNo;
        private int _intHomeScore;
        private int _intHomeRemaining;
        private int _intAwayScore;
        private int _intAwayRemaining;

        public Score()
        {
        }

        public int ScoreNo
        {
            get { return _intScoreNo; }
            set
            {
                if (_intScoreNo != value)
                {
                    _intScoreNo = value;
                    RaisedOnPropertyChanged("ScoreNo");
                }
            }
        }

        public int HomeScore
        {
            get { return _intHomeScore; }
            set
            {
                if (_intHomeScore != value)
                {
                    _intHomeScore = value;
                    RaisedOnPropertyChanged("HomeScore");
                }
            }
        }
        public int HomeRemaining
        {
            get { return _intHomeRemaining; }
            set
            {
                if (_intHomeRemaining != value)
                {
                    _intHomeRemaining = value;
                    RaisedOnPropertyChanged("HomeRemaining");
                }
            }
        }


        public int AwayScore
        {
            get { return _intAwayScore; }
            set
            {
                if (_intAwayScore != value)
                {
                    _intAwayScore = value;
                    RaisedOnPropertyChanged("AwayScore");
                }
            }
        }
        public int AwayRemaining
        {
            get { return _intAwayRemaining; }
            set
            {
                if (_intAwayRemaining != value)
                {
                    _intAwayRemaining = value;
                    RaisedOnPropertyChanged("AwayRemaining");
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaisedOnPropertyChanged(string _PropertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(_PropertyName));
            }
        }

    }
}
