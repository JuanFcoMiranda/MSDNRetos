using System;
using System.Linq;

namespace Reto2ClassLibrary {
    public class Reto2 : IReto2 {
        private event EventHandler eventFired;
        public event EventHandler EventFired {
            add {
                if (value.Target is Item) {
                    eventFired += value;
                }
            }
            remove {
                eventFired -= value;
            }
        }
        
        public void FireEvent() {
            var eventList = (from i in eventFired.GetInvocationList() orderby ((Item)i.Target).Index select i);
            foreach (var evento in eventList) {
                evento.DynamicInvoke(this, null);
            }
        }
    }
}