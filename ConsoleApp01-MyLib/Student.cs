namespace ConsoleApp01_MyLib
{
    // 示例8所使用的类
    public class Student
    {
        public string name { get; set; }
        public uint age { get; set; }
        public string grade { get; set; }

        public Student(string name, uint age, string grade)
        {
            this.name = name;
            this.age = age;
            this.grade = grade;
        }

        public string getInfo()
        {
            return $"Student[{name}, {age}, {grade}]";
        }
    }
}
