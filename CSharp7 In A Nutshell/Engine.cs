namespace CSharp7_In_A_Nutshell
{
    public class Engine
    {
        public string Name { get; set; }
        public Manufacturer EngineManufacturer { get; set; }
        public EngineType Type { get; set; }


        public enum Manufacturer
        {
            None,
            Mitsubishi,
            Bmw,
            Tesla
        }

        public enum EngineType
        {
            None,
            Gasoline,
            Diesel,
            Hydrogen,
            Electric
        }
    }
}