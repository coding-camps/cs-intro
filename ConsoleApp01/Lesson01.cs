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

        public void eg03()
        {
            // 示例3：布尔变量和if语句

            // 整型   年龄
            int age = 0;

            // 用户输入年龄
            Console.Write("请输入一个年龄：");
            string ageStr = Console.ReadLine() ?? "0";
            age = int.Parse(ageStr);

            // 判断年龄是否在有效范围
            if (age <= 0)
            {
                Console.WriteLine("太小");
                return;
            }
            else if (age > 200)
            {
                Console.WriteLine("太大");
                return;
            }
            else
            {
                Console.WriteLine("输入的年龄是" + age + ", 有效。");
            }

            // 布尔类型   是否成年
            bool isAdult = false;

            // 根据年龄判断是否成年人
            if (age >= 18)
            {
                isAdult = true;
            }
            else
            {
                isAdult = false;
            }

            // 根据判断输出是否成年人
            //Console.WriteLine("是否成年人：" + isAdult);
            if (isAdult)
            {
                // 这里以$符号开始的字符串称为 内插字符串。
                Console.WriteLine($"输入的年龄是{age}，他/她是成年人。");
            }
            else
            {
                Console.WriteLine($"输入的年龄是{age}，他/她不是成年人。");
            }
        }

        public void eg04()
        {
            // 示例4：重构示例03，演示方法的使用
            // 整型   年龄
            int age = 0;
            // 用户输入年龄
            Console.Write("请输入一个年龄：");
            string ageStr = Console.ReadLine() ?? "0";
            age = int.Parse(ageStr);

            // 判断年龄是否在有效范围
            bool isValid = eg04_checkAgeValidation(age);
            if (!isValid)
            {
                return;
            }

            // 根据年龄判断是否成年人
            eg04_checkAgeAdult(age);
        }

        private bool eg04_checkAgeValidation(int age)
        {
            // 判断年龄是否在有效范围
            bool isValid = false;
            if (age <= 0)
            {
                Console.WriteLine("太小");
            }
            else if (age > 200)
            {
                Console.WriteLine("太大");
            }
            else
            {
                Console.WriteLine("输入的年龄是" + age + ", 有效。");
                isValid = true;
            }

            return isValid;
        }

        private void eg04_checkAgeAdult(int age)
        {
            // 根据判断输出是否成年人
            if (age >= 18)
            {
                // 这里以$符号开始的字符串称为 内插字符串。
                Console.WriteLine($"输入的年龄是{age}，他/她是成年人。");
            }
            else
            {
                Console.WriteLine($"输入的年龄是{age}，他/她不是成年人。");
            }
        }

        public void eg05()
        {
            // 示例5：for循环，打印乘法口诀表（数字版）
            for (int i = 1; i < 10; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($"{j} x {i} = {i * j}\t");
                }

                Console.WriteLine();
            }
        }
    }
}
