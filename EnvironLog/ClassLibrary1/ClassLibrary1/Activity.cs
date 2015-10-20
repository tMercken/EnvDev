using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Activity
    {
        public String Title
        {

            get;
            set;
        }

        public bool isCompulsory
        {
            get;
            set;
        }

        public Activity(String t, Boolean comp)
        {
            comp = String.IsNullOrEmpty(t);

            Title = t;
            isCompulsory = comp;
        }

        public override string ToString()
        {
            return (isCompulsory) ? Title + " (obligatoire)" : Title;
        }



    }
}
