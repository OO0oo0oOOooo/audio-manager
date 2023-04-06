using UnityEngine;

public class AudioSystem : MonoBehaviour
{
    [SerializeField] private AudioSource _musicSource;
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

    public void PlayMusic(AudioClip clip)
    {
        _musicSource.Play();
        _musicSource.clip = clip;
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

        _effectSource.PlayOneShot(clip, vol);
    }

    public void PlaySoundOnParent(int arrayIndex, Transform parent, float vol = 1)
    {
        // TODO AUDIO: Audio follows target

        AudioClip clip = _clips.clipArrays[arrayIndex].clips[0];

        if(_effectSource.isPlaying)
            return;

        _effectSource.PlayOneShot(clip);
        
        // AudioSource.PlayClipAtPoint(clip, parent.position, vol);
    }
}