using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMI_Calculator
{
     public class Person
    {
        public const double DEFAULT_HEIGHT=5;
        public const double DEFAULT_WEIGHT = 50; 
        private int _personId;
        private string _personName;
        private int _personAge;
        private double _personHeight;
        private double _personWeight;
        public double _personBmi { get; set; }

        public Person(int id ,string name,int age):this(id,name,age, DEFAULT_HEIGHT, DEFAULT_WEIGHT)
        {

        }

        //public Person(int id, string name, int age, double height, double weight):this(id,name,age,height,weight,0)
        //{
            
        //}

        public Person(int id, string name, int age, double height, double weight)
        {
            _personId = id;
            _personName = name;
            _personAge = age;
            _personHeight = height;
            _personWeight = weight;
           _personBmi = CalculateBMI();
        }

        public double CalculateBMI()
        {
            double mtrHeight = _personHeight * 0.3048;
            double heightSquare = Math.Pow(mtrHeight, 2);
            double bmi = _personWeight/heightSquare;
            return bmi;
           
            
        }

        public string BodyType(double bmi)
        {
            if (bmi < 18.5)
                return "Underweight";
            else if (bmi > 18.5 && bmi < 24.9)
                return "Normal";
             return "Overweight";
            

        }

        public static double PrintPersonBMI(Person[] persons)
        {
            double maxBmi = 0;
            foreach (var person in persons)
            {
                if(person._personBmi > maxBmi)
                    maxBmi = person._personBmi;
            }
           return maxBmi;
        }

    }
}
