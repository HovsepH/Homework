namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomList<int> ints = new CustomList<int>();

            ints.ElementAdded_Event += EventSubscriber.ElementAdded;

            ints.ElementRemoved_Event += EventSubscriber.ElementRemoved;

            ints.Add(1);

            ints.Add(2);

            ints.Add(3);

            ints.Remove(1);

            foreach (var item in ints)
            {
                Console.Write(item + " ");
            }
        }

    }
}
