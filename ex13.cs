using System.Runtime.ConstrainedExecution;
class Employee
{
    public string ID { get; set; }
    public string FullName { get; set; }
    public string BirthDay { get; set; }
    public string Phone { get; set; }
    public string Email { get; set; }
    public int Employee_type { get; set; }
    public int Employee_count { get; set; }
    public List<Certificate> certificates { get; set; }
    public Employee(string id, string fullname, string birthday, string phone, string email, int employee_type, List<Certificate> certi)
    {
        ID = id;
        FullName = fullname;
        BirthDay = birthday;
        Phone = phone;
        Email = email;
        Employee_type = employee_type;
        Employee_count++;
        certificates = certi;
    }
    public virtual void ShowInfo(){}
}

class Experience : Employee
{
    public int ExpInYear { get; set; }
    public string ProSkill { get; set; }
    public int Experience_count { get; set; }
    public Experience(string id, string fullname, string birthday, string phone, string email, int employee_type, List<Certificate> certi, int expinyear, string proskill) : 
    base (id, fullname, birthday, phone, email, employee_type, certi)
    {
        ExpInYear = expinyear;
        ProSkill = proskill;
        Experience_count++;
    }
    public override void ShowInfo()
    {
        System.Console.WriteLine("Experience employee:");
        System.Console.WriteLine("ID: " + ID);
        System.Console.WriteLine("Full name: " + FullName);
        System.Console.WriteLine("Birth day: " + BirthDay);
        System.Console.WriteLine("Phone: " + Phone);
        System.Console.WriteLine("Email: " + Email);
        System.Console.WriteLine("Employee type: " + Employee_type);
        System.Console.WriteLine("Employee count: " + Employee_count);
        System.Console.WriteLine("Experience in years: " + ExpInYear);
        System.Console.WriteLine("Professional skill: " + ProSkill);
        System.Console.WriteLine();
    }
}

class Fresher : Employee
{
    public string Graduation_date { get; set; }
    public string Graduation_rank { get; set; }
    public string Education { get; set; }
    public int Fresher_count { get; set; }
    public Fresher(string id, string fullname, string birthday, string phone, string email, int employee_type, List<Certificate> certi, string graduation_date, string graduation_rank, string education) : 
    base (id, fullname, birthday, phone, email, employee_type, certi)
    {
        Graduation_date = graduation_date;
        Graduation_rank = graduation_rank;
        Education = education;
        Fresher_count++;
    }
    public override void ShowInfo()
    {
        System.Console.WriteLine("Fresher employee:");
        System.Console.WriteLine("ID: " + ID);
        System.Console.WriteLine("Full name: " + FullName);
        System.Console.WriteLine("Birth day: " + BirthDay);
        System.Console.WriteLine("Phone: " + Phone);
        System.Console.WriteLine("Email: " + Email);
        System.Console.WriteLine("Employee type: " + Employee_type);
        System.Console.WriteLine("Employee count: " + Employee_count);
        System.Console.WriteLine("Graduation date: " + Graduation_date);
        System.Console.WriteLine("Graduation rank: " + Graduation_rank);
        System.Console.WriteLine("Education: " + Education);
        System.Console.WriteLine();
    }
}

class Intern : Employee
{
    public string Majors { get; set; }
    public string Semester { get; set; }
    public string University_name { get; set; }
    public int Intern_count { get; set; }
    public Intern(string id, string fullname, string birthday, string phone, string email, int employee_type, List<Certificate> certi, string majors, string semester, string university_name) : 
    base (id, fullname, birthday, phone, email, employee_type, certi)
    {
        Majors = majors;
        Semester = semester;
        University_name = university_name;
        Intern_count++;
    }
    public override void ShowInfo()
    {
        System.Console.WriteLine("Intern employee:");
        System.Console.WriteLine("ID: " + ID);
        System.Console.WriteLine("Full name: " + FullName);
        System.Console.WriteLine("Birth day: " + BirthDay);
        System.Console.WriteLine("Phone: " + Phone);
        System.Console.WriteLine("Email: " + Email);
        System.Console.WriteLine("Employee type: " + Employee_type);
        System.Console.WriteLine("Employee count: " + Employee_count);
        System.Console.WriteLine("Majors: " + Majors);
        System.Console.WriteLine("Semester: " + Semester);
        System.Console.WriteLine("University name: " + University_name);
        System.Console.WriteLine();
    }
}

