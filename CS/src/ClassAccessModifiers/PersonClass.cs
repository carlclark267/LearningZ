using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningZ.CS.ClassAccessModifiers
{
    public class PersonClass
    {
        public int MinAge = 0;
        public static int MiddleAge = 50;
        public const int MaxAge = 100;

        public int Id { get; set; }
        public string? Name { get; set; }
        public int Age { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public string? Email { get; set; }
    }
}
