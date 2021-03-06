﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trebuchet
{
    public class Arm : Part
    {
        public bool Action { get; set; }
        public int Speed { get; set; }

        public Arm()
        {
            this.Name = "arm";
            Connect connect = new Connect();
            PdV = connect.GetLifeAsync(Name);
        }

        public void Move()
        {
            this.Action = true;
        }

        public void Launch(Spoon spoon)
        {
            spoon.Loaded = false;
        }

        public void Launch() //Polymorphisme
        {
            Console.WriteLine("Tir à vide !");
        }

        //Override de la fonction virtuelle Part.Build()

        public override void Build()
        {
            Console.WriteLine("Le bras est construit");
        }
    }
}
