using Kurs_2;
using Kurs_2.Data;
using Kurs_2.Entities;
using Kurs_2.Repositories;
using System.Windows.Forms;
namespace Kurs_2
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());

            

            //var employeeRepository = new GenericRepository<Employee>();

            //employeeRepository.Add(new Employee { FirstName = "Ania", LastName = "Majewska" });
            //employeeRepository.Add(new Employee { FirstName = "Frania", LastName = "Bajewska" });
            //employeeRepository.Add(new Employee { FirstName = "Mania", LastName = "Czajkowska" });
            //employeeRepository.Save();

            //var sqlRepository = new SqlRepository(new MotoAppDbContext());
            //sqlRepository.Add(new Employee { FirstName = "Ania", LastName = "Majewska" });
            //sqlRepository.Add(new Employee { FirstName = "Frania", LastName = "Bajewska" });
            //sqlRepository.Add(new Employee { FirstName = "Mania", LastName = "Czajkowska" });
            //sqlRepository.Save();

            //var emp = sqlRepository.GetById(1); // wyci¹ga pierwszy wpis z pamiêci
            //Console.WriteLine(emp.ToString());

            var employeeRepository = new SqlRepository<Employee>(new MotoAppDbContext());
            var buisnessPartnerRepository = new SqlRepository<BuisnessPartner>(new MotoAppDbContext());
            AddEmployees(employeeRepository);
            AddManagers(employeeRepository);
            AddBuisnessPartners(buisnessPartnerRepository);
            WriteAllToConsole(employeeRepository);
            WriteAllToConsole2(buisnessPartnerRepository);

            static void AddEmployees(IRepository<Employee> employeeRepository)
            {
                employeeRepository.Add(new Employee { FirstName = "Ania", LastName = "Majewska" });
                employeeRepository.Add(new Employee { FirstName = "Frania", LastName = "Bajewska" });
                employeeRepository.Add(new Employee { FirstName = "Mania", LastName = "Czajkowska" });
                employeeRepository.Save();
            }

            static void AddManagers(IWriteRepository<Manager> managerRepository)
            {
                managerRepository.Add(new Manager { FirstName = "Julia", LastName = "Wita", IdCode = "0001" });
                managerRepository.Add(new Manager { FirstName = "Sylwia", LastName = "Kita", IdCode = "0002" });
                managerRepository.Add(new Manager { FirstName = "Marta", LastName = "Karta", IdCode = "0003" });
                managerRepository.Save();
            }

            static void AddBuisnessPartners(IRepository<BuisnessPartner> buisnessPartnerRepository)
            {
                buisnessPartnerRepository.Add(new BuisnessPartner { Name = "Tomek"});
                buisnessPartnerRepository.Add(new BuisnessPartner { Name = "Romek"});
                buisnessPartnerRepository.Add(new BuisnessPartner { Name = "Wojtek"});
                buisnessPartnerRepository.Save();
            }

            static void WriteAllToConsole(IReadRepository<IEntity> repository)
            {
                var items = repository.GetAll().OrderBy(items =>items.Id);
                foreach (var item in items)
                {
                    Console.WriteLine(item);

                }
                
            }
            static void WriteAllToConsole2(IReadRepository<IEntity> repository)
            {
                var items = repository.GetAll();
                foreach (var item in items)
                {
                    Console.WriteLine(item);

                }

            }





        }
    }
}