using System;


namespace oops
{
    internal class EmpClient
    {
        public static void main()
        {
            Employee e = new Employee();
            e.AcceptDetails();
            e.DisplayDetails();

            Employee e1 = new Employee(1000f);
            e1.DisplayDetails();

            Employee e2 = new Employee(1, "Srimathi", 1000);
            e2.DisplayDetails();

            Employee e3 = new Employee(1, 1000f);
            e3.DisplayDetails();

            Employee e4 = new Employee(1000f,1); //- (1000,1) - takes int,float consideration
            e4.DisplayDetails();

            Employee.calculate(); //static method can be accessed only by class name because it is a class method
            

            //GC.Collect();
            
                
        }
    }
}
