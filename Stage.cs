using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveEngine
{
    public class Stage
    {
        public String text;
        public Option[] options;
        public int backgroundState;
        public int chatState;
        public int songState;

        public Stage() : this("Default Stage", new Option[0])
        {

        }

        public Stage(String text, Option[] options)
        {
            this.text = text;
            this.options = options;
            this.backgroundState = -1;
            this.chatState = -1;
            this.songState = -1;
        }

        public Stage(String text, Option[] options, int bState, int cState, int sState)
        {
            this.text = text;
            this.options = options;
            this.backgroundState = bState;
            this.chatState = cState;
            this.songState= sState;
        }

        public String ToString()
        {
            String str = " ~ " + text + " ~ " + "\n";
            for (int i = 0; i < options.Length; i++)
            {
                str += "["+ (i+1) + "] " + options[i].ToString();
            }
            return str;
        }
    }

    public class freeStage : Stage 
    { 

    }
}
