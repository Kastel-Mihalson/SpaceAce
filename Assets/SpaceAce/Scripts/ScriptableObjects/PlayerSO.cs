using UnityEngine;

[CreateAssetMenu(fileName = "PlayerData", menuName = "ScriptableObjects/PlayerSO")]
public class PlayerSO : ScriptableObject
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Vector3 _spawn;
    [SerializeField] private float _speed;
    [SerializeField] private float _turn;

    public GameObject Prefab
    {
        get => _prefab;
        set => _prefab = value;
    }

    public Vector3 Spawn
    {
        get => _spawn;
        set => _spawn = value;
    }

    public float Speed
    {
        get => _speed;
        set => _speed = value;
    }

    public float Turn
    {
        get => _turn;
        set => _turn = value;
    }
}
