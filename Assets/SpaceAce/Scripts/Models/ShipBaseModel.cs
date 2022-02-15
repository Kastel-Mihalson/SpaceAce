using UnityEngine;

public abstract class ShipBaseModel
{
    private GameObject _shipGameObject;
    private Rigidbody _rigidbody;
    private Transform _transform;
    private CapsuleCollider _collider;
    private Transform _gunPosition;

    private GameObject _prefab;
    private Vector3 _spawn;

    private float _health;
    private float _damage;
    private float _speed;
    private float _turn;

    public GameObject ShipGameObject => _shipGameObject;

    public Rigidbody ShipRigidBody => _rigidbody;

    public Transform ShipTransform => _transform;

    public CapsuleCollider ShipCollider => _collider;

    public Transform GunPosition => _gunPosition;

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

    public float Health
    {
        get => _health;
        set => _health = value;
    }

    public float Damage
    {
        get => _damage;
        set => _damage = value;
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

    public ShipBaseModel(ShipBaseData shipBaseData)
    {
        Prefab = shipBaseData.Prefab;
        Spawn = shipBaseData.Spawn;
        Health = shipBaseData.Health;
        Damage = shipBaseData.Damage;
        Speed = shipBaseData.Speed;
        Turn = shipBaseData.Turn;

        Init();
    }

    private void Init()
    {
        _shipGameObject = Object.Instantiate(Prefab, Spawn, Quaternion.identity);
        _rigidbody = _shipGameObject.GetComponent<Rigidbody>();
        _collider = _shipGameObject.GetComponent<CapsuleCollider>();
        _transform = _rigidbody.transform;
        _gunPosition = _rigidbody.gameObject.GetComponentInChildren<ShipGunMarker>().transform;
    }
}
