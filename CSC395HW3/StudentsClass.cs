using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSC295HW3
{
    // Class representing a Student
    public class Student
    {
        // Properties
        public string Name { get; set; }
        private double gpa; // backing field for GPA

        // GPA property with validation
        public double GPA
        {
            get { return gpa; }
            set
            {
                // Validate GPA range (0 to 4)
                if (value < 0 || value > 4)
                {
                    throw new ArgumentOutOfRangeException(nameof(value), "GPA should be between 0 and 4.");
                }
                gpa = value; // Set GPA value if valid
            }
        }

        // Constructor
        public Student(string name, double gpa)
        {
            Name = name; // Initialize Name
            GPA = gpa;   // Initialize GPA (setter validates input)
        }

        // Override ToString() method to display student information
        public override string ToString()
        {
            return $"Student{{Name='{Name}', GPA={GPA}}}";
        }
    }
}
