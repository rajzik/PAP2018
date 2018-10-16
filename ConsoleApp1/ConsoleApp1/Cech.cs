namespace ConsoleApp1
{
    class Cech : Student
    {
        public int Vzdalenost { get; set; }
        private const int maxStipendium = 5000;
        private const int minStipendium = 0;

        public override int GetStipendium => DelkaStudia <= 5 ? minStipendium : maxStipendium;

        public Cech(string name, int delkaStudia, int vzdalenost) : base(name, delkaStudia) => Vzdalenost = vzdalenost;

        public override string GetPopis()
        {
            return $"{base.GetPopis()}\n" +
                $"Stipendium: {GetStipendium}\n" +
                $"Vzdalenost: {Vzdalenost}\n" +
                $"Narodnost: Cech";
        }
    }
}
