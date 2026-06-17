using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public static SFXManager Instance;

    [Header("Audio Clips")]
    public AudioClip jumpClip;
    public AudioClip runningClip;
    public AudioClip pickupClip;
    public AudioClip breathingClip;

    private AudioSource audioSource;
    private HashMapADT soundMap;

    private void Awake()
    {
        Debug.Log("SFXManager Awake");

        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

    }

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();

        soundMap = new HashMapADT(10);

        soundMap.Insert("jump", jumpClip);
        soundMap.Insert("running", runningClip);
        soundMap.Insert("pickup", pickupClip);
        soundMap.Insert("breathing", breathingClip);

        Debug.Log(soundMap.Get("jump"));
        Debug.Log(soundMap.Get("running"));
        Debug.Log(soundMap.Get("pickup"));
        Debug.Log(soundMap.Get("breathing"));
    }

    public void PlaySound(string soundName)
    {
        Debug.Log("Trying to play: " + soundName);

        AudioClip clip = soundMap.Get(soundName);

        if (clip != null)
        {
            Debug.Log("Found clip: " + soundName);
            audioSource.PlayOneShot(clip);
        }
        else
        {
            Debug.LogError("Clip not found: " + soundName);
        }
    }
}
