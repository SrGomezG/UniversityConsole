using System;
using System.Collections.Generic;
using System.Text;

namespace University
{
    public class Course
    {
        public string Code;
        public string Name;
        private int Shift; //o:night, 1:day

        public void SetShift(int newShift)
        {
            if(newShift == 0 || newShift == 1)
            {
                Shift = newShift;
            }
            else
            {
                Console.WriteLine("La jornada para la asignatura " + Name + "No puede ser != de cero o uno");
            }
        }

        public int GetShift()
        {
            return Shift;
        }
    }
}
