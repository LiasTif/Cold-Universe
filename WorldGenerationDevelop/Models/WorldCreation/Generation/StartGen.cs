namespace WorldGenerationDevelop.Models.WorldCreation.Generation
{
    public class StartGen
    {
        private readonly NameGenerator _nameGen = new NameGenerator();

        private static readonly Galaxy _galaxy = new Galaxy();

        public StartGen()
        {
            _galaxy.Id = IdSetter.GetId();
            _galaxy.Name = _nameGen.GenerateName();
        }

        public Galaxy GetGalaxy()
        {
            return _galaxy;
        }
    }
}