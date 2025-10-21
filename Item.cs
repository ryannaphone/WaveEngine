using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace WaveEngine
{
    public class Item
    {
        public String name;
        public float condition;
        public int quantity;
        public Boolean stackable;

        public Item() : this("Wave", (float)3.14)
        { 
            this.stackable = true;
        }

        public Item(String name, float condition) : this(name, condition, 1)
        {
            this.stackable = false;
        }

        public Item(String name, float condition, int quantity)
        {
            this.name = name;
            this.condition = condition;
            this.quantity = quantity;
            this.stackable = true;
        }
        
    }

    public class Package : Item
    {
        public Person recipient;

        public Package() : base()
        {
            recipient = new Person();
        }

        public Package(String name, float condition, int quantity, Person recipient) : base (name, condition)
        {
            this.name=name;
            this.condition = condition;
            this.quantity=quantity;
            this.recipient = recipient;
            this.stackable=true;
        }
        public Package(String name, float condition, Person recipient) : base(name, condition)
        {
            this.name = name;
            this.condition = condition;
            this.quantity = 1;
            this.recipient = recipient;
            this.stackable = false;
        }
    }
}
