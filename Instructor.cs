using System;
using System.Collections.Generic;

namespace StudentExercises
{
    class Instructor
    {
        public string FirstName {get; set;}
        public string LastName {get; set;}
        public string Slack {get; set;}
        public Cohort Cohort {get; set;}

        public Instructor(string firstname, string lastname, string slack, Cohort cohort) {
            FirstName = firstname;
            LastName = lastname;
            Slack = slack;
            Cohort = cohort;
        }

        // Method to assign an exercise to a student
        public void AssignExercise(Cohort cohort, Exercise exercise) {
            // loop over each student per cohort
            foreach (Student student in cohort.StudentList) {
                // add exercise to student.ExerciseList
                student.ExerciseList.Add(exercise);
                // Console.WriteLine($"{exercise.Name} was added to {student.FirstName}'s list");
            }
        }
    }
}