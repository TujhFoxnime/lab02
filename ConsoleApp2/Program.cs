using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Pupil pupil_1 = new Pupil();
            Pupil pupil_2 = new BadPupil();
            Pupil pupil_3 = new GoodPupil();
            Pupil pupil_4 = new ExcellentPupil();

            ClassRoom privateClassRoom = new ClassRoom(pupil_1, pupil_2, pupil_3, pupil_4);
            privateClassRoom.PrintInfoPupil();
        }
    }
}
