using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace back.Models
{
    public class User
    {
        public string ?UserId { get; set; }
        public string ?UserName { get; set; }
        public string ?UserSurname { get; set; }
        public string ?UserEmail { get; set; }
        public string ?UserPassword { get; set; }
    }
}