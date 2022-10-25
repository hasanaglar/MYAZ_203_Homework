using Hafta_2;

namespace Hafta_2
{
    class Program
    {
        static void Main(string[] args)
        {
            var employee = new Employee();
            employee.Add(new Employee(1, "Ahmet", "Yılmaz", 40, 7));
            employee.Add(new Employee(2, "Merve", "Aslan", 24, 5));
            employee.Add(new Employee(3, "Elif", "Dağ", 42, 15));
            employee.Add(new Employee(4, "Hamza", "Hancı", 33, 9));
            employee.Add(new Employee(5, "Hasan", "Kaan", 28, 5));
            employee.Add(new Employee(6, "Züheyla", "Göktürk", 27, 3));

            var list = employee.GetEmployees();
            foreach (var e in list)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }
    }
}
