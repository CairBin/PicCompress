using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PicCompress
{
    internal class FileOperator
    {
        //创建文件
        public static bool CreateFile(string path, string name, string info)
        {
            if (File.Exists(path + name))
                return false;

            FileStream fs = new FileStream(path + name, FileMode.Create, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(info);

            sw.Close();
            fs.Close();

            return true;
        }

        //读取文件第一行 info为返回内容
        public static bool ReadFileFirstLine(string path, ref string info)
        {
            if (!File.Exists(path))
                return false;

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);

            info = sr.ReadLine();

            sr.Close();
            fs.Close();

            return true;
        }

        //写入文件内容
        public static bool WriteFile(string path, string info)
        {
            if (!File.Exists(path))
                return false;

            FileStream fs = new FileStream(path, FileMode.Open, FileAccess.Write);
            StreamWriter sr = new StreamWriter(fs);

            sr.WriteLine(info);

            sr.Close();
            fs.Close();

            return true;
        }


    }
}
