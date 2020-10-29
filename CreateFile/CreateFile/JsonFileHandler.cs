using Newtonsoft.Json;
using System;
using System.IO;
using System.Linq;
using System.Reflection.Emit;

namespace CreateFile
{
    public static class JsonFileHandler
    {
        //CRUD
        //create a file, if target file already exists then its overwritten 
        public static Status CreateFile(string path, DataToUpload dataToUpload)
        {
            var jsonData = JsonConvert.SerializeObject(dataToUpload);
            File.WriteAllText(path, "public class Demo { public string name{get;set;} }");
            return Status.Successful;
        }
        public static void ReadFile(string path)
        {
            var data = File.ReadAllLines(path).ToList();
            var res = AssemblyBuilder.DefineDynamicAssembly(new System.Reflection.AssemblyName(""), AssemblyBuilderAccess.Run);
            var dejson = JsonConvert.DeserializeObject(data.FirstOrDefault());
        }
    }
}
