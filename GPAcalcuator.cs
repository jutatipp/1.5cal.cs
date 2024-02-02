using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPACakcuator_V2
{
    internal class GPAcalcuator
    {
        private List<Student> _student =
            new List<Student>();
        private double unit = 3;
        private double sum;

        public void setStudent(Student student)
        {
            this._student.Add(student);
        }

        public double Gsum()
        {
            sum = 0;
            foreach (Student student in _student)
            {
                sum = sum + student.getGpa();
            }
            return sum;
        }

        public double Gpax()
        {
            double sum_gpax = (Gsum() * unit) / (unit * this._student.Count);
            return sum_gpax;
        }
        public double GetHighSc()
        {
            double height = 0;
            foreach (Student student in _student)
            {
                if (student.getGpa() > height)
                {
                    height = student.getGpa();
                }

            }

            return height;
        }
        public double GetLowSc()
        {
            double Low = this.GetHighScore();

            foreach (Student student in _student)
            {
                if (student.getGpa() < Low)
                {
                    Low = student.getGpa();
                }
            }
            return Low;

        }



        public double AVgpa()
        {
            double sumgpa = 0;

            sumgpa = (Gsum() / this._student.Count);

            return sumgpa;
        }


    }
}
