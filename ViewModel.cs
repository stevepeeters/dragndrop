using System.Collections.ObjectModel;

namespace MauiApp1
{
    public class ViewModel : BindableObject
    {
        public ObservableCollection<View> TopDraggableViews { get; set; } = new ObservableCollection<View>();
        public ObservableCollection<View> BottomDraggableViews { get; set; } = new ObservableCollection<View>();

        public ViewModel() 
        {
            TopDraggableViews.Add(new BoxView { BackgroundColor = Colors.White });
            TopDraggableViews.Add(new BoxView { BackgroundColor = Colors.White });
            TopDraggableViews.Add(new BoxView { BackgroundColor = Colors.White });
        }
    }
}
