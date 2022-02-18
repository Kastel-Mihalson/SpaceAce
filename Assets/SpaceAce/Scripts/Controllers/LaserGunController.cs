using UnityEngine;

public class LaserGunController : IGunController
{
    private LaserGunModel _gunModel;
    private LaserGunView _gunView;
    private ShootController _shootController;
    private GunBaseData _gunBaseData;
    private BulletBaseData _bulletBaseData;
    private Transform _bulletSpawnPosition;
    private Transform _gunPosition;

    public Transform GunPosition
    {
        get => _gunPosition;
        set => _gunPosition = value;
    }

    public LaserGunController()
    {
        _gunBaseData = Resources.Load<GunBaseData>("Guns/LaserGunData");
        _bulletBaseData = Resources.Load<BulletBaseData>("Bullets/LaserData");
        _shootController = new ShootController();
    }

    public void Init()
    {
        _gunModel = new LaserGunModel(_gunBaseData);

        GameObject gunGO = Object.Instantiate(_gunModel.Prefab, GunPosition);

        _bulletSpawnPosition = gunGO.GetComponentInChildren<BulletSpawnMarker>().transform;
        _gunView = gunGO.GetComponent<LaserGunView>();
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
        Debug.Log("Пиу-пиу!");
    }
}