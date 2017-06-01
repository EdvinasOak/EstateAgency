using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstateAgent
{
    class Variables
    {
        private static string _selectedDate = "";
        private static string _todaysDate = "";
        private static string _selectedBuyer = "";
        private static string previous = "exit";
        private static string manager = "";

        public static string Manager
        {
            get { return manager; }
            set { manager = value; }
        }

        public static string Previous
        {
            get { return previous; }
            set { previous = value; }
        }
        public static string SelectedBuyer
        {
            get { return _selectedBuyer; }
            set { _selectedBuyer = value; }
        }

        
        public static List<string> _arrayTimes = new List<string>{"09:00", "10:00", "11:00", "12:00", 
            "13:00", "14:00", "15:00", "16:00", "17:00", "18:00"};
        private static string _selectedProp = "";

        public static string SelectedDate
        {
            get { return _selectedDate; }
            set { _selectedDate = value; }
        }
        public static string TodaysDate
        {
            get { return _todaysDate; }
            set { _todaysDate = value; }
        }
        public static string SelectedProp
        {
            get { return _selectedProp; }
            set { _selectedProp = value; }
        }
        
        

    }
}
