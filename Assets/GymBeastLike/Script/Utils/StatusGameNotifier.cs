using System.Collections.Generic;
using UnityEngine;

namespace GymBeastLike
{
    public class Notifier : IListener
    {
        private List<IStatusGame> mylistener { get; set; }

        public void Attach(IStatusGame _listener)
        {
            if (mylistener == null)
            {
                mylistener = new List<IStatusGame>();
            }
            mylistener.Add(_listener);
        }
        public void Detach(IStatusGame _listener)
        {
            mylistener.Remove(_listener);
        }

        public void Notify()
        {
            foreach (var _gamestats in mylistener)
            {
                _gamestats?.OnStatus();
            }
        }

    }

}
