using System;
using System.IO;
using System.Text;

namespace CaesarCipherApp.Core
{
    public static class FileManager
    {
        public static string ReadText(string path)
        {
            return File.ReadAllText(path);
        }

        public static void WriteText(string path, string content)
        {
            File.WriteAllText(path, content);
        }

        public static byte[] ReadBytes(string path)
        {
            return File.ReadAllBytes(path);
        }

        public static void WriteBytes(string path, byte[] content)
        {
            File.WriteAllBytes(path, content);
        }
    }
}
