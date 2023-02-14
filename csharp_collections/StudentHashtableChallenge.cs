using csharp_collections;
using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_collections
{
    class StudentHashtableChallenge
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public float GPA { get; set; }


        public StudentHashtableChallenge(int id, string name, float GPA)
        {
            this.Id = id;
            this.Name = name;
            this. GPA = GPA;
        }
    }
}

