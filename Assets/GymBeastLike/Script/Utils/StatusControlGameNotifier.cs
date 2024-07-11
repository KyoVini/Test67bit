using System.Collections.Generic;
using UnityEngine;

namespace GymBeastLike
{
    public class StatusControlGameNofifier : IListenerController
    {
        private List<IStatusGameController> mylistener { get; set; }

        public void Attach(IStatusGameController _listener)
        {
            if (mylistener == null)
            {
                mylistener = new List<IStatusGameController>();
            }
            mylistener.Add(_listener);
        }
        public void Detach(IStatusGameController _listener)
        {
            mylistener.Remove(_listener);
        }

        public void Notify(float moveHorizontal, float moveVertical)
        {
            foreach (var _gamestats in mylistener)
            {
                _gamestats?.OnStatus(moveHorizontal, moveVertical);
            }
        }

    }

}
