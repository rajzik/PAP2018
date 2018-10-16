namespace ConsoleApp1
{
    partial class Student {
        static int lastId = 0;
        public string Name { get; set; }
        public readonly int Id;
        public int DelkaStudia { get; set; }

        public virtual int GetStipendium { get; }

        public virtual string GetPopis()
        {
            return $"Jmeno: {Name}\n" +
                $"Delka studia: {DelkaStudia}\n" +
                $"Id Studenta: {Id}";
        }

        static int GetId {
            get
            {
                lastId += 1;
                return lastId;
            }
        }

        public Student()
        {
            DelkaStudia = 0;
            Id = Student.GetId;
        }
        public Student(string name) : this() => Name = name;
        public Student(string name, int delkaStudia) : this(name) => DelkaStudia = delkaStudia;
        
    }
}
