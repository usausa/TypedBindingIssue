namespace TypedBindingIssueApp
{
    public static class DependencyResolver
    {
        private static LongLifecycleModel longLifecycleModel;

        public static LongLifecycleModel GetLongLifecycleModel() =>
            longLifecycleModel ?? (longLifecycleModel = new LongLifecycleModel());

        public static View1ViewModel GetView1ViewModel() =>
            new View1ViewModel(GetLongLifecycleModel());

        public static View2ViewModel GetView2ViewModel() =>
            new View2ViewModel(GetLongLifecycleModel());
    }
}
