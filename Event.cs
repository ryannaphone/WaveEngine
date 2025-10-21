using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveEngine
{
    public class Event
    {
        public String text;
        public Stage[] stages;

        public Event() : this("Event", new Stage[0])
        {

        }

        public Event(String text, Stage[] stages)
        {
            this.text = text;
            this.stages = stages;
        }
    }
}
