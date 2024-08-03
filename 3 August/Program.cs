using System.Security.Claims;

namespace CollegeDetails
{
    public class Program
    {
        public static void Main(string[] args)
        {
            College college = new College(1,"JSM");

            Student student1 = new Student(1,"Shantanu");
            Student student2 = new Student(2,"Prasad");

            college.students.Add(student1);
            college.students.Add(student2);

            Professor professor1 = new Professor(101, "Rohit");
            Professor professor2 = new Professor(102, "Kalyani");

            college.professors.Add(professor1);
            college.professors.Add(professor2);

            Department department1 = new Department(1001, "Computer");
            Department department2 = new Department(1002, "Civil");

            college.departments.Add(department1);
            college.departments.Add (department2);


            PrintDetails(college,college.students,college.professors,college.departments);

            DeleteDetails(college);

            UpdateDetails(college);

            AddDetails(college);

            PrintDetails(college,college.students,college.professors,college.departments);
        }

        public static void DeleteDetails(College college)
        {
            Console.WriteLine("Enter the type of detail to delete (Student/Professor/Department):");
            string type = Console.ReadLine();
            Console.WriteLine("Enter the ID of the detail to delete:");
            int id = int.Parse(Console.ReadLine());

            switch (type)
            {
                case "student":
                    Student studentToRemove = null;
                    foreach (var student in college.students)
                    {
                        if (student.StuId == id)
                        {
                            studentToRemove = student;
                            break;
                        }
                    }
                    if (studentToRemove != null)
                    {
                        college.students.Remove(studentToRemove);
                        Console.WriteLine("Student with ID " + id + " has been removed.");
                    }
                    else
                    {
                        Console.WriteLine("Student with ID " + id + " not found.");
                    }
                    break;

                case "professor":
                    Professor professorToRemove = null;
                    foreach (var professor in college.professors)
                    {
                        if (professor.ProfId == id)
                        {
                            professorToRemove = professor;
                            break;
                        }
                    }
                    if (professorToRemove != null)
                    {
                        college.professors.Remove(professorToRemove);
                        Console.WriteLine("Professor with ID " + id + " has been removed.");
                    }
                    else
                    {
                        Console.WriteLine("Professor with ID " + id + " not found.");
                    }
                    break;

                case "department":
                    Department departmentToRemove = null;
                    foreach (var department in college.departments)
                    {
                        if (department.DeptId == id)
                        {
                            departmentToRemove = department;
                            break;
                        }
                    }
                    if (departmentToRemove != null)
                    {
                        college.departments.Remove(departmentToRemove);
                        Console.WriteLine("Department with ID " + id + " has been removed.");
                    }
                    else
                    {
                        Console.WriteLine("Department with ID " + id + " not found.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid type entered.");
                    break;
            }
        }


        public static void PrintDetails(College college,List<Student> students, List<Professor> professors, List<Department> departments)
        {
            Console.WriteLine("College ID : " + college.ClgId);
            Console.WriteLine("College Name : " + college.ClgName);

            Console.WriteLine();

            Console.WriteLine("Number of students : " + students.Count);
            Console.WriteLine("Number of Professors : " + professors.Count);
            Console.WriteLine("Number of Departments : " + departments.Count);

            Console.WriteLine();

            foreach (Student student in students)
            {
                Console.WriteLine("Student Id : " + student.StuId + "    Student Name : " + student.StuName);
            }
            Console.WriteLine();
            foreach (Professor prof in professors)
            {
                Console.WriteLine("Professor Id : " + prof.ProfId + "    Professor Name : " + prof.ProfName);
            }
            Console.WriteLine();
            foreach (Department dept in departments)
            {
                Console.WriteLine("Department Id : " + dept.DeptId + "    Department Name : " + dept.DeptName);
            }

        }

        public static void AddDetails(College college)
        {
            Console.WriteLine("Enter the entity to Add \n1.Student \n2.Professor \n3.Department ");
            int type = int.Parse(Console.ReadLine());
            switch (type)
            {
                case 1:
                    Console.WriteLine("Enter student ID ");
                    int studId = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter student Name ");
                    string studName = Console.ReadLine();

                    college.students.Add(new Student(studId, studName));
                    Console.WriteLine("Student Added successfully ");
                    break;

                case 2:
                    Console.WriteLine("Enter professor ID ");
                    int profId = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter student Name ");
                    string profName = Console.ReadLine();

                    college.professors.Add(new Professor(profId, profName));
                    Console.WriteLine("Professor Added successfully ");
                    break;
                case 3:
                    Console.WriteLine("Enter Department ID ");
                    int deptId = int.Parse(Console.ReadLine());

                    Console.WriteLine("Enter department Name ");
                    string deptName = Console.ReadLine();

                    college.departments.Add(new Department(deptId, deptName));
                    break;
                default:
                    Console.WriteLine("Invalid choice");
                    break;
            }
        }
       

        public static void UpdateDetails(College college)
        {
            Console.WriteLine("Enter the type of detail to update (Student/Professor/Department):");
            string type = Console.ReadLine();
            Console.WriteLine("Enter the ID of the detail to update:");
            int id = int.Parse(Console.ReadLine());

            switch (type)
            {
                case "student":
                    Student studentToUpdate = null;
                    foreach (var student in college.students)
                    {
                        if (student.StuId == id)
                        {
                            studentToUpdate = student;
                            break;
                        }
                    }
                    if (studentToUpdate != null)
                    {
                        Console.WriteLine("Enter new name for Student with ID " + id + ":");
                        studentToUpdate.StuName = Console.ReadLine();
                        Console.WriteLine("Student details updated.");
                    }
                    else
                    {
                        Console.WriteLine("Student with ID " + id + " not found.");
                    }
                    break;

                case "professor":
                    Professor professorToUpdate = null;
                    foreach (var professor in college.professors)
                    {
                        if (professor.ProfId == id)
                        {
                            professorToUpdate = professor;
                            break;
                        }
                    }
                    if (professorToUpdate != null)
                    {
                        Console.WriteLine("Enter new name for Professor with ID " + id + ":");
                        professorToUpdate.ProfName = Console.ReadLine();
                        Console.WriteLine("Professor details updated.");
                    }
                    else
                    {
                        Console.WriteLine("Professor with ID " + id + " not found.");
                    }
                    break;

                case "department":
                    Department departmentToUpdate = null;
                    foreach (var department in college.departments)
                    {
                        if (department.DeptId == id)
                        {
                            departmentToUpdate = department;
                            break;
                        }
                    }
                    if (departmentToUpdate != null)
                    {
                        Console.WriteLine("Enter new name for Department with ID " + id + ":");
                        departmentToUpdate.DeptName = Console.ReadLine();
                        Console.WriteLine("Department details updated.");
                    }
                    else
                    {
                        Console.WriteLine("Department with ID " + id + " not found.");
                    }
                    break;

                default:
                    Console.WriteLine("Invalid type entered.");
                    break;
            }
        }

    }
}