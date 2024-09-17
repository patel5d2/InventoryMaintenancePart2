// Dharmin Patel
using System;
using System.Collections;
using System.Collections.Generic;

public class InvItemList : IEnumerable<InvItem>  // Implementing IEnumerable<InvItem>
{
    private List<InvItem> invItems;

    public delegate void ChangeHandler(InvItemList invItems);
    public event ChangeHandler Changed;

    public InvItemList()
    {
        invItems = new List<InvItem>();
    }

    public int Count => invItems.Count;

    public InvItem this[int i]
    {
        get
        {
            if (i < 0 || i >= invItems.Count)
                throw new ArgumentOutOfRangeException(i.ToString());
            return invItems[i];
        }
        set
        {
            invItems[i] = value;
            Changed?.Invoke(this);
        }
    }

    public void Add(InvItem invItem)
    {
        invItems.Add(invItem);
        Changed?.Invoke(this);
    }

    public void Remove(InvItem invItem)
    {
        invItems.Remove(invItem);
        Changed?.Invoke(this);
    }

    public void Fill() => invItems = InvItemDB.GetItems();

    public void Save() => InvItemDB.SaveItems(invItems);

    // Implement GetEnumerator for IEnumerable<InvItem>
    public IEnumerator<InvItem> GetEnumerator()
    {
        return invItems.GetEnumerator();  // Forwarding to the List's enumerator
    }

    // Explicit implementation of IEnumerable (non-generic)
    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}
