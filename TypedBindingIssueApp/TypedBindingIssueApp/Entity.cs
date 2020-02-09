namespace TypedBindingIssueApp
{
    public class Entity : NotificationObject
    {
        private int id;

        public int Id
        {
            get => id;
            set => SetProperty(ref id, value);
        }

        private string name;

        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        private byte[] buffer;

        public byte[] Buffer
        {
            get => buffer;
            set => SetProperty(ref buffer, value);
        }
    }
}
