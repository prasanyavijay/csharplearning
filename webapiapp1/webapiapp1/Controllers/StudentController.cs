﻿using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using webapiapp1.Models;

public class StudentController
{
    /* private Student[] students = new Student[] {
                 new Student() { Id = 1, FirstName = "Bbbb",LastName = "CCCC"},
                 new Student() { Id = 2, FirstName = "Ssss",LastName = "Dddd"},
                 new Student() { Id = 3, FirstName = "Rrrr",LastName = "VVVV"},
                 new Student() { Id = 4, FirstName = "LLLl",LastName = "Mmmm"}
         };*/


    private static ICollection<Student> students1 = new List<Student>();
    public void Studentcollections()
    { 
        var stu = new Student() { Id = 1, FirstName = "Bbbb", LastName = "CCCC" };
        students1.Add(stu);
        stu = new Student() { Id = 2, FirstName = "Ssss", LastName = "Dddd" };
        students1.Add(stu);
        stu = new Student() { Id = 3, FirstName = "Rrrr", LastName = "VVVV" };
        students1.Add(stu);
        stu = new Student() { Id = 4, FirstName = "LLLl", LastName = "Mmmm" };
        students1.Add(stu);

    }

[HttpGet("Student/all")]
    public IList<Student> GetAll()
    {
       Studentcollections();
        /* var res = new List<Student>() {
             new Student(){ Id = 1, FirstName="Bbbb",LastName="CCCC"},
              new Student(){ Id = 2, FirstName="Ssss",LastName="Dddd"},
              new Student(){ Id = 3, FirstName="Rrrr",LastName="VVVV"},
              new Student(){ Id = 4, FirstName="LLLl",LastName="Mmmm"}
          };
        */

        return (IList<Student>)students1;
        /* var res = stud;
         return res;*/
       // return students1;
    }
    [HttpPut("Student/Id")]
    public Student Put(int id)
    {
         Studentcollections();
        /* var res = students1.FirstOrDefault((s) => s.Id == id);         
              s.FirstName=res.FirstName;
            s.LastName = res.LastName;*/
        var student = students1.FirstOrDefault((s) => s.Id == id);
        // student.FirstName = s.FirstName;
        //student.LastName = s.LastName;
        // s.FirstName = student.FirstName;
        // s.LastName = student.LastName;
       // student.FirstName = "FFFFF";
        //student.LastName = "ggggggg";

        var s1 = students1.ElementAt < Student >(id-1);
        s1.FirstName = "qqqqqqq";
        s1.LastName = "ssssssss";
        
        return student;
    }
    [HttpPost("Student")]
    public List<Student> PostNewStudent(Student student1)
    {
        /* student1.Id = 5;
         student1.FirstName = "aasdas";
         student1.LastName = "jkfgjg";
         students.Append(student1);*/

        student1 = new Student() {Id = 5, FirstName = "hhhh", LastName = "tttt"};
        students1.Add(student1);
        // stud.Add(student1);

        return (List<Student>)students1;
    }

    [HttpDelete("Student/Id")]
    public List<Student>  Delete(int id)
    {
        Studentcollections();        
        var student = students1.FirstOrDefault((p) => p.Id == id);

       students1.Remove(student);        
         
        return (List<Student>)students1;
    }
}