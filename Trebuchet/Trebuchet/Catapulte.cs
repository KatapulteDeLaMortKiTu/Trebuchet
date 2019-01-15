using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trebuchet
{
    class Catapulte
    {

        public Arm arm;
        public Beam beam;
        public Rope rope;
        public Spoon spoon;
        public Trigger trigger;
        private List<Part> parts= new List<Part>();
        private Connect connect;

        public Catapulte()
        {
            arm = new Arm();
            beam = new Beam();
            rope = new Rope();
            spoon = new Spoon();
            trigger = new Trigger();
            parts.Add(arm);
            parts.Add(beam);
            parts.Add(rope);
            parts.Add(spoon);
            parts.Add(trigger);
            connect = new Connect();
        }

        public void ProcessTir(Rock rock)
        {
            string target = "groupe" + GetTarget();
            int power = rock.width + rock.weight;
            spoon.Load(rock);
            rope.Lower(spoon);
            rope.Pull();
            Console.WriteLine("Prêt à tirer !");
            Console.WriteLine("Appuyez sur une touche pour faire feu sur le " + target);
            Console.ReadKey();
            trigger.Start();
            arm.Move();
            arm.Launch(spoon);
            connect.Fire(power, target);
        }

        public int GetTarget()
        {

            int groupe = new Random().Next(1, 12);
            if (groupe == 9)
            {
                groupe--;
            }

            return groupe;
        }

        public void CheckLifeThenHeal()
        {
            foreach(Part element in parts)
            {
                if(element.GetLife() < 50)
                {
                    connect.Heal(element.GetName());
                }
            }
        }
        public bool CheckIfBroken()
        {
            Console.WriteLine("###");
            foreach (Part element in parts)
            {
                if (element.Broken)
                {
                    //Throw une exception si l'élement est cassé
                    throw new LifeException(element.GetName());
                }
                else
                {
                    Console.WriteLine(element.GetName() + " checked !");
                }
            }
            Console.WriteLine("###");
            return false;
        }
    }
}
