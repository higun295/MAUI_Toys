using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMAVLER_TabView.Controls
{
    public abstract class TabTextItem : TabItem
    {
        public TabTextItem()
        {
                
        }

        public static readonly BindableProperty LabelProperty = BindableProperty.Create
        (
            nameof(Label),
            typeof(string),
            typeof(TabTextItem),
            string.Empty
        );


        public string Label
        {
            get => (string)GetValue(LabelProperty);
            set => SetValue(LabelProperty, value);
        }
    }
}
