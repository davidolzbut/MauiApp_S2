using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Models
{
    public class Flower
    {
        public string Name { get; set; }
        public string Signature { get; set; }

        public Flower(string name, string signature)
        {
            Name = name;
            Signature = signature;
        }
    }
}
