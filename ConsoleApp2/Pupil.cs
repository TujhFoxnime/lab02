using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Pupil
    {
        public virtual void Study() { Console.WriteLine("Pupil can study"); }
        public virtual void Read() { Console.WriteLine("Pupil can read"); }
        public virtual void Write() { Console.WriteLine("Pupil can write"); }
        public virtual void Relax() { Console.WriteLine("Pupil can relax"); }
    }
    class ExcellentPupil : Pupil
    {
        public override void Study() { Console.WriteLine("ExcellentPupil studies"); }
        public override void Read() { Console.WriteLine("ExcellentPupil reads"); }
        public override void Write() { Console.WriteLine("ExcellentPupil writes"); }
        public override void Relax() { Console.WriteLine("ExcellentPupil relaxes"); }
    }

    class GoodPupil : Pupil
    {
        public override void Study() { Console.WriteLine("GoodPupil studies"); }
        public override void Read() { Console.WriteLine("GoodPupil reads"); }
        public override void Write() { Console.WriteLine("GoodPupil writes"); }
        public override void Relax() { Console.WriteLine("GoodPupil relaxes"); }
    }
    class BadPupil : Pupil
    {
        public override void Study() { Console.WriteLine("BadPupil studies"); }
        public override void Read() { Console.WriteLine("BadPupil reads"); }
        public override void Write() { Console.WriteLine("BadPupil writes"); }
        public override void Relax() { Console.WriteLine("BadPupil relaxes"); }
    }
}
