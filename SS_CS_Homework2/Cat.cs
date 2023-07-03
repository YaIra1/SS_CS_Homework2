namespace SS_CS_Homework2
{
    public class Cat
    {
        public int FullnessLevel { get; private set; }

        public void EatSomething(Food food)
        {
            FullnessLevel += (int)food;
        }
    }
}
