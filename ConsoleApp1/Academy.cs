using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Academy
    {
        private readonly  ISchool _school;
        public Academy(ISchool school)
        {

            _school = school;

        }

        public void Exam()
        {
            _school.Student();
        }
    }
}
