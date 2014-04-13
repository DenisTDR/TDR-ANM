using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TALibrary
{
    public class Account
    {
        public Account()
        {

        }
        public int Id { get; set; }
        public string User { get; set; }
        public bool Admin { get; set; }
        public int Points { get; set; }
        public int Group { get; set; }
        public string Name { get; set; }
    }
}
