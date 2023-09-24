using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class ClassRoom
    {
        private Pupil[] privateClassRoom;
        public Pupil[] publicClassRoom { get { return privateClassRoom; } }

        public ClassRoom(params Pupil[] pupils)
        {
            if (pupils.Length < 2 || pupils.Length > 4) { 
                throw new ArgumentException("The class should consist of 2 to 4 pupils");
            }
            privateClassRoom = pupils;
        }

        public void PrintInfoPupil()
        {
            foreach (Pupil pupil in publicClassRoom)
            {
                Console.WriteLine($"Pupil information: {pupil.GetType().Name}");
                pupil.Study();
                pupil.Read();
                pupil.Write();
                pupil.Relax();
                Console.WriteLine("End of information");
            }
        }
    }
}
