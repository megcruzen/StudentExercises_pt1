using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Student
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Slack {get; set;}
        public List<Exercise> ExerciseList {get; set;}

        public Student(string firstname, string lastname, string slack) {
            FirstName = firstname;
            LastName = lastname;
            Slack = slack;
            ExerciseList = new List<Exercise>();
        }
    }
};