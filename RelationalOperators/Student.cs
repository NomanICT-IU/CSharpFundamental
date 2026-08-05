namespace RelationalOperators
{
    internal class Student
    {
        private string _name;
        private int _age;

        public Student(string name, int age)
        {
            _name = name;
            _age = age;
        }

        public string Name { get => _name; }
        public int Age { get => _age; }
    }
}
