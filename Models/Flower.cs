using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MauiApp2.Models
{
    public class Flower
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Signature { get; set; }

        public Flower(string name, string signature)
        {
            // Id = GetLastId() + 1
            Name = name;
            Signature = signature;
        }
        public Flower(int id, string name, string signature)
        {
            Id = id;
            Name = name;
            Signature = signature;
        }
    }
}
