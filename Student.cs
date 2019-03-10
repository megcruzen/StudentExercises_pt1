using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Student
    {
        // Properties
        // public int Id {get; set;}
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Slack {get; set;}
        public List<Exercise> ExerciseList {get; set;}

        // Relationship Properties
        public Cohort Cohort {get; set;}

        public Student(string firstname, string lastname, string slack, Cohort cohort) {
        // public Student(string firstname, string lastname, string slack) {
            FirstName = firstname;
            LastName = lastname;
            Slack = slack;
            Cohort = cohort;
            ExerciseList = new List<Exercise>();
        }
    }
};