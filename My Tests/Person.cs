using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Tests
{
    internal class Person : IComparable<Person>
    {
        public int Id { get; set; }

        public Person(int id) 
        { 
            this.Id = id;
        }

        public int CompareTo(Person? other)
        {
            return this.Id.CompareTo(other.Id);
        }
    }
}
