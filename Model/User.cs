using System;
namespace Backend_4.Model
{
    public class User
    {
        public User()
        {
        }
        public int id { get; set; }
        public string password { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string email { get; set; }
    }
}
