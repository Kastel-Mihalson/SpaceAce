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
    private GameObject _gunGo;
    private AudioController _audioController;

    public Transform GunPosition
    {
        get => _gunPosition;
        set => _gunPosition = value;
    }
    public GameObject GunGameObject
    {
        get => _gunGo;
        set => _gunGo = value;
    }

    public LaserGunController(AudioController audioController)
    {
        _audioController = audioController;
        _gunBaseData = Resources.Load<GunBaseData>("Guns/LaserGunData");
        _bulletBaseData = Resources.Load<BulletBaseData>("Bullets/LaserData");
        _shootController = new ShootController();
    }

    public void Init()
    {
        _gunModel = new LaserGunModel(_gunBaseData);
        _gunGo = Object.Instantiate(_gunModel.Prefab, GunPosition);

        _bulletSpawnPosition = _gunGo.GetComponentInChildren<BulletSpawnMarker>().transform;
        _gunView = _gunGo.GetComponent<LaserGunView>();
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
        _audioController.Play(AudioClipName.LaserGunShot);
        Debug.Log("Пиу-пиу!");
    }
}