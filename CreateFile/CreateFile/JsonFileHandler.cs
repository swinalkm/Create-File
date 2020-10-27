using Newtonsoft.Json;
using System.IO;

namespace CreateFile
{
    public static class JsonFileHandler
    {
        //CRUD
        //create a file, if target file already exists then its overwritten 
        public static Status CreateFile(string path, DataToUpload dataToUpload)
        {
            var jsonData = JsonConvert.SerializeObject(dataToUpload);
            File.WriteAllText(path, jsonData);
            return Status.Successful;
        }
    }
}
