using Newtonsoft.Json;
namespace _2048.Common
{
    public static class UserResultsStorage
    {
        public static List<User> Users = new List<User>();
        static readonly string Path = "results.json";

        public static void AddResultToStorage(User user)
        {
            FillUsersList(user);

            FileProvider.AddData(SerializeList(Users), Path);

        }

        public static void FillUsersList(User user)
        {
            string fileProviderString = FileProvider.GetData(Path);

            if (!string.IsNullOrEmpty(fileProviderString))
            {
                Users = JsonConvert.DeserializeObject<List<User>>(fileProviderString);
                Users.Add(user);
            }
            else Users.Add(user);
        }
        public static List<User> GetUsersList()
        {
            var users = new List<User>();
            string fileProviderString = FileProvider.GetData(Path);

            if (string.IsNullOrEmpty(fileProviderString) || !File.Exists(Path)) return null;

            users = JsonConvert.DeserializeObject<List<User>>(fileProviderString);
            return users;
        }

        public static string SerializeList(List<User> users)
        {
            var str = JsonConvert.SerializeObject(users, Formatting.Indented);
            return str;
        }



    }
}