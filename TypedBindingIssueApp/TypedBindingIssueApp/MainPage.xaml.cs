namespace TypedBindingIssueApp
{
    using System;
    using System.ComponentModel;
    using System.Threading.Tasks;

    using Xamarin.Forms;

    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage
    {
        private readonly LongLifecycleModel longLifecycleModel;

        public MainPage()
        {
            InitializeComponent();

            longLifecycleModel = DependencyResolver.GetLongLifecycleModel();
        }

        private async void Button_OnClicked(object sender, EventArgs e)
        {
            // Simulation of page transition
            for (var i = 0; i < 1000; i++)
            {
                // Exception triggered by this update
                longLifecycleModel.Next();

                if (i % 2 == 0)
                {
                    ReplaceView(new View1
                    {
                        BindingContext = DependencyResolver.GetView1ViewModel()
                    });
                }
                else
                {
                    ReplaceView(new View2
                    {
                        BindingContext = DependencyResolver.GetView2ViewModel()
                    });
                }

                await Task.Delay(10);
            }

            Cleanup();
        }

        private void ReplaceView(ContentView view)
        {
            Cleanup();

            AbsoluteLayout.SetLayoutFlags(view, AbsoluteLayoutFlags.WidthProportional | AbsoluteLayoutFlags.HeightProportional);
            AbsoluteLayout.SetLayoutBounds(view, new Rectangle(0, 0, 1, 1));

            Container.Children.Add(view);
        }

        private void Cleanup()
        {
            // If you clear the BindingContext of the old View, no problem occurs?
            //foreach (var view in Container.Children)
            //{
            //    view.BindingContext = null;
            //}

            Container.Children.Clear();
        }
    }
}
