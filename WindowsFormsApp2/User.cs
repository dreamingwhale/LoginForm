using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp2
{
    public class User
    {
        private string id;
        private string password;
        private string root;
        private List<string> hobbyList = new List<string>();

        public string getId()
        {
            return id;
        }
        public void setId(string id)
        {
            this.id = id;
        }
        public string getPassword()
        {
            return password;
        }
        public void setPassword(string password)
        {
            this.password = password;
        }
        public string getRoot()
        {
            return root;
        }
        public void setRoot(string root)
        {
            this.root = root;
        }
        public List<string> getHobbyList()
        {
            return hobbyList;
        }
        public void addHobbyList(string hobby)
        {
            this.hobbyList.Add(hobby);
        }
       
    }
}
