namespace Task9
{
    internal class Manager
    {
        public IIntroduce Entity { get; set; }

        public Manager(IIntroduce entity)
        {
            Entity = entity;
        }

        public string GetVehicleInfo()
        {
            if (Entity == null)
            {
                return "There is no vehicle";
            }
            return Entity.Introduce();
        }
    }
}
