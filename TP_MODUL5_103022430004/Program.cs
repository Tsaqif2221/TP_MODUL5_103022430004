public class HaloGeneric
{
    public void SapaUser<T>(T user)
    {
        Console.WriteLine($"Halo user {user}");
    }
}
class main
{
    static void Main(string[] args)
    {
        HaloGeneric halo = new HaloGeneric();
        Console.Write("Masukkan nama panggilan Anda: ");
        string namaPanggilan = Console.ReadLine();
        halo.SapaUser(namaPanggilan);
        Console.ReadLine();
    }
}