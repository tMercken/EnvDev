using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Pupil:Person
    {
        private int grade;
        private List<Activity> LstActivities { get; set; }
        private char[] TabEval { get; set; }
        
        public Pupil (String name, int age, int grade):base(name, age){
            Grade = grade;
            LstActivities =new List<Activity>() ;
            TabEval = new char [10] ;
        }

        public Pupil(String name, int age) : this(name, age, 1)
        { }

        public int Grade
        {
            get { return grade; }
            set { grade = (value >= 0) ? value : 0;  }
        }
        
        public void AddActivity(Activity act){
            LstActivities.Add(act);
        }

        public void AddEvaluation ( String title = null, char evaluation = 'S') {
            int i=0 ;
            if(title != null)
            {
                foreach(Activity activity in LstActivities)
                {
                    if (activity.Title.Equals(title))
                    {
                        TabEval[i] = evaluation;
                        break;
                    }
                    i++;
                }
            }
            
            else
            {
                throw new ArgumentNullException("error Title null"); 
            }
            
         }
        
        public char GetEvaluation(String title) 
        {
            int i = 0;
            foreach (Activity activity in LstActivities)
            {
                if (activity.Title.Equals(title))                
                    return TabEval[i];                
                i++;
            }
            throw new System.ArgumentException("activitiyTitle not in the list");
             
        }

        public override string ToString()
        {
            string ch = base.ToString() + ((LstActivities.Count() != 0) ? " a choisi..." : "n'a pas encore choisi d'activité");

            int i;
            for (i = 0; i < LstActivities.Count(); i++)
            {
                ch += " " + LstActivities.ElementAt(i) + ",";
            }

            return ch;
        }
    }
}
