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
    }
}
