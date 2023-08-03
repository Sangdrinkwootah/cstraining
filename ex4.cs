using System.Threading.Tasks;
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
    public void InThongTinCaNhan()
    {
        System.Console.WriteLine("Ten: " + HoTen + "\nTuoi: " + Tuoi + "\nNghe: " + Nghe + "\nCMND: " + CMND);
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
    public void InThongTinGiaDinh()
    {
        System.Console.WriteLine("Dia chi: " + address);
        foreach (var l in lists)
        {
            l.InThongTinCaNhan();
        }
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

    public void InThongTinKhuPho()
    {
        foreach (var h in hogiadinh)
        {
            System.Console.WriteLine("Ho Gia Dinh:");
            h.InThongTinGiaDinh();
        }
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
            System.Console.WriteLine("Ho gia dinh " + (i+1) + ": ");
            System.Console.Write("Dia chi: ");
            string address = Console.ReadLine();

            List<Nguoi> nguoi = new List<Nguoi>();
            System.Console.Write("So nguoi trong nha: ");
            int num = Convert.ToInt32(Console.ReadLine());
            
            for (int j = 0; j < num; j++)
            {
                System.Console.WriteLine("Nguoi " + (j+1) + ": ");
                System.Console.Write("Ho ten: ");
                string name = Console.ReadLine();
                System.Console.Write("Tuoi: ");
                int age = Convert.ToInt32(Console.ReadLine());
                System.Console.Write("Nghe nghiep: ");
                string nghe = Console.ReadLine();
                System.Console.Write("So CMND: ");
                string cmnd = Console.ReadLine();
                Nguoi ng = new Nguoi(name, age, nghe, cmnd);
                nguoi.Add(ng);
            }
            System.Console.WriteLine();
            khupho.ThemHoGiaDinh(new HoGiaDinh(nguoi, address));
        }
        khupho.InThongTinKhuPho();
    }
}
