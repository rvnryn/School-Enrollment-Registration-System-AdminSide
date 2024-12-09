using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourseManagament
{
    class Courses
    {
        private int _Program_Code;
        private string _Program_Name;
        private int _Program_Capacity;
        private string _Description;

        //tuition Fee
        private double _FirstYear_1stSem, _FirstYear_2ndSem; // 1st Year
        private double _SecondYear_1stSem, _SecondYear_2ndSem; // 2nd Year
        private double _ThirdYear_1stSem, _ThirdYear_2ndSem; // 3rd Year
        private double _FourthYear_1stSem, _FourthYear_2ndSem; // 4th Year

        public int Program_Code { get { return _Program_Code; } set { _Program_Code = value; } }
        public string Program_Name { get { return _Program_Name; } set { _Program_Name = value; } }
        public int Program_Capacity { get { return _Program_Capacity; } set { _Program_Capacity = value; } }
        public string Program_Description { get { return _Description; } set { _Description = value; } }

        //1st Year
        public double FirstYear_1stSem { get { return _FirstYear_1stSem; } set { _FirstYear_1stSem = value; } }
        public double FirstYear_2ndSem { get { return _FirstYear_2ndSem; } set { _FirstYear_2ndSem = value; } }

        //2nd Year
        public double SecondYear_1stSem { get { return _SecondYear_1stSem; } set { _SecondYear_1stSem = value; } }
        public double SecondYear_2ndSem { get { return _SecondYear_2ndSem; } set { _SecondYear_2ndSem = value; } }

        //3rd Year
        public double ThirdYear_1stSem { get { return _ThirdYear_1stSem; } set { _ThirdYear_1stSem = value; } }
        public double ThirdYear_2ndSem { get { return _ThirdYear_2ndSem; } set { _ThirdYear_2ndSem = value; } }

        //4th Year
        public double FourthYear_1stSem { get { return _FourthYear_1stSem; } set { _FourthYear_1stSem = value; } }
        public double FourthYear_2ndSem { get { return _FourthYear_2ndSem; } set { _FourthYear_2ndSem = value; } }

        public Courses(int program_Code, string program_Name, int program_Capacity, string description, double firstYear_1stSem, double firstYear_2stSem, double secondYear_1stSem, double secondYear_2stSem, double thirdYear_1stSem, double thirdYear_2stSem, double fourthYear_1stSem, double fourthYear_2ndSem)
        {
            this._Program_Code = program_Code;
            this._Program_Name = program_Name;
            this._Program_Capacity = program_Capacity;
            this._Description = description;

            //1st Year
            this.FirstYear_1stSem = firstYear_1stSem;
            this.FirstYear_2ndSem = firstYear_2stSem;

            //2nd Year
            this.SecondYear_1stSem = secondYear_1stSem;
            this.SecondYear_2ndSem = secondYear_2stSem;

            //3rd Year
            this.ThirdYear_1stSem = thirdYear_1stSem;
            this.ThirdYear_2ndSem = thirdYear_2stSem;

            //4th Year
            this.FourthYear_1stSem = fourthYear_1stSem;
            this.FourthYear_2ndSem = fourthYear_2ndSem;
        }

        Courses()
        {
            this._Program_Code = 0;
            this._Program_Name = "";
            this._Program_Capacity = 0;
            this._Description = "";

            //1st Year
            this.FirstYear_1stSem = 0;
            this.FirstYear_2ndSem = 0;

            //2nd Year
            this.SecondYear_1stSem = 0;
            this.SecondYear_2ndSem = 0;

            //3rd Year
            this.ThirdYear_1stSem = 0;
            this.ThirdYear_2ndSem = 0;

            //4th Year
            this.FourthYear_1stSem = 0;
            this.FourthYear_2ndSem = 0;
        }
    }

}
