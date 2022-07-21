using BusinessLayer;

namespace ProjectStudent
{
    class program
    {
        static void Main(string[] args)
        {
            StudentManager sm = new StudentManager();
            foreach (var item in sm.GetAll())
            {
                Console.WriteLine("Name:" + item.StudentName);

            }
            Console.ReadKey();
        }
    }
}
