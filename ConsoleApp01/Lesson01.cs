namespace ConsoleApp01
{
    internal class Lesson01
    {
        public void eg01()
        {
            // 示例1：演示最简单的变量
            var n = 100;
            var m = 200;
            var sum = 0;
            sum = n + m;
            string prefix = "计算结果是：";
            Console.WriteLine(prefix);
            Console.WriteLine(sum);
            // 接收用户输入一个键
            Console.ReadKey();
        }

        public void eg02()
        {
            // 示例2：类型转换和预设值
            Console.WriteLine("请输入第一个数字：");
            string s1 = Console.ReadLine() ?? "";
            Console.WriteLine("请输入第二个数字：");
            string s2 = Console.ReadLine() ?? "";
            string str = s1 + s2;
            Console.WriteLine("字符拼接：" + str);
            int value = int.Parse(s1) + int.Parse(s2);
            Console.WriteLine("数字相加：" + value.ToString());
        }
    }
}
