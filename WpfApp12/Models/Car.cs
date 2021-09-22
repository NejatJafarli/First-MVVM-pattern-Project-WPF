using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp12.Models
{
    public class Car:Entity
    {

        public string Vendor { get; set; }
       
        public string Model {  get; set; }

        public int Year { get; set; }

        public Car()
        {

        }

    }
}
