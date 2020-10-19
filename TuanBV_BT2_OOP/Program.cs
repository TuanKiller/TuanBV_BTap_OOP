using System;
using System.Collections.Generic;

namespace TuanBV_BT2_OOP
{
    class Program
    {
        private static List<Official> listOfficial;
        private static bool exit = false;
        private static int i = 1;
        static void Main(string[] args)
        {
            listOfficial = new List<Official>(0);
            while (!exit)
            {
                Console.WriteLine("1. Nhap thong tin moi cho can bo\n2. Tim kiem theo ho ten\n3. Hien thi thong tin ve danh sach can bo\n4. Thoat khoi chuong trinh");
                Console.WriteLine("Xin moi lua chon: ");
                string select = Console.ReadLine();
                Console.Clear();
                switch (select)
                {
                    case "1":
                        Console.WriteLine("1. Nhap thong tin moi cho can bo");
                        Console.WriteLine("----------------------------------");
                        CreateNewOfficial(listOfficial);
                        break;
                    case "2":
                        Console.WriteLine("Nhap ten can tim kiem: ");
                        Console.WriteLine("----------------------------------");
                        string searchName = Console.ReadLine();
                        for (int i = 0; i < listOfficial.Count; i++)
                        {
                            if (listOfficial[i].SearchByName(searchName) == true)
                            {
                                PrintOfficial(i + 1, listOfficial[i]);
                            }
                        }
                        break;
                    case "3":
                        Console.WriteLine("3. Hien thi thong tin ve danh sach can bo");
                        Console.WriteLine("----------------------------------");
                        foreach (Official value in listOfficial)
                        {
                            PrintOfficial(i, value);
                            i++;
                        }
                        break;
                    case "4":
                        Console.WriteLine("----------------------------------");
                        ExitProgram();
                        break;
                    default:
                        Console.WriteLine("Gia tri khong hop le, moi nhap lai: ");
                        ExitProgram();
                        break;
                }
            }
        }
        public static void CreateNewOfficial(List<Official> listOfficial)
        {
            listOfficial.Clear();
            Console.Write("Nhap so luong: ");
            string str1 = Console.ReadLine();
            for (int i = 1; i <= Convert.ToInt32(str1); i++)
            {
                //Phần chung
                Console.WriteLine("--------------------------------------");
                Console.Write("Nhap ho ten can bo " + i + ": ");
                string name = Console.ReadLine();
                Console.Write("Nhap nam sinh: ");
                int yearOfBirth = int.Parse(Console.ReadLine());
                Console.Write("Nhap gioi tinh: ");
                string gender = Console.ReadLine();
                Console.Write("Nhap dia chi: ");
                string address = Console.ReadLine();

                Console.WriteLine("Can bo: \n1. Cong nhan\n2. Ky su\n3. Nhan vien boi ban");
                Console.Write("Nhap can bo: ");
                string position = Console.ReadLine();

                //Phần riêng
                if (position == "1")
                {
                    Console.Write("Nhap trinh do: ");
                    string level = Console.ReadLine();
                    listOfficial.Add(new Worker("Cong nhan", name, yearOfBirth, gender, address , level));
                }
                else if (position == "2")
                {
                    Console.Write("Nhap nganh dao tao: ");
                    string major = Console.ReadLine();
                    listOfficial.Add(new Employee("Ky su", name, yearOfBirth, gender, address, major));

                }
                else if (position == "3")
                {
                    Console.Write("Nhap cong viec: ");
                    string task = Console.ReadLine();
                    listOfficial.Add(new Staff("Ky su", name, yearOfBirth, gender, address, task));
                }
                else return;
            }
        }
        public static void PrintOfficial(int num , Official official)
        {
            if (official.position == "Cong nhan")
            {
                Console.WriteLine("Can bo {0}\nHo va ten: {1}\nNam sinh: {2}\nGioi tinh: {3}\nDia chi: {4}\nCap bac: {5}\n\n", num, official.name, official.yearOfBirth, official.gender, official.address, official.level);
            }
            if (official.position == "Ky su")
            {
                Console.WriteLine("Can bo {0}\nHo va ten: {1}\nNam sinh: {2}\nGioi tinh: {3}\nDia chi: {4}\nNganh dao tao: {5}\n\n", num, official.name, official.yearOfBirth, official.gender, official.address, official.major);
            }
            if (official.position == "Nhan vien boi ban")
            {
                Console.WriteLine("Can bo {0}\nHo va ten: {1}\nNam sinh: {2}\nGioi tinh: {3}\nDia chi: {4}\nCong viec: {5}\n\n", num, official.name, official.yearOfBirth, official.gender, official.address, official.task);
            }
        }
        public static void ExitProgram()
        {
            Environment.Exit(0);
        }
    }
}
