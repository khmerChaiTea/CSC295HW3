using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace CSC295HW3.Tests
{
    [TestClass]
    public class SortingAlgorithmsTests
    {
        private List<Student> students;
        private List<Student> expected;

        [TestInitialize]
        public void SetUp()
        {
            students = new List<Student>
            {
                new Student("Allen", 3.5),
                new Student("Berry", 3.2),
                new Student("Ethan", 3.8),
                new Student("Sarah", 4),
                new Student("Jack", 3.2),
                new Student("Jill", 3.0),
            };

            expected = new List<Student>
            {
                new Student("Allen", 3.5),
                new Student("Berry", 3.2),
                new Student("Ethan", 3.8),
                new Student("Sarah", 4),
                new Student("Jack", 3.2),
                new Student("Jill", 3.0),
            };
        }

        [TestMethod]
        public void BubbleSortByGPADescendingTestSortedArray_ArrayShouldToBeSorted()
        {
            // Act
            SortingAlgorithms.BubbleSortByGPADescending(students);

            // Assert
            CollectionAssert.AreEqual(expected, students, new StudentComparer());
        }

        [TestMethod]
        public void SelectionSortByGPADescendingTestSortedArray_ArrayShouldToBeSorted()
        {
            // Act
            SortingAlgorithms.SelectionSortByGPADescending(students);

            // Assert
            CollectionAssert.AreEqual(expected, students, new StudentComparer());
        }

        [TestMethod]
        public void InsertionSortByGPADescendingTestSortedArray_ArrayShouldToBeSorted()
        {
            // Act
            SortingAlgorithms.InsertionSortByGPADescending(students);

            // Assert
            CollectionAssert.AreEqual(expected, students, new StudentComparer());
        }

        [TestMethod]
        public void MergeSortByGPADescendingTestSortedArray_ArrayShouldToBeSorted()
        {
            // Act
            SortingAlgorithms.MergeSortByGPADescending(students);

            // Assert
            CollectionAssert.AreEqual(expected, students, new StudentComparer());
        }

        private class StudentComparer : Comparer<Student>
        {
            public override int Compare(Student x, Student y)
            {
                if (x == null || y == null)
                {
                    return -1;
                }

                if (x.Name == y.Name && x.GPA == y.GPA)
                {
                    return 0;
                }

                return -1;
            }
        }
    }
}
