using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace delegates_example__part_36
{
    /*public delegate void delegateDec(string info);
    class Program
    {
        static void Main(string[] args)
        {
            delegateDec dec = new delegateDec(function);
            dec("message  print from delegate");
        }
        public static void function(string message) {
            Console.WriteLine(message);
            Console.ReadLine();
        }
    }*/
    /*  class Program {
          static void Main(string[] args)
          { 
              List<employee> employeesInfo = new List<employee>();
              employeesInfo.Add(new employee(){id = 1,name = "hasan",salary=6});
              employeesInfo.Add(new employee(){id = 1,name = "hasan2",salary=4});
              employeesInfo.Add(new employee(){id = 1,name = "hasan3",salary=8});
              employeesInfo.Add(new employee(){id = 1,name = "hasan4",salary=1});
              employee.passvalue(employeesInfo);
          }
      }

      class employee {
         public int id{get;set;}
         public string name{get;set;}
         public int salary{get;set;}

         public static void passvalue(List<employee> employeeList)
         {
              foreach(employee emp in employeeList){
                  if (emp.salary > 5)
                      Console.WriteLine("salary will be promoted for {0}" + emp.name);
              }
              Console.ReadLine();
         }
      }

      class Program
      {
          static void Main(string[] args)
          {
              List<employee> emp = new List<employee>();
              emp.Add(new employee(){ID = 1,Name = "hasan1",Salary = 6});
              emp.Add(new employee(){ID = 2,Name = "hasan2",Salary = 3});
              emp.Add(new employee(){ID = 3,Name = "hasan3",Salary = 7});
              emp.Add(new employee(){ID = 4,Name = "hasan4",Salary = 9});
            
              delegateTesting test = new delegateTesting(function);
              employee.ispromote(emp,test);

            
          }
          public static bool function(employee empsal)
          {
              if (empsal.Salary > 5)
                  return true;

                  //Console.WriteLine(empsal.Name+" promoted");
              else
                  return false;
          }
      }
       delegate bool delegateTesting(employee emp);
      class employee {
          public int ID { get; set; }
          public string  Name { get; set; }
          public int Salary { get; set; }

          public static void ispromote(List<employee> empList,delegateTesting delegtest )
          { 
              foreach( employee emp in empList){
                  if (delegtest(emp))
                      Console.WriteLine(emp.Name);
              }
              Console.ReadLine();
          }
      }*/


    /*
     
     *      
     *      public delegate void delegateDec(string info);
            
     *      delegateDec dec = new delegateDec(function);
 
     * dec("message  print from delegate");*/
    
    /// <summary>
    /// /////////////////////without using annoymous method//////////
    /// </summary>
 /*    class Program
    {

        static void Main(string[] args)
          {
              List<employee> listemployee = new List<employee>(){
                new employee{ID = 101,Name="hasan1"},
                new employee{ID = 102,Name="hasan2"},
                new employee{ID = 103,Name="hasan3"},
              };

              //step 2
              Predicate<employee> pre = new Predicate<employee>(function);

              //step 3  
          employee empInfo =  listemployee.Find(emp=>function(emp));
          Console.WriteLine(empInfo.ID +" "+empInfo.Name);
          Console.Read();
        }
        //step 1
        public static bool function(employee emp) {
            return emp.ID == 102;
        }


    }
   public class employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int salary { get; set; }

    }

}
*/
/// /////////////////////n   END without using annoymous method//////////
/// ///////////////////// using annoymous method//////////
/// 
    /*class Program
    {

        static void Main(string[] args)
        {
            List<employee> listemployee = new List<employee>(){
                new employee{ID = 101,Name="hasan1"},
                new employee{ID = 102,Name="hasan2"},
                new employee{ID = 103,Name="hasan3"},
              };

 
            //step 3  
            employee empInfo = listemployee.Find(delegate(employee emp) {
                return emp.ID == 102;
            });
            Console.WriteLine(empInfo.ID + " " + empInfo.Name);
            Console.Read();
        }
        

    }
    public class employee
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int salary { get; set; }

    }*/

///////////////////////////////lemda empression///////////////////////////////////////
    class Program
    {

        static void Main(string[] args)
        {
            string[] digits = { "zero", "one", "two", "three", "four", "five", 
            "six", "seven", "eight", "nine" };

            Console.WriteLine("Example that uses a lambda expression:");
            var shortDigits = digits.Where((digit, index) => digit.Length < index);
            foreach (var sD in shortDigits)
            {
                Console.WriteLine(sD);
            }


            List<int> elements = new List<int>() { 10, 20, 31, 40,41 };
            // ... Find index of first odd element.
            var oddIndex = elements.FindIndex(x => x % 2 != 0);
            
        }
    }
}