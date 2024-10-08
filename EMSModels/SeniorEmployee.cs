using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace EMSModels
{
    //public class Lunch
    //{
    //    string _lunchtype;

    //    //simple, north,south etc
    //    //return type string----accept a string & return a string
    //    //Property --- smart method which can be used for accepting, returning, validating with a single name

    //    public string LunchType
    //    {
    //        set { _lunchtype=value; }//accept/assign to variable
    //        get { return _lunchtype; }//display/return 


    //    }




    //}


    public class SeniorEmployee
    {
        //Empid--int
        //ename---string
        //city---string
        //joiningdate--datetime
        //birthdate-datatime

        public SeniorEmployee()
        {
                
        }

        public SeniorEmployee(int empid,string ename)
        {
            _empid = empid;
            _name = ename;   
        }

        public SeniorEmployee(int empid, string ename,string city):this(empid,ename) 
        {
            //_empid=empid;
            //_name = ename;
            _city = city;
            
            if (empid != 0 && _name.Length > 4 && _city.Length > 4) { 
            IsValid = true;
            
            
            }

        }

        
        public bool IsValid { get; set; }


        private   int _empid;
        public int Empid
        {
            set 
            {
                if ((value != 0) && !(value < 0))
                    _empid = value;
                else
                    Environment.Exit(1);
            }
            get
            {
                return _empid; 
            }
        
        }


        private string _city;

        public string City
        {
            get 
            {
                string cname=CountryDisplay;
                //return string.Concat(_city, _country);
                return string.Concat(_city,cname); 
            }
            set { _city = value; }
        }

        private string _country;

        public string Country
        {
            //get { return _country; }
            set { _country = value; }
        }

        protected string CountryDisplay
        {
            get { return _country; }
        }

        
        public string Email { get; set; }

        //prop (tab + tab)

        private string? _name;
        public string EmpName
        {
            set {

                if ((value.Length > 4) && (!string.IsNullOrEmpty(value)))
                    _name = value;
                else
                    Environment.Exit(1);



            }
            get {
                
                return _name; 
                }
        }

        //set-writing data to variable
        //get--returning data from variable

       //read-write property
        private DateTime _bdate;
        public DateTime BirthDate
        {
            set 
            {
                //writing
            _bdate = value;
            
            }
            get {
                //reading
                return _bdate;
            }
        }

       //set---not accepting the age data, we want to calulate age as per birthdate
       //readonly property
        int _age;
        public int CalculatedAge 
        {
            get {
            
                _age=DateTime.Now.Year - _bdate.Year;
                return _age;


            }
        
        }

        //Write only-- it will set but not a get

        private string _skillName;

        public string SkillName
        {
            set { _skillName = value; }
        
        }

        string _favColor;
        public string FavColor 
        {
            set 
            {
                
                _favColor = value;
                if (_favColor == "Red" || _favColor == "Blue")
                {
                    Console.WriteLine("fetching details");

                }
            
            }
            get { 

            return _skillName;
            
            
            }
                    
        }
















    
    }
}
