using UnityEngine;

[CreateAssetMenu(fileName = "BulletData", menuName = "ScriptableObjects/BulletSO")]
public class BulletSO : ScriptableObject
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private Vector3 _spawn;
    [SerializeField] private float _speed;

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
}
