namespace TypedBindingIssueApp
{
    public class View1ViewModel
    {
        public static View1ViewModel DesignInstance { get; } = null; // For design

        public LongLifecycleModel LongLifecycleModel { get; }

        public View1ViewModel(LongLifecycleModel longLifecycle)
        {
            LongLifecycleModel = longLifecycle;
        }
    }
}
