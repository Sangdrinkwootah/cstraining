using System;
using System.Reflection.Emit;
using System.Security.Cryptography;
class SinhVien : IComparable
{
    public string MaSV { get; set; }
    public string HoTen { get; set; }
    public string NgaySinh { get; set; }
    public string NamHoc { get; set; }
    public double DiemDH { get; set; }
    public List<DSKQ> DSKQ { get; set; }
    public Khoa Khoa { get; set; }
    public SinhVien(string masv, string hoten, string ngaysinh, string namhoc, double diemdh, List<DSKQ> dskq, khoa)
    {
        MaSV = masv;
        HoTen = hoten;
        NgaySinh = ngaysinh;
        NamHoc = namhoc;
        DiemDH = diemdh;
        DSKQ = dskq;
        Khoa = khoa;
    }
    public virtual void HienThiThongTin() {}
    public virtual void HienThiLoaiSinhVien() {}

    public bool LaSinhVienChinhQuy()
    {
        return this is SinhVienChinhQuy;
    }
    public bool LaSinhVienTaiChuc()
    {
        return this is SinhVienTaiChuc;
    }
    public int CompareTo(object obj)
    {
        if (obj = null)
        {
            return 1;
        }
        SinhVien tsv = obj as SinhVien;
        if (tsv != null)
        {
            return this.NamHoc.CompareTo(tsv.NamHoc);
        }
        else
        {
            throw new ArgumentException("Object is not a SinhVien")
        }
    }
}

class SinhVienTaiChuc : SinhVien
{
    public string NoiLK { get; set; }
    public SinhVienTaiChuc(string masv, string hoten, string ngaysinh, string namhoc, double diemdh, string noilk, List<DSKQ> dskq, khoa) :
    base (masv, hoten, ngaysinh, namhoc, diemdh, dskq, khoa)
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
        System.Console.WriteLine("Khoa: " + Khoa);
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
        System.Console.WriteLine("Khoa: " + khoa);
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

class Truong
{
    List<Khoa> DSKhoa { get; set; }
}

class DSKQ
{
    public string TenHK { get; set; }
    public double DiemTB { get; set; }
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
        List<Khoa> dskhoa = new List<Khoa>();
        int choice = -1;
        do
        {
            System.Console.WriteLine("""
            1. Them sinh vien
            2. Kiem tra loai sinh vien theo ma so sinh vien
            3. Tong so sinh vien chinh quy
            4. Lay diem trung binh mon cua sinh vien cao nhat khoa
            5. Lay diem trung binh mon theo ten hoc ki
            6. Ten sinh vien tai chuc theo noi LK cho truoc
            7. Ten sinh vien co diem dai hoc cao nhat tung khoa
            8. Sap xep theo nam vao hoc
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
                    System.Console.Write("Khoa: ");
                    string khoa = Console.ReadLine();
                    SinhVien s = new SinhVienChinhQuy(masv, hoten, ngaysinh, namhoc, diemdh, listkq, khoa);
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
                    System.Console.Write("Khoa: ");
                    string khoa = Console.ReadLine();
                    SinhVien s = new SinhVienTaiChuc(masv, hoten, ngaysinh, namhoc, diemdh, noilk, listkq, khoa);
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
            else if (choice == 4)
            {
                System.Console.Write("Ten khoa: ");
                string tenkhoa = Console.ReadLine();
                foreach (Khoa k in dskhoa)
                {
                    if (k.TenKhoa == tenkhoa)
                    {
                        double max = k.DSSV.DiemTB;
                        string tname;
                        for (int i = 0; i < k.DSSV.Count; i++)
                        {
                            if (k.DSSV.DiemTB > max)
                            {
                                max = k.DSSV.DiemTB;
                                tname = DSSV[i].HoTen;
                            }
                        }
                    }
                }
                System.Console.WriteLine("Diem cao nhat khoa la " + max + ", thuoc ve sinh vien " + tname);
            }
            else if (choice == 5)
            {
                System.Console.Write("Ten hoc ky: ");
                string tenhk = Console.ReadLine();
                foreach (SinhVien d in sv)
                {
                    if (d.DSKQ.TenHK == tenhk)
                    {
                        System.Console.WriteLine("Sinh vien:");
                        System.Console.WriteLine("ID: " + d.ID);
                        System.Console.WriteLine("Name: " + d.Name);
                        System.Console.WriteLine(d.DSKQ.DiemTB.ToString);
                    }
                }
            }
            else if (choice == 6)
            {
                System.Console.Write("Noi lien ket dao tao: ");
                string tnoilk = Console.ReadLine();
                foreach (SinhVien ts in sv)
                {
                    if (ts.LaSinhVienTaiChuc)
                    {
                        if (ts.NoiLK == tnoilk)
                        {                            
                            System.Console.WriteLine("Sinh vien:");
                            System.Console.WriteLine("ID: " + ts.ID);
                            System.Console.WriteLine("Name: " + ts.Name);
                        }
                    }
                }
            }
            else if (choice == 7)
            {
                foreach (Khoa khoa in dskhoa)
                {
                    System.Console.WriteLine("Khoa: " + khoa.TenKhoa);
                    int max = khoa.DSSV[1].DiemDH;
                    string tname, tid;
                    for (int i = 0; i < khoa.DSSV.Count; i++)
                    {
                        if (khoa.DSSV[i] > max)
                        {
                            max = khoa.DSSV[i].DiemDH;
                            tname = khoa.DSSV[i].Name;
                            tid = khoa.DSSV[i].ID;
                        }
                    }
                    System.Console.WriteLine("Sinh vien diem cao nhat: " + tname + ", ID: " + tid);
                }
            }
            else if (choice == 8)
            {
                sv.Sort();
                foreach (SinhVien s in sv)
                {
                    System.Console.WriteLine("Sinh vien " + s.Name + ", vao hoc nam " + s.NamHoc);
                }
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
