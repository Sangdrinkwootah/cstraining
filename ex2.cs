class Student
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public int Priority { get; set; }
    public string Major { get; set; }
    public Student(int id, string name, string address, int priority, string major)
    {
        this.Id = id;
        this.Name = name;
        this.Address = address;
        this.Priority = priority;
        this.Major = major;
    }
}

class TuyenSinh
{
    List<Student> students = new List<Student>();
    public void AddStudent(Student std)
    {
        students.Add(std);
        System.Console.WriteLine();
    }

    public void ShowStudent()
    {
        foreach (var s in students)
        {
            System.Console.WriteLine("ID: " +  s.Id);
            System.Console.WriteLine("Name: " +  s.Name);
            System.Console.WriteLine("Address: " +  s.Address);
            System.Console.WriteLine("Priority: " +  s.Priority);
            System.Console.WriteLine("Major: " +  s.Major);
            System.Console.WriteLine();
        }
        System.Console.WriteLine();
    }

    public void SearchStudent(int id)
    {
        foreach (var s in students)
        {
            if (s.Id == id)
            {
                System.Console.WriteLine("Found!");
                System.Console.WriteLine("ID: " +  s.Id);
                System.Console.WriteLine("Name: " +  s.Name);
                System.Console.WriteLine("Address: " +  s.Address);
                System.Console.WriteLine("Priority: " +  s.Priority);
                System.Console.WriteLine("Major: " +  s.Major);
            }
        }
        System.Console.WriteLine();
    }
}

class GFG
{
    static void Main(string[] args)
    {
        TuyenSinh ts = new TuyenSinh();
        int choice = -1;
        do
        {
            System.Console.WriteLine("""
            1. Them moi thi sinh
            2. Thong tin thi sinh
            3. Tim kiem theo So Bao Danh
            4. Thoat
            """);
            System.Console.Write("Nhap: ");
            choice = Convert.ToInt32(Console.ReadLine());
            if (choice == 1)
            {
                System.Console.WriteLine("Them thong tin thi sinh:");
                System.Console.Write("So Bao Danh: ");
                int id = Convert.ToInt32(System.Console.ReadLine());
                System.Console.Write("Ho va ten: ");
                string name = System.Console.ReadLine();
                System.Console.Write("Dia chi: ");
                string address = System.Console.ReadLine();
                System.Console.Write("Muc uu tien: ");
                int priority = Convert.ToInt32(System.Console.ReadLine());
                System.Console.Write("Khoi thi: ");
                string major = System.Console.ReadLine();
                Student std = new Student(id, name, address, priority, major);
                ts.AddStudent(std);
                System.Console.WriteLine("Hoan thanh!");
                System.Console.WriteLine();
            }
            else if (choice == 2)
            {
                System.Console.WriteLine("Danh sach thi sinh:");
                ts.ShowStudent();
                System.Console.WriteLine();
            }
            else if (choice == 3)
            {
                System.Console.Write("So bao danh: ");
                int id = Convert.ToInt32(Console.ReadLine());
                ts.SearchStudent(id);
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
