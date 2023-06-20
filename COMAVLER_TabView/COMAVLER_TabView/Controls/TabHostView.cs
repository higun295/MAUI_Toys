using Google.Android.Material.Tabs;
using System.Collections.ObjectModel;

namespace COMAVLER_TabView.Controls;

[ContentProperty("Tabs")]
public class TabHostView : ContentView
{
    public static readonly BindableProperty TabsProperty = BindableProperty.Create
    (
        nameof(Tabs),
        typeof(ObservableCollection<TabItem>),
        typeof(TabHostView),
        defaultValueCreator: _ => new ObservableCollection<TabItem>()
    );

    public ObservableCollection<TabItem> Tabs
    {
        get => (ObservableCollection<TabItem>)GetValue(TabsProperty);
        set => SetValue(TabsProperty, value);
    }

    public TabHostView()
    {
    }
}