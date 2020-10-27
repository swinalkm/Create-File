using System;
using System.IO;
using System.Reflection;

namespace CreateFile
{
    public static class PathHandler
    {
        public static string GetAnyPath(string fileName)
        {
            //my path where i want my file to be created is : "C:\\Users\\{my-system-name}\\Desktop\\Me\\create-file\\CreateFile\\CreateFile\\FilesPosition\\firstjson.json"
            var basePath = new Uri(Assembly.GetExecutingAssembly().CodeBase).LocalPath.Split(new string[] { "\\CreateFile" }, StringSplitOptions.None)[0];
            var filePath = Path.Combine(basePath, $"CreateFile\\CreateFile\\FilesPosition\\{fileName}.json");
            return filePath;
        }
    }
}
