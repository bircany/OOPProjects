using System;
using System.Collections;
using System.Collections.Generic;

namespace StudentManagementApp
{
    public class StudentCollection : ICollection<Student>
    {
        private readonly List<Student> students = new List<Student>();
        public int Count => students.Count;
        public bool IsReadOnly => false;

        public void Add(Student student) => students.Add(student);
        public void Clear() => students.Clear();
        public bool Contains(Student student) => students.Contains(student);
        public void CopyTo(Student[] array, int arrayIndex) => students.CopyTo(array, arrayIndex);
        public bool Remove(Student student) => students.Remove(student);

        public IEnumerator<Student> GetEnumerator() => students.GetEnumerator();
        IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    }
}
