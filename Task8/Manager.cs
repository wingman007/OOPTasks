namespace Task8
{
    internal class Manager
    {
        public IIntorducable Entity { get; set; }

        public Manager(IIntorducable entity)
        {
            Entity = entity;
        }

        public string GetAnimalInfo()
        {
            if (Entity == null)
            {
                return "There is no animal";
            }
            return Entity.IntroduceYourself();
        }
    }
}
