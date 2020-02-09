namespace TypedBindingIssueApp
{
    public class LongLifecycleModel : NotificationObject
    {
        private int nextId;

        public Entity Entity { get; private set; }

        public void Next()
        {
            nextId++;
            Entity = new Entity
            {
                Id = nextId,
                Name = $"Entity-{nextId}",
                Buffer = new byte[1024]
            };

            RaisePropertyChanged(nameof(Entity));
        }
    }
}
