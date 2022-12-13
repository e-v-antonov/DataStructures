namespace DataStructures.Model
{
    public  class ItemStack<T>
    {
        public T Data { get; set; }
        
        public ItemStack<T> Previous { get; set; }

        public ItemStack(T data)
        {
            Data = data;
        }

        public override string ToString()
        {
            return Data.ToString();
        }
    }
}
