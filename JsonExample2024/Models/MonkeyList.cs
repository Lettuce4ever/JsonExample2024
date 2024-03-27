using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonExample2024.Models
{
    public class MonkeyList
    {
        public List<Monkey> Monkeys { get; set; }

        public override string ToString()
        {
            string monkeystext = "";
            foreach (var monkey in Monkeys)
            {
                monkeystext += $"{monkey}\n";
            }
            return monkeystext;
        }
    }
}
