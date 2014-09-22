using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.SULS
{
    class JuniorTrainer : Trainer
    {
        public JuniorTrainer(string name, string lastname, int age) : base(name, lastname, age) { }

        public JuniorTrainer(string name, string lastname) : base(name, lastname) { }

        public JuniorTrainer(string name) : base(name) { }
    }
}
