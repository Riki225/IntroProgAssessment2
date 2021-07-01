using System.Collections.Generic;
using System;
using System.IO;

namespace CivSem1Challenge2_RegistrationSystem.models {
    public class Course {
        public string Name { get; set; }
        public int CourseNo { get; set; }
        public List<Student> Enrolments { get; set; }

        public Course (string name, int courseNo) {
            this.Name = name;
            this.CourseNo = courseNo;
            this.Enrolments = new List<Student>();
        }

        public void GetCourseDetails() {
            Console.WriteLine($"Course Number: {this.CourseNo} --> Course Name: {this.Name}");
        }
    }
}