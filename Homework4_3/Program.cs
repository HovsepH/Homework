namespace Homework4_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector vector=new Vector(3,4);

            Coordinate coordinate = new Coordinate(6, 7);

            vector = coordinate;

            coordinate = (Coordinate)vector;
        }
    }
}
