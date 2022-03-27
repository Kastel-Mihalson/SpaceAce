using UnityEngine;

[CreateAssetMenu(fileName = "AucioData", menuName = "ScriptableObjects/Audio/AudioData")]
public class AudioData : ScriptableObject
{
    [SerializeField]
    private Sound[] _sound;

    public Sound[] Sounds => _sound;
}
