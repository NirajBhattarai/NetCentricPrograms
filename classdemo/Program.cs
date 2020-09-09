using System;

namespace classdemo
{

public class Student{

 
    private string firstName;
    private string lastName;
    private int rollno;
    private string collegeName; 

    private void setFirstName(string firstName)
    {
        this.firstName = firstName;
    }

    public void setLastName(string lastName)
    {
        this.lastName = lastName;
    }

    public void setRollno(int rollno)
    {
        this.rollno = rollno;
    }

    public void setCollegeName(string collegeName)
    {
        this.collegeName = collegeName;
    }

    public string getFirstName()
    {
        return this.firstName;
    }

    public string getLastName()
    {
        return this.lastName;
    }
    public int getrollno()
    {
        return this.rollno;
    }

    public string getCollegeName()
    {
       return this.collegeName;
    }
    
 
}

    class Program
{

        static void Main(string[] args)
    {


     Student student = new Student();
     student.setFirstName("kushal");
     student.firstName = "lkjlkj"
     student.getLastName="lkasjskldj"

     connection.save(student);

     
            
        }
    }
}
