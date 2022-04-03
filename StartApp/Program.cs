namespace StartApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Department department1 = new Department();
            department1.DepartmentName = "Electrical and Electronic Engineering";
            department1.Course = 6;
            department1.Teacher = 6;
            department1.Student = 30;
            
            Department department2= new Department();
            department2.DepartmentName = "Civil Engineering";
            department2.Course = 6;
            department2.Teacher = 6;
            department2.Student = 30;
            
            Department department3= new Department();
            department3.DepartmentName = "Computer Engineering";
            department3.Course = 6;
            department3.Teacher = 6;
            department3.Student = 30;

            Console.WriteLine("<<<<< University >>>>> ");

            Department[] departments = new Department[] {department1,department2,department3 };
            foreach (var departmentitem in departments)
            {
                Console.WriteLine(
                    departmentitem.DepartmentName + " >> Courses: " +
                    departmentitem.Course + " >> Teachers: " +
                    departmentitem.Teacher + " >> Students: " + 
                    departmentitem.Student);
            }

            Console.WriteLine("<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>");

            for (int i = 0; i <departments.Length ; i++)
            {
                Console.WriteLine(
                    departments[i].DepartmentName+ " >> Courses: " +
                    departments[i].Course+ " >> Teachers: " +
                    departments[i].Teacher+ " >> Students: " +
                    departments[i].Student);
            }

            Console.WriteLine("<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>");
            Console.WriteLine("<<<<<<<<<<<>>>>>>>>>>>>>>>>>>>");

            int sayi = 0;

            while (sayi<departments.Length)
            {
                Console.WriteLine(
                    departments[sayi].DepartmentName + " >> Courses: " +
                    departments[sayi].Course + " >> Teachers: " +
                    departments[sayi].Teacher + " >> Students: " +
                    departments[sayi].Student);
                sayi++;
                    
            }
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>");
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>");
            Console.WriteLine("<<<<<<<<<<<<<<<<<<<>>>>>>>>>>>>>>>>");

            AddDepartment addDepartment= new AddDepartment();
            addDepartment.newDepartment(department1);
           

        }
    }
    
}