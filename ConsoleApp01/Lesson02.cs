using ConsoleApp01_MyLib;

namespace ConsoleApp01
{
    internal class Eg07Student
    {
        // 示例7使用的类
        // 该类的位置不一定非得放到使用它的类之前
        public string name;
        public uint age;

        public void ShowInfo()
        {
            Console.WriteLine($"学生[{this.name}, {this.age}岁]");
        }
    }

    internal class Lesson02
    {
        public void eg07()
        {
            // 示例7：面向对象简单介绍
            // 简单方法
            Console.WriteLine("方式1");
            Eg07Student stu1 = new Eg07Student();
            stu1.name = "张三";
            stu1.age = 20;
            stu1.ShowInfo();
            Eg07Student stu2 = new Eg07Student();
            stu2.name = "李四";
            stu2.age = 18;
            stu2.ShowInfo();
            // 结合集合对象
            Console.WriteLine("方式2");
            List<Eg07Student> students = new List<Eg07Student>();
            students.Add(stu1);
            students.Add(stu2);
            for (int i = 0; i < students.Count; i++)
            {
                students[i].ShowInfo();
            }
        }

        public void eg08()
        {
            // 示例08：面向对象，通过类库代码抽离
            List<Student> students = new List<Student>();
            students.Add(new Student("张三", 11, "初一"));
            students.Add(new Student("李四", 11, "初二"));
            students.Add(new Student("王五", 12, "初一"));
            for (int i = 0; i < students.Count; i++)
            {
                Console.WriteLine(students[i].getInfo());
            }
        }
    }
}
