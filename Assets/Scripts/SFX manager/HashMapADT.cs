using UnityEngine;

public class HashMapADT 
{
    private Nodess[] buckets;
    private int size;

    public HashMapADT(int size)
    {
        this.size = size;
        buckets = new Nodess[size];
    }

    private int Hash(string key)
    {
        int hash = 0;

        foreach (char c in key)
        {
            hash += c;
        }

        return hash % size;
    }

    public void Insert(string key, AudioClip value)
    {
        int index = Hash(key);
        Debug.Log("INSERTING: " + key + " at bucket " + index);
        Nodess newNode = new Nodess(key, value);

        if (buckets[index] == null)
        {
            buckets[index] = newNode;
            return;
        }

        Nodess current = buckets[index];

        while (current != null)
        {
            if (current.key == key)
            {
                current.value = value;
                return;
            }

            if (current.next == null)
            {
                break;
            }

            current = current.next;
        }

        current.next = newNode;
    }

    public AudioClip Get(string key)
    {
        int index = Hash(key);
        Debug.Log("INSERTING: " + key + " at bucket " + index);

        Nodess current = buckets[index];

        while (current != null)
        {
            if (current.key == key)
            {
                return current.value;
            }

            current = current.next;
        }
        Debug.Log("NOT FOUND: " + key);


        return null;
    }

    public bool ContainsKey(string key)
    {
        return Get(key) != null;
    }

    public void Remove(string key)
    {
        int index = Hash(key);

        Nodess current = buckets[index];
        Nodess previous = null;

        while (current != null)
        {
            if (current.key == key)
            {
                if (previous == null)
                {
                    buckets[index] = current.next;
                }
                else
                {
                    previous.next = current.next;
                }

                return;
            }

            previous = current;
            current = current.next;
        }
    }
}
