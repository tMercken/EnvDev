using ClassLibrary1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;






namespace ConsoleApplicationLabo1
{
    class Program
    {
        static void Main(string[] args)
        {
            List <Pupil>lstPupils = new List <Pupil>()
            {     
                new Pupil("e1", 8),
                new Pupil("e2", 7),
                new Pupil("e3", 1),
                new Pupil("e4", 12),
                new Pupil("e5", 9),
                new Pupil("e6", 10),
                new Pupil("e7", 1),
                new Pupil("e8", 2),
                new Pupil("e9", 13),
                new Pupil("e10", 14),
            };
            
            Pupil etu01 = new Pupil("e1", 3);
            etu01.AddActivity(new Activity("fr", true));
            etu01.AddActivity(new Activity("grgtr", false));
            etu01.AddEvaluation("fr", 'd');

             Pupil etu02 = new Pupil("e2", 8);
             etu02.AddActivity(new Activity("fr", true));
             etu02.AddActivity(new Activity("grgtr", false));
             etu02.AddEvaluation("fr", 'd');

             Pupil etu03 = new Pupil("e3", 5);
             etu03.AddActivity(new Activity("fr", true));
             etu03.AddActivity(new Activity("grgtr", false));
             etu03.AddEvaluation("fr", 'd');

             Pupil etu04 = new Pupil("e4", 6);
             etu04.AddActivity(new Activity("fr", true));
             etu04.AddActivity(new Activity("grgtr", false));
             etu04.AddEvaluation("fr", 'd');

             Pupil etu05 = new Pupil("e5", 8);
             etu05.AddActivity(new Activity("fr", true));
             etu05.AddActivity(new Activity("grgtr", false));
             etu05.AddEvaluation("fr", 'd');

             Pupil etu06 = new Pupil("e6", 8);
             etu06.AddActivity(new Activity("fr", true));
             etu06.AddActivity(new Activity("grgtr", false));
             etu06.AddEvaluation("fr", 'd');


             var pupilGrade1Plus6 = lstPupils.Where(pupil => pupil.Age >= 6);
                /*from pupil in lstPupils
                                   where pupil.Age>6
                                   select pupil;*/

             /*if(pupilGrade1Plus6 != null)
                foreach (var pupil in pupilGrade1Plus6)
                {
                    System.Console.Write(pupil);
                    System.Console.Read();
                }*/

            List<Person> lstPerson = new List<Person>() { 
                new Pupil("e1", 8),
                new Pupil("e2", 7),
                new Pupil("e3", 1),
                new Pupil("e4", 12),
                new Pupil("e5", 9),
                new Pupil("e6", 10),
                new Pupil("Barnabé", 82),
            };
            List<Person> lstFusion = new List<Person>() { };
            var pupilDiff = lstPupils.Where(pupil => lstPerson.Contains(pupil));

            var fusion = lstPerson.Concat(pupilDiff);

            if (fusion != null)
                foreach (var person in fusion)
                {
                    System.Console.Write(person);
                    System.Console.Read();
                }

             
        }
    }
}
