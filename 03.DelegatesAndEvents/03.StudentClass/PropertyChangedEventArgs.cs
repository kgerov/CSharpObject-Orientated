using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.StudentClass
{
    public class PropertyChangedEventArgs : EventArgs
    {
        private string propName;
        private string oldValue;
        private string newValue;

        public PropertyChangedEventArgs(string name, string oldV, string newV) 
        {
            this.propName = name;
            this.oldValue = oldV;
            this.newValue = newV;
        }

        public string PropName
        {
            get { return this.propName; }
        }

        public string OldValue
        {
            get { return this.oldValue; }
        }
        public string NewValue
        {
            get { return this.newValue; }
        }
    }
}
