using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Button
{
    class ButtonClass
    {
        public delegate void ClickMess(string mess);
        public event ClickMess Click; 

        public string Name { get; set; }

        public ButtonClass(string name)
        {
            Name = name;
        }
        public void ClickButton()
        {
            Click?.Invoke(Name);
        }
    }
}
