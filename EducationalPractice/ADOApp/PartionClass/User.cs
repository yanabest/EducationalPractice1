using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalPractice.ADOApp
{
    public partial class User
    {
        public string Fullname
            {
            get
            {
                return $"{this.Surname}{Name}{MiddleName}";
            }
            }
    }
}
