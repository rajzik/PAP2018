namespace ConsoleApp1
{
    class Cizinec : Student
    {
        public bool MaSmlouvu { get; set; }

        private const int maxStipendium = 8000;
        private const int minStipendium = 4000;

        public override int GetStipendium
        {
            get
            {
                if (!MaSmlouvu) return minStipendium;
                return maxStipendium;
            }
        }

        public Cizinec(string name, int delkaStudia, bool maSmlouvu) : this(name, delkaStudia) => MaSmlouvu = maSmlouvu;
        public Cizinec(string name, int delkaStudia) : base(name, delkaStudia) => MaSmlouvu = false;
        public override string GetPopis()
        {
            return $"{base.GetPopis()}\n" +
                $"Stipendium: {GetStipendium}\n" +
                $"MaSmlouvu: {(MaSmlouvu?"Ano" : "Ne")}\n" +
                $"Narodnost: Cizinec";
        }
    }
}
