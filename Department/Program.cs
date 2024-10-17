using System.Globalization;
using System.Runtime.Intrinsics.Arm;

namespace Department
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Department department = new Department();
            bool f = false; 
            bool g = false;
            do
            {
                
                Console.WriteLine("                                              DEPARTMENT                                       ");
                Console.WriteLine("1.Isci elave et\n2.Isci Axdar\n3.Butun Iscilere bax\n4.Maas araligina gore iscileri axdaris et\n0.Proqrami bitir");
                int a = Convert.ToInt32(Console.ReadLine());
                switch (a)
                {

                    case 1:
                        Console.Write("                                    ISCI DAXIL ETME                      ");
                        Console.Write("AD : ");
                        string ad = Convert.ToString(Console.ReadLine());
                        Console.Write("Soyad : ");
                        string soyad = Convert.ToString(Console.ReadLine());
                        int yas; 
                        do
                        {
                            Console.Write("Yas : ");
                            f=int.TryParse(Console.ReadLine(), out yas);

                        } while (!f);
                        int no;
                        do
                        {

                            Console.Write("Department no : ");
                           f = int.TryParse(Console.ReadLine(), out no);

                        } while (!f);

                        double maas;
                        do
                        {
                            Console.Write("Maas : ");
                            f= double.TryParse(Console.ReadLine(),out maas);

                        } while (!f);

                        Employee employee = new Employee(ad, soyad, yas, no, maas);
                        department.AddEmployee(employee);
                        Console.WriteLine("Isci elave olundu !");
                        break;
                    case 2:
                        Console.WriteLine("                                    SEARCH              ");
                        int id;
                        do
                        {
                            Console.Write("Axdardiginiz iscinin id-i daxil edin ");
                            f = int.TryParse(Console.ReadLine(),out id);
                        } while (!f);
                        department.GetEmployee(id);
                        break;
                    case 3:
                        Console.WriteLine("                         ISCILER                  ");
                        department.EmployeeInfo();
                        break;
                    case 4:
                        int minmaas;
                        do
                        {
                            Console.Write("Min maas daxil edin : ");
                            f = int.TryParse(Console.ReadLine(), out minmaas);
                        } while (!f);
                        int maxmaas;
                        do
                        {
                            Console.Write("Max maas daxil edin : ");
                            f=int .TryParse(Console.ReadLine(),out maxmaas);

                        } while (!f);
                        department.GetAllEmployeesBySalary(minmaas, maxmaas);
                        break;
                    case 0:
                        f = true;
                        break;








                }



















            }

            while (!g) ;



        }
    }
}
