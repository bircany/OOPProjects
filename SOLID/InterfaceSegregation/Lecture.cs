using System;

namespace InterfaceSegregation
{
    public class Lecture : IResearchAssistance
    {
        public void Lecturing()
        {
            throw new NotImplementedException();
        }

        public void Researching()
        {
            throw new NotImplementedException();
        }
    }
}
