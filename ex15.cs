using System.Reflection.Emit;
using System.Security.Cryptography;
class SinhVien
{
    public string MaSV { get; set; }
    public string HoTen { get; set; }
    public string NgaySinh { get; set; }
    public string NamHoc { get; set; }
    public double DiemDH { get; set; }
    public List<DSKQ> DSKQ { get; set; }
    public SinhVien(string masv, string hoten, string ngaysinh, string namhoc, double diemdh, List<DSKQ> dskq)
    {
        MaSV = masv;
        HoTen = hoten;
        NgaySinh = ngaysinh;
        NamHoc = namhoc;
        DiemDH = diemdh;
        DSKQ = dskq;
    }
    public virtual void HienThiThongTin()
    {

    }
    public virtual void HienThiLoaiSinhVien()
    {

    }

    public bool LaSinhVienChinhQuy()
    {
        return this is SinhVienChinhQuy;
    }
}

class SinhVienTaiChuc : SinhVien
{
    public string NoiLK { get; set; }
    public SinhVienTaiChuc(string masv, string hoten, string ngaysinh, string namhoc, double diemdh, string noilk, List<DSKQ> dskq) :
    base (masv, hoten, ngaysinh, namhoc, diemdh, dskq)
    {
        NoiLK = noilk;
    }
    public override void HienThiThongTin()
    {
        System.Console.WriteLine("Ma sinh vien: " + MaSV);
        System.Console.WriteLine("Ho va ten: " + HoTen);
        System.Console.WriteLine("Ngay sinh: " + NgaySinh);
        System.Console.WriteLine("Nam hoc: " + NamHoc);
        System.Console.WriteLine("Diem dau vao: " + DiemDH);
        System.Console.WriteLine("Noi lien ket dao tao: " + NoiLK);
        foreach (DSKQ d in DSKQ)
        {
            System.Console.WriteLine("Hoc ki: " + d.TenHK);
            System.Console.WriteLine("Diem: " + d.DiemTB);
        }
    }
    public override void HienThiLoaiSinhVien()
    {
        System.Console.WriteLine("Sinh vien tai chuc");
    }
}

class SinhVienChinhQuy : SinhVien
{
    public SinhVienChinhQuy(string masv, string hoten, string ngaysinh, string namhoc, double diemdh, List<DSKQ> dskq) :
    base (masv, hoten, ngaysinh, namhoc, diemdh, dskq)
    {

    }
    public override void HienThiThongTin()
    {
        System.Console.WriteLine("Ma sinh vien: " + MaSV);
        System.Console.WriteLine("Ho va ten: " + HoTen);
        System.Console.WriteLine("Ngay sinh: " + NgaySinh);
        System.Console.WriteLine("Nam hoc: " + NamHoc);
        System.Console.WriteLine("Diem dau vao: " + DiemDH);
        foreach (DSKQ d in DSKQ)
        {
            System.Console.WriteLine("Hoc ki: " + d.TenHK);
            System.Console.WriteLine("Diem: " + d.DiemTB);
        }
    }
    public override void HienThiLoaiSinhVien()
    {
        System.Console.WriteLine("Sinh vien chinh quy");
    }
}

class Khoa
{
    public string TenKhoa { get; set; }
    public List<SinhVien> DSSV { get; set; }
}

class DSKQ
{
    public string TenHK { get; set; }
    public double DiemTB { get; set; }
    public List<DSKQ> dskq;
    public DSKQ()
    {
        dskq = new List<DSKQ>();
    }
    public DSKQ(string tenhk, double diemtb)
    {
        TenHK = tenhk;
        DiemTB = diemtb;
    }
}

