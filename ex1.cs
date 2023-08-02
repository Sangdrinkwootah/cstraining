using System.Linq.Expressions;
class CanBo
{
    public string Name { get; set; }
    public int Age { get; set; }
    public string Sex { get; set; }
    public CanBo(string name, int age, string sex)
    {
        this.Name = name;
        this.Age = age;
        this.Sex = sex;
    }
}

class CongNhan : CanBo
{
    public int Level { get; set; }
    public CongNhan(string name, int age, string sex, int level) : base(name, age, sex)
    {
        this.Level = level;
    }
}

class KySu : CanBo
{
    public string Major { get; set; }
    public KySu(string name, int age, string sex, string major) : base(name, age, sex)
    {
        this.Major = major;
    }
}

class NhanVien : CanBo
{
    public string Job { get; set; }
    public NhanVien(string name, int age, string sex, string job) : base(name, age, sex)
    {
        this.Job = job;
    }
}

class QLCB
{
    List<CanBo> CBList = new List<CanBo>();

    // public QLCB()
    // {
    //     this.CBList = new List<CanBo>();
    // }

    public void InsertCB(CanBo cb)
    {
        CBList.Add(cb);
    }

    public void FindCB(string name)
    {
        foreach (var cb in CBList)
        {
            if (cb.Name == name)
            {
                System.Console.WriteLine("Found!");
                System.Console.WriteLine("Name: " + cb.Name);
                System.Console.WriteLine("Age: " + cb.Age);
                System.Console.WriteLine("Sex: " + cb.Sex);
            }
        }
    }

    public void ShowCB()
    {
        foreach (var cb in CBList)
        {
            System.Console.WriteLine("Can bo:");
            System.Console.WriteLine("Name: " + cb.Name);
            System.Console.WriteLine("Age: " + cb.Age);
            System.Console.WriteLine("Sex: " + cb.Sex);
        }
    }
}

class GFG
{
    static void Main(string[] args)
    {
        QLCB qlcb = new QLCB();
        int choice = -1;
        do
        {
            System.Console.WriteLine("""
            1. Them moi can bo
            2. Tim kiem can bo
            3. Danh sach can bo
            4. Thoat
            """);
            System.Console.Write("Nhap: ");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                System.Console.WriteLine("""
                1. Cong Nhan
                2. Ky Su
                3. Nhan Vien
                """);
                System.Console.WriteLine("Nhap: ");
                int type = Convert.ToInt32(System.Console.ReadLine());
                switch (type)
                {
                    case 1:
                    {
                        System.Console.Write("Name: ");
                        string name = System.Console.ReadLine();
                        System.Console.Write("Age: ");
                        int age = Convert.ToInt32(System.Console.ReadLine());
                        System.Console.Write("Sex: ");
                        string sex = System.Console.ReadLine();
                        System.Console.Write("Level: ");
                        string level = System.Console.ReadLine();
                        CanBo cn = new NhanVien(name, age, sex, level);
                        qlcb.InsertCB(cn);
                        System.Console.WriteLine("Finish Inserting!");
                        break;
                    }
                    case 2:
                    {
                        System.Console.Write("Name: ");
                        string name = System.Console.ReadLine();
                        System.Console.Write("Age: ");
                        int age = Convert.ToInt32(System.Console.ReadLine());
                        System.Console.Write("Sex: ");
                        string sex = System.Console.ReadLine();
                        System.Console.Write("Level: ");
                        string major = System.Console.ReadLine();
                        CanBo ks = new KySu(name, age, sex, major);
                        qlcb.InsertCB(ks);
                        System.Console.WriteLine("Finish Inserting!");
                        break;
                    }
                    case 3:
                    {
                        System.Console.Write("Name: ");
                        string name = System.Console.ReadLine();
                        System.Console.Write("Age: ");
                        int age = Convert.ToInt32(System.Console.ReadLine());
                        System.Console.Write("Sex: ");
                        string sex = System.Console.ReadLine();
                        System.Console.Write("Level: ");
                        string job = System.Console.ReadLine();
                        CanBo nv = new KySu(name, age, sex, job);
                        qlcb.InsertCB(nv);
                        System.Console.WriteLine("Finish Inserting!");
                        break;
                    }
                }
                System.Console.WriteLine();
            }
            else if (choice == 2)
            {
                System.Console.Write("Name: ");
                string name = System.Console.ReadLine();
                qlcb.FindCB(name);
                System.Console.WriteLine();
            }
            else if (choice == 3)
            {
                System.Console.WriteLine("Danh sach can bo:");
                qlcb.ShowCB();
                System.Console.WriteLine();
            }
            else
            {
                throw new IOException("Your input is invalid");
                System.Console.WriteLine();
            }
        } while (choice != 0);
    }    
}
