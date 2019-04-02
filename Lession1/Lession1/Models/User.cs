using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Lession1.Models
{
    
    public class User
    {
        [Required(ErrorMessage ="fill đầy đủ đi bạn ei")]
        public long id { set; get; }
        [Required(ErrorMessage = "fill đầy đủ đi bạn ei")]
        [Range(18,60,ErrorMessage ="your age have to 18-60")]
        public string name { get; set; }
        [Required(ErrorMessage = "fill đầy đủ đi bạn ei")]
        [StringLength(9,MinimumLength =4)]
        [Compare("name", ErrorMessage ="your name need to your address")]
        [DataType(DataType.Text)]
        public string address { get; set; }
        [Required(ErrorMessage = "fill đầy đủ đi bạn ei")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}",ErrorMessage ="Email is not valid.")]
        public string email { get; set; }

        public User()
        {

        }

        public User(long id, string name, string address, string email)
        {
           
            this.id = id;
            this.name = name;
            this.address = address;
            this.email = email;

        }
    }
   
}
