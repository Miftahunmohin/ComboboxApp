namespace ComboboxApp
{
    public class Student
    {
        public Student(string name, string regNo, string address)
        {
            Name = name;
            RegNo = regNo;
            Address = address;
        }

        public string RegNo { get; set; }

        public string Name { get; set; }

        public string Address { set; get; }
    }
}