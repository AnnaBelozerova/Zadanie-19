using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Задание_19
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Computer> computers = new List<Computer>()
            {
                new Computer() { Code = 1, Name = "Creator", CPU = "Intel Core i7", CPUfrequency = 2.7, RAMsize = 16, HardDiskSpace = 500, VideoCardMemory = 512, Cost = 40000, Amount = 10 },
                new Computer() { Code = 2, Name = "V14", CPU = "Intel Core i7", CPUfrequency = 2.7, RAMsize = 16, HardDiskSpace = 500, VideoCardMemory = 512, Cost = 35000, Amount = 10 },
                new Computer() { Code = 3, Name = "V15", CPU = "Intel Core i5", CPUfrequency = 2.7, RAMsize = 8, HardDiskSpace = 500, VideoCardMemory = 512, Cost = 50000, Amount = 20 },
                new Computer() { Code = 4, Name = "13S", CPU = "Intel Core i6", CPUfrequency = 2.7, RAMsize = 16, HardDiskSpace = 500, VideoCardMemory = 512, Cost = 48000, Amount = 30 },
                new Computer() { Code = 5, Name = "Plus", CPU = "Intel Core i5", CPUfrequency = 2.7, RAMsize = 4, HardDiskSpace = 500, VideoCardMemory = 512, Cost = 60000, Amount = 40 },
                new Computer() { Code = 6, Name = "Flex", CPU = "Intel Core i5", CPUfrequency = 2.7, RAMsize = 4, HardDiskSpace = 500, VideoCardMemory = 512, Cost = 65000, Amount = 50 }
            };

            //все компьютеры с указанным процессором
            Console.Write("Введите название процессора: ");
            string CPU = Console.ReadLine();
            List<Computer> computer_CPU = computers
                .Where(c => c.CPU == CPU)
                .ToList();
            if (computer_CPU.Count != 0)
            {
                foreach (Computer item in computer_CPU)
                {
                    Console.WriteLine($"{item.Code,8} {item.Name,8} {item.CPU,8}");
                }
            }
            else
            {
                Console.WriteLine("К сожалению, компьютеров с таким процессором не найдено.");
            }
            Console.WriteLine();

            //все компьютеры с объемом ОЗУ не ниже
            Console.Write("Введите минимальный объем ОЗУ: ");
            int RAM = Convert.ToInt32(Console.ReadLine());
            List<Computer> computer_RAM = computers
                .Where(c => c.RAMsize >= RAM)
                .ToList();
            if (computer_RAM.Count != 0)
            {
                foreach (Computer item in computer_RAM)
                {
                    Console.WriteLine($"{item.Code,8} {item.Name,8} {item.RAMsize,8}");
                }
            }
            else
            {
                Console.WriteLine("К сожалению, компьютеров с таким объемом ОЗУ не найдено.");
            }
            Console.WriteLine();

            //весь список, отсортированный по увеличению стоимости
            Console.WriteLine("Сортировка по стоимости: ");
            List<Computer> computer_Cost = computers
                .OrderBy(c => c.Cost)
                .ToList();
            foreach (Computer item in computer_Cost)
            {
                Console.WriteLine($"{item.Code,8} {item.Name,8} {item.Cost,8}");
            }
            Console.WriteLine();

            //список, сгруппированный по типу процессора
            Console.WriteLine("Группировка по типу процессора: ");
            var computer_group_CPU = computers
                .GroupBy(c => c.CPU);
                
            foreach (var group in computer_group_CPU)
            {                
                foreach (var item in group)
                {
                    Console.WriteLine($"{item.Code,8} {item.Name,8} {item.CPU,8}");
                }
            }
            Console.WriteLine();

            //самый дорогой и самый бюджетный компьютер
            var maxCost = computers.Max(c => c.Cost);
            List<Computer> computer_Cost_Max = computers
                .Where(c => c.Cost == maxCost)
                .ToList();
            foreach (var item in computer_Cost_Max)
            {
                Console.WriteLine($"Самый дорогой компьютер: {item.Code,8} {item.Name,8} {item.Cost,8} ");
            }
            var minCost = computers.Min(c => c.Cost);
            List<Computer> computer_Cost_Min = computers
                .Where(c => c.Cost == minCost)
                .ToList();
            foreach (var item in computer_Cost_Min)
            {
                Console.WriteLine($"Самый дорогой компьютер: {item.Code,8} {item.Name,8} {item.Cost,8} ");
            }
            Console.WriteLine();

            //компьютер в количестве не менее 30 штук
            Console.WriteLine("Количество компьютеров больше 30шт: ");
            List<Computer> computer_Amount = computers
                .Where(c => c.Amount >= 30)
                .ToList();
            if (computer_Amount.Count !=0)
            {
                foreach (Computer item in computer_Amount)
                {
                    Console.WriteLine($"{item.Code,8} {item.Name,8} {item.Amount,8}");
                }
            }
            else
            {
                Console.WriteLine("В наличии нет компьютеров в таком количестве.");
            }

            Console.ReadKey();
            
        }
    }
    class Computer
    {
        public int Code { get; set; }
        public string Name { get; set; }
        public string CPU { get; set; }
        public double CPUfrequency { get; set; }
        public int RAMsize { get; set; }
        public int HardDiskSpace { get; set; }
        public int VideoCardMemory { get; set; }
        public int Cost { get; set; }
        public int Amount { get; set; }
    }
}
