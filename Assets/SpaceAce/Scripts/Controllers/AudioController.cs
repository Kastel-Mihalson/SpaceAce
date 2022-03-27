using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class AudioController
{
    private const string SOUND_GO_NAME = "Sounds";

    private AudioData _audioData;
    private List<AudioSource> _audioSources;
    private GameObject _soundRootGo;
    private float _volume;

    public AudioController(AudioData audioData)
    {
        _audioData = audioData;
        _soundRootGo = new GameObject($"[{SOUND_GO_NAME}]");
        _audioSources = new List<AudioSource>();
    }

    public void Play(AudioClipName name, bool isLoop = false)
    {
        var clip = _audioData.Sounds.Where(i => i.clipName == name).Select(i => i.clip).FirstOrDefault();

        if (clip == null)
        {
            Debug.Log($"Clip with name: {name} is not found in {nameof(AudioData)}");
            return;
        }

        PlaySound(clip, name, isLoop);
    }

    private void PlaySound(AudioClip clip, AudioClipName name, bool isLoop)
    {
        var clipGo = new GameObject(name.ToString());
        clipGo.transform.SetParent(_soundRootGo.transform);

        var audioSource = clipGo.AddComponent<AudioSource>();
        _audioSources.Add(audioSource);

        audioSource.clip = clip;
        audioSource.loop = isLoop;
        audioSource.Play();

        if (!isLoop)
        {
            Object.Destroy(audioSource.gameObject, clip.length);
            _audioSources.Remove(audioSource);
        }
    }

    public void ClearAudioSources()
    {
        foreach (var source in _audioSources)
        {
            if (source != null)
            {
                Object.Destroy(source.gameObject);
            }
        }
    }
}
