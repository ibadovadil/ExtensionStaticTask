namespace ExtensionStaticTask.Models
{
    internal class Student
    {
        private static int _id = 1;

        public int Id { get; private set; }

        public string Fullname { get; set; }


        public string GroupNo { get; set; }

        public int Age { get; set; }

        public Student(string fullname, string groupNo, int age)
        {
            Id = _id;
            _id++;
            Fullname = fullname;
            GroupNo = groupNo;
            Age = age;
        }
    }
}
