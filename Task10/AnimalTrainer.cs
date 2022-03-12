namespace Task10
{
    internal class AnimalTrainer
    {
        public IMakeNoise Entity { get; set; }

        public AnimalTrainer(IMakeNoise entity)
        {
            Entity = entity;
        }

        public string TrainAnimal()
        {
            if (Entity == null)
            {
                return "There is no Animal to train.";
            }
            return Entity.MakeNoise();
        }
    }
}
