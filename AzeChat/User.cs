using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzeChat
{
    public class User
    {
        public string f_name { get; set; }
        public string l_name { get; set; }
        public string email { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
        public string image_url { get; set; }
        public string gender { get; set; }

        public User(string f_name, string l_name, string email, string phone, string address, string image_url, string gender)
        {
            this.f_name = f_name;
            this.l_name = l_name;
            this.email = email;
            this.phone = phone;
            this.address = address;
            this.image_url = "https://cdn.pixabay.com/photo/2012/12/21/20/03/boston-71799_640.jpg";
            this.gender = gender;
        }


        public override string ToString()
        {
            string data = f_name + " " + l_name + " " + email + " " + phone;
            return data;
        }
    }
}
