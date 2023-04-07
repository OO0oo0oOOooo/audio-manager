using UnityEngine;

public class AudioSystem : MonoBehaviour
{
    [SerializeField] private AudioSource _ambientSource;
    [SerializeField] private AudioSource _effectSource;

    [Header("Audio Clips")]
    public AudioClips _clips;

    public static AudioSystem Instance { get; private set; }
    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
    }

    public void PlayAmbient(AudioClip clip)
    {
        _ambientSource.Play();
        _ambientSource.clip = clip;
    }

    public void PlayClipAtPos(int arrayIndex, Vector3 pos, float vol = 1)
    {
        // Use enum maybe
        int i = Random.Range(0, _clips.clipArrays[arrayIndex].clips.Length);
        AudioClip clip = _clips.clipArrays[arrayIndex].clips[i];

        AudioSource.PlayClipAtPoint(clip, pos, vol);
    }

    public void PlaySound(int arrayIndex, float vol = 1)
    {
        AudioClip clip = _clips.clipArrays[arrayIndex].clips[0];
        _ambientSource.PlayOneShot(clip, vol);
    }
}