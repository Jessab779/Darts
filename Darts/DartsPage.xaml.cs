using Darts.ViewModels;
using Xamarin.Forms;

namespace Darts
{
    public partial class DartsPage : ContentPage
    {
        public DartsPage()
        {
            InitializeComponent();
            dataGrid.QueryCellStyle += (s, e) =>
            {
                if (e.CellValue.ToString() == "0" && e.RowIndex == 1)
                {
                    e.Style.ForegroundColor = Color.DarkGray;
					e.Style.BackgroundColor = Color.DarkGray;
                }

                if (e.Column.MappingName == "ScoreNo")
                    e.Style.BackgroundColor = Color.DarkGray;
                
                e.Handled = true;
            };

            dataGrid.CurrentCellEndEdit += (s, e) =>
            {
                try {

                    var strData = e.NewValue.ToString();
                    var intNewScore = 0;

                    if (strData != string.Empty)
                    {
                        intNewScore = int.Parse(strData);

                        if (e.RowColumnIndex.ColumnIndex == 0)
                        {
                            (BindingContext as ScorePageViewModel).ScoreInfoCollection[e.RowColumnIndex.RowIndex - 1].HomeScore = intNewScore;
                        }

                        if (e.RowColumnIndex.ColumnIndex == 3)
                        {
                            (BindingContext as ScorePageViewModel).ScoreInfoCollection[e.RowColumnIndex.RowIndex - 1].AwayScore = intNewScore;
                        }
                    }
                    (BindingContext as ScorePageViewModel).CalculateScores();
                } catch (System.Exception ex){
                    System.Diagnostics.Debugger.Break();
                }
            };
        }


    }
}
