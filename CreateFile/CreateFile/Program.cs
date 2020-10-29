using System;

namespace CreateFile
{
    public class Program
    {
        static void Main(string[] args)
        {
            var data = new DataToUpload()
            {
                Id = Guid.NewGuid().ToString(),
                Name = "jim",
                Email = "jimjam@githum.com"
            };
            var getpath = PathHandler.GetAnyPath("myclass");
            JsonFileHandler.CreateFile(getpath, data);
            //JsonFileHandler.ReadFile(getpath);
        }
    }
}
