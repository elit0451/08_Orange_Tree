using System;

namespace _08_Orange_Tree
{
    internal class OrangeTree
    {
        public int Age { get; set; }
        public int Height { get; set; }
        public bool TreeAlive { get; internal set; }
        public int NumOranges { get; internal set; }
        public int OrangesEaten { get; internal set; }

        public OrangeTree(int age, int height)
        {
            Age = age;
            Height = height;
        }

        internal void OneYearPasses()
        {
            Age++;
            Height = Height + 2;
            if (Age >= 80)
            {
                TreeAlive = false;
            }
            if (Age >= 2)
            {
                NumOranges = NumOranges + 5;
            }
        }

        internal void EatOrange(int eatenOranges)
        {
            OrangesEaten = OrangesEaten + eatenOranges;
            if (NumOranges < OrangesEaten)
            {
                throw new IndexOutOfRangeException("You can't eat an orange that isn't there!  There are 0 oranges available to eat");
            }
        }
    }
}