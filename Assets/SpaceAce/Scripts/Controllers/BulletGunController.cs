using UnityEngine;

public class BulletGunController : IGunController
{
    private BulletGunModel _gunModel;
    private BulletGunView _gunView;
    private ShootController _shootController;
    private GunBaseData _gunBaseData;
    private BulletBaseData _bulletBaseData;
    private Transform _gunPosition;
    private Transform _bulletSpawnPosition;

    public Transform GunPosition
    {
        get => _gunPosition;
        set => _gunPosition = value;
    }

    public BulletGunController()
    {
        _gunBaseData = Resources.Load<GunBaseData>("Guns/BulletGunData");
        _bulletBaseData = Resources.Load<BulletBaseData>("Bullets/BulletData");
        _shootController = new ShootController();
    }

    public void Init()
    {
        _gunModel = new BulletGunModel(_gunBaseData);

        GameObject gunGO = Object.Instantiate(_gunModel.Prefab, GunPosition);

        _bulletSpawnPosition = gunGO.GetComponentInChildren<BulletSpawnMarker>().transform;
        _gunView = gunGO.GetComponent<BulletGunView>();
    }

    public void Overheat()
    {
        throw new System.NotImplementedException();
    }

    public void Reload()
    {
        throw new System.NotImplementedException();
    }

    public void Shoot()
    {
        _shootController.Init(_bulletBaseData, _bulletSpawnPosition);
        _shootController.Fire();
        Debug.Log("Пыщ-пыщ!");
    }
}