
namespace HousePets_Airbnb
{
    internal class Accounts
    {
        static Dictionary<string, string> accounts = new Dictionary<string,string>();

        public static bool addAccount(string username, string password)
        {
            if (accounts.ContainsKey(username))
            {
                return false;
            } 
            else
            {
                accounts.Add(username, password);
                return true;
            }
        }

        public static bool verify(string username, string password)
        {
            if (accounts.TryGetValue(username, out string accountPassword))
            {
                if (accountPassword != password)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
