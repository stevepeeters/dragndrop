namespace MauiApp1
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void DragGestureRecognizer_DragStarting(object sender, DragStartingEventArgs e)
        {
            var dgr = (DragGestureRecognizer)sender;
            var boxView = (BoxView)dgr.BindingContext;
            e.Data.Properties.Add("control", boxView);

            boxView.BackgroundColor = Colors.Black;
        }

        private void DragGestureRecognizer_DropCompleted(object sender, DropCompletedEventArgs e)
        {
            var dgr = (DragGestureRecognizer)sender;
            var boxView = (BoxView)dgr.BindingContext;

            boxView.BackgroundColor = Colors.White;
        }

        private void DropGestureRecognizer_Drop(object sender, DropEventArgs e)
        {
            var vm = (ViewModel)BindingContext;
            var control = (BoxView)e.Data.Properties["control"];

            var dropTarget = ((DropGestureRecognizer)sender).Parent;

            if (dropTarget == topLayout)
            {
                if (vm.BottomDraggableViews.Remove(control))
                    vm.TopDraggableViews.Add(control);
            }
            else if (dropTarget == bottomLayout)
            {
                if (vm.TopDraggableViews.Remove(control))
                    vm.BottomDraggableViews.Add(control);
            }
        }
    }
}
