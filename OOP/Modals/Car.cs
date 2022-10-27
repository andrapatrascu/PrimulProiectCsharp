namespace OOP.Modals
{
    class Car
    {
        public int Id { get; set; }
        public string Color = "red";
        public int MaxSpeed;
        public CarType CarType;

    }

    public enum CarType
    {
        Toyota,
        Dacia,
        Mazda,
    }
}

