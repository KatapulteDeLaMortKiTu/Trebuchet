using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Cette classe est inutile et a été implantée par erreur
 * Il ne faut pas s'en occuper, rien de ce qui est ici n'a été réutilisé dans le code 
 * Voici un kangourou en ASCII pour nous faire pardonner
 *                                                   _  _
                                                 (\\( \
                                                  `.\-.)
                              _...._            _,-'   `-.
\                           ,'      `-._.---.,-'       .  \
 \`.                      ,'                               `.
  \ `-...__              /                           .   .:  y
   `._     ``--..__     /                           ,'`---._/
      `-._         ``--'                      |    /_
          `.._                   _            ;   <_ \
              `--.___             `.           `-._ \ \
                     `--<           `.     (\ _/)/ `.\/
                         \            \     `<a \  /_/
                          `.           ;      `._y
                            `--.      /    _../
                                \    /__..'
                                 ;  //
                                <   \\
                                 `.  \\
                                   `. \\_ __
                                     `.`-'  \\
                                       `----''  
 * 
 * 
 * Merci de votre compréhension
 */



namespace Trebuchet
{
    class Body : Part
    {
        public Body()
        {
            this.Name = "body";
            Connect connect = new Connect();
            PdV = connect.GetLifeAsync(Name);
        }

        public override void Build()
        {
            Console.WriteLine("Le corps est construit");
        }

        public void Maintain(Body body) { }
    }
}