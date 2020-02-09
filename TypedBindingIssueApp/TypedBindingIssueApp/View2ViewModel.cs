namespace TypedBindingIssueApp
{
    public class View2ViewModel
    {
        public static View2ViewModel DesignInstance { get; } = null; // For design

        public LongLifecycleModel LongLifecycleModel { get; }

        public View2ViewModel(LongLifecycleModel longLifecycle)
        {
            LongLifecycleModel = longLifecycle;
        }
    }
}
