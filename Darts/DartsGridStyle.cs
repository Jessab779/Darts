using System;
using Syncfusion.SfDataGrid.XForms;
using Xamarin.Forms;

namespace Darts
{
    public class DartsGridStyle : DataGridStyle
    {
        public DartsGridStyle()
        {

        }
        public override Color GetBorderColor()
        {
            return Color.Black;
        }
    }
}
