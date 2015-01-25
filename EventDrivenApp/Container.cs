using System;
using System.Collections.Generic;

namespace EventDrivenApp
{
    public delegate void AfterAddedHandler(object obj, EventArgs eventArgs);
    public delegate void AfterRemovedHandler(object obj, EventArgs eventArgs);

    public class Container
    {
        public event AfterAddedHandler AfterAddedEvent;
        public event AfterRemovedHandler AfterRemovedEvent;

        List<string> contentList = new List<string>();

        public void Add(string aContent)
        {
            contentList.Add(aContent);
            EventArgs eventArgs = new EventArgs();
            DoAfterAdded(this, eventArgs);
        }

        private void DoAfterAdded(object itemRepo, EventArgs eventArgs)
        {
            if (AfterAddedEvent != null)
            {
                AfterAddedEvent(itemRepo, eventArgs);
            }
        }

        private void DoAfterRemoved(object itemRepo, EventArgs eventArgs)
        {
            if (AfterRemovedEvent != null)
            {
                AfterRemovedEvent(itemRepo, eventArgs);
            }
        }

        public int Count()
        {
            return contentList.Count;
        }

        public List<string> GetItems()
        {
            return contentList ;
        }

        public void Remove(int index)
        {
            if (index>=0 && contentList[index] != null)
            {
                contentList.RemoveAt(index);
                EventArgs eventArgs = new EventArgs();
                DoAfterRemoved(this, eventArgs);
            }
        }
    }
}
