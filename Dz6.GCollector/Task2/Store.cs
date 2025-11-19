namespace Dz6.GCollector.Task2
{
    public  class Store(string name, string address, StoreTypeEnum storeType) : IDisposable
    {
        public string Name { get; set; } = name;
        public string Address { get; set; } = address;
        public StoreTypeEnum StoreType { get; set; } = storeType;

        private bool disposed = false;

        public void ChangeAddress(string newAddress)
        {
            if (disposed)
                throw new ObjectDisposedException(nameof(Store));

            Address = newAddress;
            Console.WriteLine($"New address \"{Name}\": {Address}");
        }

        public void PrintInfo()
        {
            if (disposed)
                throw new ObjectDisposedException(nameof(Store));

            Console.WriteLine($"Store: \"{Name}\", address: {Address}, type: {StoreType}");
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if(disposed)
                return;

            if(disposing)
                Console.WriteLine($"Class Store: {Name} has been disposed");

            disposed = true;
        }

        ~Store()
        {
            Console.WriteLine($"Class Store has deleted");
            Dispose(false);
        }
    }
}
