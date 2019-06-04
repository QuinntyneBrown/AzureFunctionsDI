namespace AzureFunctionsDI
{
    public class MyService : IMyService
    {
        private int _value = 0;
        public int Get()
        {
            _value++;
            return _value;
        }
    }
}