class GFG
{
    static void Main(string[] args)
    {
        List<SinhVien> sv = new List<SinhVien>();
        int choice = -1;
        do
        {
            System.Console.WriteLine("""
            1. Them sinh vien
            2. Kiem tra loai sinh vien theo ma so sinh vien
            3. Tong so sinh vien chinh quy
            """);
            System.Console.Write("Nhap: ");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                System.Console.WriteLine("""
                1. Sinh vien chinh quy
                2. Sinh vien tai chuc
                """);
                System.Console.Write("Nhap: ");
                int n = Convert.ToInt32(Console.ReadLine());
                if (n == 1)
                {
                    System.Console.Write("Ma sinh vien: ");
                    string masv = Console.ReadLine();
                    System.Console.Write("Ho va ten: ");
                    string hoten = Console.ReadLine();
                    System.Console.Write("Ngay sinh: ");
                    string ngaysinh = Console.ReadLine();
                    System.Console.Write("Nam hoc: ");
                    string namhoc = Console.ReadLine();
                    System.Console.Write("Diem dau vao: ");
                    double diemdh = Convert.ToDouble(Console.ReadLine());
                    List<DSKQ> listkq = new List<DSKQ>();
                    System.Console.WriteLine("Danh sach ket qua:");
                    System.Console.Write("So hoc ky: ");
                    int m = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < m; i++)
                    {
                        System.Console.WriteLine("Hoc ky " + (i+1) + ": ");
                        System.Console.Write("Ten hoc ky: ");
                        string tenhk = Console.ReadLine();
                        System.Console.Write("Diem trung binh hoc ky: ");
                        double diemtb = Convert.ToDouble(Console.ReadLine());
                        DSKQ d = new DSKQ(tenhk, diemtb);
                        listkq.Add(d);
                    }
                    SinhVien s = new SinhVienChinhQuy(masv, hoten, ngaysinh, namhoc, diemdh, listkq);
                    sv.Add(s);
                }
                else if (n == 2)
                {
                    System.Console.Write("Ma sinh vien: ");
                    string masv = Console.ReadLine();
                    System.Console.Write("Ho va ten: ");
                    string hoten = Console.ReadLine();
                    System.Console.Write("Ngay sinh: ");
                    string ngaysinh = Console.ReadLine();
                    System.Console.Write("Nam hoc: ");
                    string namhoc = Console.ReadLine();
                    System.Console.Write("Diem dau vao: ");
                    double diemdh = Convert.ToDouble(Console.ReadLine());
                    System.Console.Write("Noi lien ket dao tao: ");
                    string noilk = Console.ReadLine();
                    List<DSKQ> listkq = new List<DSKQ>();
                    System.Console.WriteLine("Danh sach ket qua:");
                    System.Console.Write("So hoc ky: ");
                    int m = Convert.ToInt32(Console.ReadLine());
                    for (int i = 0; i < m; i++)
                    {
                        System.Console.WriteLine("Hoc ky " + (i+1) + ": ");
                        System.Console.Write("Ten hoc ky: ");
                        string tenhk = Console.ReadLine();
                        System.Console.Write("Diem trung binh hoc ky: ");
                        double diemtb = Convert.ToDouble(Console.ReadLine());
                        DSKQ d = new DSKQ(tenhk, diemtb);
                        listkq.Add(d);
                    }
                    SinhVien s = new SinhVienTaiChuc(masv, hoten, ngaysinh, namhoc, diemdh, noilk, listkq);
                    sv.Add(s);
                }
                else
                {
                    System.Console.WriteLine("Invalid input");
                }
            }
            else if (choice == 2)
            {
                System.Console.Write("Nhap ma so sinh vien: ");
                string masv = Console.ReadLine();
                foreach (SinhVien s in sv)
                {
                    if (s.MaSV == masv)
                    {
                        s.HienThiLoaiSinhVien();
                    }
                }
            }
            else if (choice == 3)
            {
                int count = 0;
                foreach (SinhVien s in sv)
                {
                    if (s.LaSinhVienChinhQuy)
                    {
                        count++;
                    }
                }
                System.Console.WriteLine("So sinh vien chinh quy la: " + count);
            }
        } while (choice != 0);
        foreach (SinhVien s in sv)
        {
            System.Console.WriteLine("Thong tin:");
            s.HienThiThongTin();
            System.Console.WriteLine();
        }
    }
}
