﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SendData
{
    public class user
    {
        string name;
        int score;
        DateTime date;

        public user(string nameUser, int scoreUser)
        {
            name = nameUser;
            score = scoreUser;
            date = DateTime.Now;
        }

        public override string ToString()
        {
            return name + " " + date + " " + score;
        }

    }
}
