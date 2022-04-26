using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArtGallery_MVC.Model
{
    internal class Institutions
    {
        protected List<Observer> observedList;

        public void Add(Observer obs)
        {
            observedList.Add(obs);
        }

        public void Delete(Observer obs)
        {
            observedList.Remove(obs);
        }

        public void Notify()
        {
            foreach (Observer obs in observedList)
            {
                obs.Update();
            }
        }
    }
}
