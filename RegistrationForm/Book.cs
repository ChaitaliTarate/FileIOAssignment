using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegistrationForm
{
    [Serializable]
  public class Book
    {
        public int Id { get; set; }
        public string BookName { get; set; }
       public string Author { get; set; }
        public int Price { get; set; }

    }
}
