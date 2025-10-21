using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WaveEngine
{
    public class Option
    {
        public String text;
        public String hoverText;
        public int resultStageT;
        public int resultStageF;
        public int resultEventT;
        public int resultEventF;

        public int likesT;
        public int likesF;

        public Option() : this("Continue.", 0)
        {
            
        }

        public Option(String text, int RST) : this(text, RST, RST, -1, -1, 0, 0)
        {

        }

        public Option(String text, int RST, int RSF) : this(text, RST, RSF, -1, -1, 0, 0)
        {

        }

        public Option(String text, int RST, int RSF, int RET, int REF, int lT, int lF)
        {
            this.text = text;
            this.hoverText = "";
            
            this.resultStageT = RST;
            this.resultStageF = RSF;

            this.resultEventT = RET;
            this.resultEventF = REF;

            this.likesT = lT;
            this.likesF = lF;
        }

        public Option(String text, String hoverText, int RST, int RSF, int RET, int REF, int lT, int lF)
        {
            this.text = text;
            this.hoverText = hoverText;

            this.resultStageT = RST;
            this.resultStageF = RSF;

            this.resultEventT = RET;
            this.resultEventF = REF;

            this.likesT = lT;
            this.likesF = lF;
        }


        public String ToString()
        {
            return this.text;
        }

    }

    public class FreeOption : Option
    {

    }

    
}
