using System.ComponentModel.DataAnnotations;

namespace FormAPI.Model
{
    public class User
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        [Key]
        public string email { get; set; }
        public int number { get; set; }
        public string gender { get; set; }
        public DateTime date { get; set; }

    }
}