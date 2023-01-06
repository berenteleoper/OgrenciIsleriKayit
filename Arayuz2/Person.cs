using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Arayuz2
{
    public class Person
    {
        public int personId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    public class Teacher : Person
    {

    }
    public class Student : Person
    {
    }
    public interface IPerson
    {
        
        void Add(Person  prs);
        void Remove(int id);
        Person Find(int id);
        List<Person> List();
    }
    public class StudentManager : IPerson
    {
        List<Person> StudentList = new List<Person>();
        public void Add(Person prs)
        {
            
            var ogrenci = Find(prs.personId);
            if (ogrenci==null)
            {
                
                StudentList.Add(prs);
            }
            else
            {  
                ogrenci.Name = prs.Name;
                ogrenci.LastName = prs.LastName;
                ogrenci.Age = prs.Age;
            }
         
        }

        public Person Find(int id)
        {
            return StudentList.FirstOrDefault(x => x.personId == id);
        }

        public List<Person> List()
        {
            return StudentList;
        }

        public void Remove(int id)
        {
            
            StudentList.RemoveAll(x => x.personId == id);
        }
    }
    public class TeacherManager : IPerson
    {
        List<Person> TeacherList = new List<Person>();
        public void Add(Person prs)
        {
            
            var ogrenci = Find(prs.personId);
            if (ogrenci == null)
            {
                
                TeacherList.Add(prs);
            }
            else
            {  
                ogrenci.Name = prs.Name;
                ogrenci.LastName = prs.LastName;
                ogrenci.Age = prs.Age;
            }

        }

        public Person Find(int id)
        {
            return TeacherList.FirstOrDefault(x => x.personId == id);
        }

        public List<Person> List()
        {
            return TeacherList;
        }

        public void Remove(int id)
        {
            
            TeacherList.RemoveAll(x => x.personId == id);
        }
    }


}

