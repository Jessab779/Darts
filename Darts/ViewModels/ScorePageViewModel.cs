using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Darts.Classes;

namespace Darts.ViewModels
{
    public class ScorePageViewModel : INotifyPropertyChanged
    {
        public ScorePageViewModel()
        {
            scoreInfo = new ObservableCollection<Score>();
            this.GenerateScores();
        }

        public event PropertyChangedEventHandler PropertyChanged = delegate {};

        private ObservableCollection<Score> scoreInfo;
        public ObservableCollection<Score> ScoreInfoCollection
        {
            get { return scoreInfo; }
            set { this.scoreInfo = value; }
        }

        private void GenerateScores()
        {
            scoreInfo.Add(new Score());
            scoreInfo.Add(new Score() { ScoreNo = 1, HomeScore = 60, AwayScore = 45 });
            scoreInfo.Add(new Score() { ScoreNo = 2, HomeScore = 100, AwayScore = 26 });
            scoreInfo.Add(new Score() { ScoreNo = 3, HomeScore = 41, AwayScore = 120 });
            scoreInfo.Add(new Score() { ScoreNo = 4, HomeScore = 60, AwayScore = 85 });

            CalculateScores();
        }

        public void CalculateScores()
        {
            var intHomeRemaining = 501;
            var intAwayRemaining = 501;

            foreach(Score score in scoreInfo)
            {
                intHomeRemaining -= score.HomeScore;
                score.HomeRemaining = intHomeRemaining;

                intAwayRemaining -= score.AwayScore;
                score.AwayRemaining = intAwayRemaining;
            }
            PropertyChanged(this, new PropertyChangedEventArgs("ScoreInfoCollection"));
        }
    }
}
