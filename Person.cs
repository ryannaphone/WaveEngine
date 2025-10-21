using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveEngine
{
    public class Person
    {
        public string name;
        public int likes;
        public Event[] events;
        public Item[] items;


        public Person() : this("Sine", 0, new Event[0], new Item[0])
        {

        }

        public Person(String name, int likes, Event[] events, Item[] items)
        {
            this.name = name;
            this.likes = likes;
            this.events = events;
            this.items = items;
        }
    }
}
