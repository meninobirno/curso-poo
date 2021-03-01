using System;
using WorkerContract.Entities;
using WorkerContract.Entities.Enum;

namespace WorkerContract
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual o departamento do usuário? ");
            string departmentName = Console.ReadLine();
            Console.WriteLine("Dados do usuário:");
            Console.Write("Nome: ");
            string workerName = Console.ReadLine();
            Console.Write("Nível(Junior/MidLevel/Senior): ");
            string workerLevel = Console.ReadLine();
            Console.Write("Salário base: ");
            double baseSalary = Double.Parse(Console.ReadLine());
            Console.Write("Quantos contratos para este usuário? ");
            int aux = int.Parse(Console.ReadLine());

            Department dept = new Department(departmentName);
            Worker worker = new Worker(workerName, Enum.Parse<WorkerLevel>(workerLevel), baseSalary, dept);
            
            for (int i = 1; i <= aux; i++)
            {
                HourContract contract = new HourContract();

                Console.WriteLine($"Insira os dados do contrato #{i}:");
                Console.Write("Data(DD/MM/AAAA): ");
                contract.Date = DateTime.Parse(Console.ReadLine());
                Console.Write("Valor da hora: R$");
                contract.ValuePerHour = double.Parse(Console.ReadLine());
                Console.Write("Duração (horas): ");
                contract.Hours = int.Parse(Console.ReadLine());

                worker.AddContract(contract);
            }
            Console.Write("Insira o mês e o ano para receber o ganho(MM/AAAA): ");
            string date = Console.ReadLine();
            int month = int.Parse(date.Substring(0, 2));
            int year = int.Parse(date.Substring(3));
            Console.WriteLine($"Nome: {worker.Name}");
            Console.WriteLine($"Departamento: {worker.Department.Name}");
            Console.WriteLine($"Ganho em {date}: R${worker.Income(year, month)}");

        }
    }
}
