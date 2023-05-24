using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EducationalPractice.ADOApp
{
 public partial class Product
 {
        public string FullProduct
        {
            get
            {
                return $"Name: {Name}, Price: {Price}";
            }
         
        }
   
 }

}
