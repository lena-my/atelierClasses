using AtelierClasses;

// create new students
Student mary = new Student("Mary", new List<float> {10f, 3f, 2.5f, 8f});
Student paul = new Student("Paul", new List<float> {8f, 4.6f, 14.6f, 19.5f});
Student Gary = new Student("Gary", new List<float> {15.4f, 14.3f, 10f, 8.4f});

List<Student> students = new List<Student> {mary, paul};

students.Add(Gary);

Campus university = new Campus("University", students);

mary.TalkToSomeone(paul);
paul.ShoutAtSomeone(mary);


university.DisplayStudents(students); // displays the names of all students

university.GetAverageGrades(students); // get the average grades from this campus




