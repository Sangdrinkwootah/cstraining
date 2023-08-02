using System.Security.Cryptography;
using System.Reflection.Emit;
class Nguoi
{
    public string HoTen { get; set; }
    public int Tuoi { get; set; }
    public string Nghe { get; set; }
    public string CMND { get; set; }

    public Nguoi(string hoten, int tuoi, string nghe, string cmnd)
    {
        this.HoTen = hoten;
        this.Tuoi = tuoi;
        this.Nghe = nghe;
        this.CMND = cmnd;
    }

    public override string ToString()
    {
        return "Ten: " + HoTen + " Tuoi: " + Tuoi + " Nghe: " + Nghe + " CMND: " + CMND;
    }
}

class HoGiaDinh
{
    List<Nguoi> lists { get; set; }
    public string address { get; set; }

    public HoGiaDinh(List<Nguoi> lists, string address)
    {
        this.lists = lists;
        this.address = address;
    }

    public override string ToString()
    {
        return "Ho gia dinh: " + lists + "Dia chi: " + address;
    }
}

class KhuPho
{
    List<HoGiaDinh> hogiadinh { get; set; }

    public KhuPho()
    {
        this.hogiadinh = new List<HoGiaDinh>();
    }

    public void ThemHoGiaDinh(HoGiaDinh hogiadinh)
    {
        this.hogiadinh.Add(hogiadinh);
    }
}

class GFG
{
    static void Main(string[] args)
    {
        KhuPho khupho = new KhuPho();
        System.Console.Write("Nhap n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            System.Console.Write("Dia chi: ");
            string address = Console.ReadLine();

            List<Nguoi> nguoi = new List<Nguoi>();
            System.Console.WriteLine("So nguoi trong nha: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            for (int j = 0; j < num; j++)
            {

            }

            khupho.ThemHoGiaDinh(new HoGiaDinh(nguoi, address));
        }
    }
}