class Certificate
{
    public string CertificateID { get; set; }
    public string CertificateName { get; set; }
    public string CertificateRank { get; set; }
    public string CertificateDate { get; set; }
    public Certificate(string id, string name, string rank, string date)
    {
        CertificateID = id;
        CertificateName = name;
        CertificateRank = rank;
        CertificateDate = date;
    }
}

class GFG
{
    static void Main(string[] args)
    {
        List<Employee> employee = new List<Employee>();

        // 1. Chức năng cho phép thêm, sửa, xóa ID
        int choice = -1;
        do
        {
            System.Console.WriteLine("""
            1. Add new Employee
            2. Edit employee
            3. Remove employee
            """);
            System.Console.Write("Enter: ");
            choice = Convert.ToInt32(Console.ReadLine());
            // Them moi nhan vien
            if (choice == 1)
            {
                System.Console.WriteLine("""
                1. Experience
                2. Fresher
                3. Intern
                """);
                System.Console.WriteLine("Enter: ");
                int type = Convert.ToInt32(System.Console.ReadLine());
                switch (type)
                {
                    case 1:
                    {
                        System.Console.Write("ID: ");
                        string id = Console.ReadLine();
                        System.Console.Write("Name: ");
                        string name = Console.ReadLine();
                        System.Console.Write("Date of birth: ");
                        string birthday = Console.ReadLine();
                        System.Console.Write("Phone number: ");
                        string phone = Console.ReadLine();
                        System.Console.Write("Email: ");
                        string email = Console.ReadLine();
                        System.Console.Write("Experience in year: ");
                        int expinyear = Convert.ToInt32(Console.ReadLine());
                        System.Console.Write("Professional skill: ");
                        string proskill = Console.ReadLine();
                        List<Certificate> listcerti = new List<Certificate>();
                        System.Console.WriteLine("Enter certificate:");
                        System.Console.Write("How many certificates: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            System.Console.WriteLine("Certificate" + (i+1) + ": ");
                            System.Console.Write("Certificate ID: ");
                            string cid = System.Console.ReadLine();
                            System.Console.Write("Certificate name: ");
                            string cname = System.Console.ReadLine();
                            System.Console.Write("Certificate rank: ");
                            string crank = System.Console.ReadLine();
                            System.Console.Write("Certificate date: ");
                            string cdate = System.Console.ReadLine();
                            Certificate c = new Certificate(cid, cname, crank, cdate);
                            listcerti.Add(c);
                        }
                        Employee e = new Experience(id,name, birthday, phone, email, 0, listcerti, expinyear, proskill);
                        employee.Add(e);
                        System.Console.WriteLine("Finish inserting!");
                        break;
                    }
                    case 2:
                    {
                        System.Console.Write("ID: ");
                        string id = Console.ReadLine();
                        System.Console.Write("Name: ");
                        string name = Console.ReadLine();
                        System.Console.Write("Date of birth: ");
                        string birthday = Console.ReadLine();
                        System.Console.Write("Phone number: ");
                        string phone = Console.ReadLine();
                        System.Console.Write("Email: ");
                        string email = Console.ReadLine();
                        System.Console.Write("Graduation date: ");
                        string graduation_date = Console.ReadLine();
                        System.Console.Write("Graduation rank: ");
                        string graduation_rank = Console.ReadLine();
                        System.Console.Write("Education: ");
                        string education = Console.ReadLine();
                        List<Certificate> listcerti = new List<Certificate>();
                        System.Console.WriteLine("Enter certificate:");
                        System.Console.Write("How many certificates: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            System.Console.WriteLine("Certificate" + (i+1) + ": ");
                            System.Console.Write("Certificate ID: ");
                            string cid = System.Console.ReadLine();
                            System.Console.Write("Certificate name: ");
                            string cname = System.Console.ReadLine();
                            System.Console.Write("Certificate rank: ");
                            string crank = System.Console.ReadLine();
                            System.Console.Write("Certificate date: ");
                            string cdate = System.Console.ReadLine();
                            Certificate c = new Certificate(cid, cname, crank, cdate);
                            listcerti.Add(c);
                        }
                        Employee e = new Fresher(id,name, birthday, phone, email, 1, listcerti, graduation_date, graduation_rank, education);
                        employee.Add(e);
                        System.Console.WriteLine("Finish inserting!");
                        break;
                    }
                    case 3:
                    {
                        System.Console.Write("ID: ");
                        string id = Console.ReadLine();
                        System.Console.Write("Name: ");
                        string name = Console.ReadLine();
                        System.Console.Write("Date of birth: ");
                        string birthday = Console.ReadLine();
                        System.Console.Write("Phone number: ");
                        string phone = Console.ReadLine();
                        System.Console.Write("Email: ");
                        string email = Console.ReadLine();
                        System.Console.Write("Majors: ");
                        string majors = Console.ReadLine();
                        System.Console.Write("Semester: ");
                        string semester = Console.ReadLine();
                        System.Console.Write("University name: ");
                        string university_name = Console.ReadLine();
                        List<Certificate> listcerti = new List<Certificate>();
                        System.Console.WriteLine("Enter certificate:");
                        System.Console.Write("How many certificates: ");
                        int n = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            System.Console.WriteLine("Certificate" + (i+1) + ": ");
                            System.Console.Write("Certificate ID: ");
                            string cid = System.Console.ReadLine();
                            System.Console.Write("Certificate name: ");
                            string cname = System.Console.ReadLine();
                            System.Console.Write("Certificate rank: ");
                            string crank = System.Console.ReadLine();
                            System.Console.Write("Certificate date: ");
                            string cdate = System.Console.ReadLine();
                            Certificate c = new Certificate(cid, cname, crank, cdate);
                            listcerti.Add(c);
                        }
                        Employee e = new Intern(id,name, birthday, phone, email, 2, listcerti, majors, semester, university_name);
                        employee.Add(e);
                        System.Console.WriteLine("Finish inserting!");
                        break;
                    }
                }
                System.Console.WriteLine();
                foreach (Employee e in employee)
                {
                    e.ShowInfo();
                }
            }
            // Sua thong tin ca nhan nhan vien
            else if (choice == 2)
            {
                System.Console.Write("Nhap ID nhan vien: ");
                string id_input = Console.ReadLine();
                foreach (Employee e in employee)
                {
                    if (e.ID == id_input)
                    {
                        // Do not have feature edit employee type (suggest remove and add new)
                        // Do not have feature edit certificate yet
                        System.Console.WriteLine("Which information do you want to edit?");
                        System.Console.WriteLine("""
                        1. Name
                        2. Date of birth
                        3. Phone number
                        4. Email
                        """);
                        int m = Convert.ToInt32(Console.ReadLine());
                        switch(m)
                        {
                            case 1:
                            {
                                System.Console.Write("New name: ");
                                string tname = Console.ReadLine();
                                e.FullName = tname;
                                break;
                            }
                            case 2:
                            {
                                System.Console.Write("New date of birth: ");
                                string tdob = Console.ReadLine();
                                e.BirthDay = tdob;
                                break;
                            }
                            case 3:
                            {
                                System.Console.Write("New phone number: ");
                                string tphone = Console.ReadLine();
                                e.Phone = tphone;
                                break;
                            }
                            case 4:
                            {
                                System.Console.Write("New email: ");
                                string temail = Console.ReadLine();
                                e.Email = temail;
                                break;
                            }
                            default:
                            {
                                System.Console.WriteLine("Invalid input");
                                break;
                            }
                        }
                    }
                    else
                    {
                        System.Console.WriteLine("ID does not exist");
                    }
                }
            }
            // Xoa nhan vien theo ID
            else if (choice == 3)
            {
                System.Console.Write("Enter ID of employee want to remove: ");
                string id_remove = Console.ReadLine();
                for (int i = 0; i < employee.Count; i++)
                {
                    if (employee[i].ID == id_remove)
                    {
                        employee.RemoveAt(i);
                    }
                    else
                    {
                        System.Console.WriteLine("ID not found");
                    }
                }
            }
        } while (choice != 0);
    }
}
