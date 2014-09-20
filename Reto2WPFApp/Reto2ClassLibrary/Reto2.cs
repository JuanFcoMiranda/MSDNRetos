using System;
using System.Collections.Generic;
using System.Linq;

namespace Reto2ClassLibrary {
    public class Reto2 : IReto2 {
        private IList<Item> items;

        private event EventHandler _eventFired;
        public event EventHandler EventFired {
            add {
                if (_eventFired == null)
                    items = new List<Item>();
                _eventFired += value;
                items.Add(value.Target as Item);
            }
            remove {
                if (_eventFired != null)
                    _eventFired -= value;
            }
        }

        public void FireEvent() {
            items = (from i in items orderby i.Index select i).ToList();
            foreach (var item in items) {
                item.OnEvent(this, new EventArgs());
            }
        }
    }
}