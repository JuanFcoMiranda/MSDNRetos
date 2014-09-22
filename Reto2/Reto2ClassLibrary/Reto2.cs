using System;
using System.Linq;

namespace Reto2ClassLibrary {
    public class Reto2 : IReto2 {

        public event EventHandler EventFired;
        
        public void FireEvent() {
            var eventList = (from i in EventFired.GetInvocationList() orderby (i.Target as Item).Index select i);
            foreach (var evento in eventList) {
                evento.DynamicInvoke(this, null);
            }
        }
    }
}