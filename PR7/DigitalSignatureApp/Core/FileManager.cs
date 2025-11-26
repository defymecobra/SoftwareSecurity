using System;
using System.IO;

namespace DigitalSignatureApp.Core
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
    }
}
