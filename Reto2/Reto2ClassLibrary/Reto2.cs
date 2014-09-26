using System;
using System.Linq;

namespace Reto2ClassLibrary {
    public class Reto2 : IReto2 {
        private event EventHandler eventFired;
        public event EventHandler EventFired {
            add {
                if (value != null && value.Target is Item) {
                    eventFired += value;
                    var orderedEvents = from ev in eventFired.GetInvocationList()
                        let evento = ev.Target as Item
                        orderby evento.Index
                        select ev;
                    foreach (EventHandler evento in eventFired.GetInvocationList()) {
                        eventFired -= evento;
                    }
                    foreach (EventHandler evento in orderedEvents) {
                        eventFired += evento;
                    }
                }
            }
            remove {
                eventFired -= value;
            }
        }
        
        public void FireEvent() {
            eventFired.DynamicInvoke(this, EventArgs.Empty);
        }
    }
}