using System;
using System.Collections.Generic;
using System.Text;

namespace Person
{
    class Person
    {
        public string _name;

        public int _age;

        public Person(string name,int age)
        {
            Name = name;
            Age = age;
        }

        public Person()
        {
            
        }

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int Age
        {
            get
            {
                return _age;
            }
            set
            {
                if (value > 0)
                {
                    _age = value;
                }

            }
        }
        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append(String.Format("Name: {0}, Age: {1}",
                this.Name,
                this.Age));

            return stringBuilder.ToString();
        }


    }
}
