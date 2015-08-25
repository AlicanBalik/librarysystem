using System;


    public class EditMemberClass
    {
        public EditMemberClass()
        { 
        }

        private int _StudentID;
        public int StudentID
        {
            get { return _StudentID; }
            set { _StudentID = value; }
        }

        private string _Name;
        public string Name
        {
            get { return _Name; }
            set { _Name = value; }
        }

        private string _Surname;
        public string Surname
        {
            get { return _Surname; }
            set { _Surname = value; }
        }

        private int _Department;
        public int Department
        {
            get { return _Department; }
            set { _Department = value; }
        }

        private int _Year;
        public int Year
        {
            get { return _Year; }
            set { _Year = value; }
        }
        
        private int _Telephone;
        public int Telephone
        {
            get { return _Telephone; }
            set { _Telephone = value; }
        }

        private string _Email;
        public string Email
        {
            get { return _Email; }
            set { _Email = value; }
        }

        public override string ToString()
        {
          //  return "[" + StudentID.ToString() + "]" + Name + " " + Surname;
            return StudentID.ToString();
        } 
    }


