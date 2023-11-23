namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void DropGestureRecognizer_Drop(object sender, DropEventArgs e)
        {
            var control = (BoxView)e.Data.Properties["control"];

            // remove from current layout
            ((Layout)control.Parent).Children.Remove(control);

            // add to layout it has been dropped on
            var dgr = (DropGestureRecognizer)sender;
            var dropLayout = (Layout)dgr.Parent;
            dropLayout.Children.Add(control);
        }

        private void DragGestureRecognizer_DragStarting(object sender, DragStartingEventArgs e)
        {
            var dgr = (DragGestureRecognizer)sender;
            var boxView = (BoxView)dgr.Parent;
            boxView.BackgroundColor = Colors.Black;
            e.Data.Properties.Add("control", boxView);
        }

        private void DragGestureRecognizer_DropCompleted(object sender, DropCompletedEventArgs e)
        {
            var dgr = (DragGestureRecognizer)sender;
            var boxView = (BoxView)dgr.Parent;
            boxView.BackgroundColor = Colors.White;
        }
    }
}
