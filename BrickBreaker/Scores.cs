﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickBreaker
{
    class Scores
        //sets up the scores class and list for storing scores
    {
        public static List<Scores> scores = new List<Scores>();
        
        public string name;
       
        public string score;
        public Scores(string _name, string _score)

        {
            name = _name;
            score = _score;
        }
    }
}
