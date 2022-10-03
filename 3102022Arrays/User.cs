using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3102022Arrays
{
    internal class User : IComparable<User>
    {
        private String name;
        private String password;

        public User(String name, String password)
        {
            String tempname = name;
            String temppassword = password;
            if (tempname.Length >= 3)
            {
                this.name = tempname;
            }
            if (temppassword.Length >= 5)
            {
                this.password = temppassword;
            }
        }


        public String Name
        {
            get
            {
                return name;
            }

            set
            {
                if (value.Length >= 3)
                {
                    name = value;
                }
            }
        }

        public String Password
        {
            get
            {
                return password;
            }

            set
            {
                if (value.Length >= 5)
                {
                    password = value;
                }
            }
        }

        public int CompareTo(User obj)
        {
            return this.name.CompareTo(obj.name);
        }

        public override string ToString()
        {
            return String.Format("Name: {0}\n" +
                "Password: {1}\n" +
                "-------------\n", this.name, this.password);
        }
    }
}
