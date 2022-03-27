using UnityEngine;

[CreateAssetMenu(fileName = "BulletBaseData", menuName = "ScriptableObjects/Bullets/BulletBaseData")]
public class BulletBaseData : ScriptableObject
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private float _speed;
    [SerializeField] private float _damage;
    [SerializeField] private float _lifeTime;

    public GameObject Prefab
    {
        get => _prefab;
        set => _prefab = value;
    }

    public float Speed
    {
        get => _speed;
        set => _speed = value;
    }

    public float Damage
    {
        get => _damage;
        set => _damage = value;
    }

    public float LifeTime
    {
        get => _lifeTime;
        set => _lifeTime = value;
    }
}
