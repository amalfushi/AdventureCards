using System;

namespace AdventureCards
{
    public class Resource: Card
    {
        public int value { get; set; }

        public Resource(string name, string description, int value, Action onSpending = null): base(name, "Resource", description)
        {
            this.value = value;
        }
    }
}