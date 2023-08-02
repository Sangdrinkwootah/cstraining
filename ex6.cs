class HocSinh
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Location { get; set; }
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
                System.Console.WriteLine("Name: " + h.Name + "/nAge: 20/nQue quan: " + h.Location);
            }
        }
    }

    public void HienThiHocSinh23t()
    {
        foreach (var h in dshs)
        {
            if (h.Age == 23 && h.Location == "DN")
            {
                System.Console.WriteLine("Name: " + h.Name + "/nAge: 20/nQue quan: " + h.Location);
            }
        }
    }
}

class GFG
{
    static void Main(string[] args)
    {
        QLHS dshs = new QLHS();
        dshs.HienThiHocSinh20t();
        dshs.HienThiHocSinh23t();
    }
}
