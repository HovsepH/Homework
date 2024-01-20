namespace Homework3
{
    public class CustomEventArgs : EventArgs
    {
        public string message { get; }
        public CustomEventArgs(string msg)
        {
            message = msg;
        }

    }
}
