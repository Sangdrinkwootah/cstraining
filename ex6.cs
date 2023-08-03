class HocSinh
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Location { get; set; }
    public HocSinh(string name, int age, string location)
    {
        Name = name;
        Age = age;
        Location = location;
    }
}

class QLHS
{
    List<HocSinh> dshs;
    public QLHS()
    {
        dshs = new List<HocSinh>();
    }

    public void ThemHocSinh(HocSinh hs)
    {
        dshs.Add(hs);
    }

    public void HienThiHocSinh20t()
    {
        foreach (var h in dshs)
        {
            if (h.Age == 20)
            {
                System.Console.WriteLine("Name: " + h.Name + "\nAge: 20\nQue quan: " + h.Location);
            }
        }
    }

    public void HienThiHocSinh23t()
    {
        foreach (var h in dshs)
        {
            if (h.Age == 23 && h.Location == "DN")
            {
                System.Console.WriteLine("Name: " + h.Name + "\nAge: 20\nQue quan: " + h.Location);
            }
        }
    }
}

class GFG
{
    static void Main(string[] args)
    {
        QLHS dshs = new QLHS();
        HocSinh hs1 = new HocSinh("Nguyen Van A", 20, "X");
        HocSinh hs2 = new HocSinh("Nguyen Van B", 23, "Y");
        HocSinh hs3 = new HocSinh("Tran Thi C", 23, "DN");
        dshs.ThemHocSinh(hs1);
        dshs.ThemHocSinh(hs2);
        dshs.ThemHocSinh(hs3);

        dshs.HienThiHocSinh20t();
        dshs.HienThiHocSinh23t();
    }
}
