using UnityEngine;

public class Nodess : MonoBehaviour
{
    public string key;
    public AudioClip value;
    public Nodess next;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }
    public Nodess(string key, AudioClip value)
    {
        this.key = key;
        this.value = value;
        this.next = null;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    
}
