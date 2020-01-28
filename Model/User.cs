using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Backend_4.Model
{
    public class User
    {
        public User()
        {
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int user_id { get; set; }
        public int client_id { get; set; }
        public string firstname { get; set; }
        public string lastname { get; set; }
        public string nickname { get; set; }
        public string email { get; set; }
        public string organisational_unit { get; set; }
        public string job_title { get; set; }
        public DateTime hire_date { get; set; }
        public string status { get; set; }
        public string target_allocation { get; set; }
    }
}
