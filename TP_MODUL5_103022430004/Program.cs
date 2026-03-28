using System;

namespace TP_MODUL5_103022430004
{
    public class HaloGeneric
    {
        public void SapaUser<T>(T user)
        {
            Console.WriteLine($"Halo user {user}");
        }
    }

    public class DataGeneric<T>
    {
        private T data;

        public DataGeneric(T data)
        {
            this.data = data;
        }

        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + data);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            HaloGeneric halo = new HaloGeneric();
            Console.Write("Masukkan nama panggilan Anda: ");
            string namaPanggilan = Console.ReadLine();
            halo.SapaUser(namaPanggilan);

            Console.WriteLine();

            Console.Write("Masukkan NIM: ");
            string nim = Console.ReadLine();
            DataGeneric<string> data = new DataGeneric<string>(nim);
            data.PrintData();

            Console.WriteLine("\nTekan Enter untuk keluar...");
            Console.ReadLine();
        }
    }
}