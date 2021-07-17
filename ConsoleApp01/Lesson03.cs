namespace ConsoleApp01
{
    internal class Lesson03
    {
        public void eg09()
        {
            // 示例09：文件和目录操作，显示某个目录下的文件/目录并在控制台打印（不含子目录）
            // 当前工作目录
            string currentDir = Directory.GetCurrentDirectory();
            Console.WriteLine($"当前工作目录：{currentDir}");
            Console.WriteLine();

            DirectoryInfo dirInfo = new DirectoryInfo(currentDir);
            FileInfo[] files = dirInfo.GetFiles();
            for (int i = 0; i < files.Length; i++)
            {
                FileInfo fileInfo = files[i];
                Console.WriteLine($"第 {i,2:d2} 个文件");
                Console.WriteLine($"文件路径：{fileInfo.FullName}");
                Console.WriteLine($"文件名称：{fileInfo.Name}");
                Console.WriteLine($"文件名不带后缀：{Path.GetFileNameWithoutExtension(fileInfo.FullName)}");
                Console.WriteLine($"文件的后缀：{fileInfo.Extension}");
                Console.WriteLine($"文件创建时间：{fileInfo.CreationTime}");
                Console.WriteLine($"文件访问时间：{fileInfo.LastWriteTime}");
                Console.WriteLine($"文件修改时间：{fileInfo.LastAccessTime}");
                Console.WriteLine();
            }
        }
    }
}
