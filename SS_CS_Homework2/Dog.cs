namespace SS_CS_Homework2
{
    public struct Dog
    {
        public string Name;
        public string Mark;
        public int Age;

        public override string ToString()
        {
            return $"{Name}, {Mark}, {Age}";
        }
    }
}
