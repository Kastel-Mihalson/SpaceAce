using UnityEngine;

public class ShootController
{
    private BulletModel _bulletModel;
    private BulletView _bulletView;
    private Rigidbody _rigidbody;
    private Transform _bulletSpawnPosition;

    public void Init(BulletBaseData bulletBaseData, Transform bulletSpawnPosition)
    {
        _bulletSpawnPosition = bulletSpawnPosition;
        _bulletModel = new BulletModel(bulletBaseData);
        
        GameObject bulletGO = Object.Instantiate(_bulletModel.Prefab, _bulletSpawnPosition.position, Quaternion.identity);

        _bulletView = bulletGO.GetComponent<BulletView>();
        _rigidbody = _bulletView.GetComponent<Rigidbody>();
    }

    public void Fire()
    {
        _rigidbody.velocity = _bulletSpawnPosition.forward * _bulletModel.Speed;
    }
}
