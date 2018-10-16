namespace ConsoleApp1
{
    class Slovak : Student
    {
        public float Prumer { get; set; }

        private const int maxStipendium = 5500;
        private const int minStipendium = 0;


        public override int GetStipendium { get
            {
                if (DelkaStudia <= 5 && Prumer <= 1.5) return minStipendium;
                return maxStipendium;
            }
        }

        public Slovak(string name, int delkaStudia) : base(name, delkaStudia) => Prumer = 0;
        public Slovak(string name, int delkaStudia, float prumer) : this(name, delkaStudia) => Prumer = prumer;

        public override string GetPopis()
        {
            return $"{base.GetPopis()}\n" +
                $"Stipendium: {GetStipendium}\n" +
                $"Prumer: {Prumer}\n" +
                $"Narodnost: Slovak";
        }
    }
}
