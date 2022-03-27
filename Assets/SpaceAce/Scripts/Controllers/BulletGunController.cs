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

    public BulletGunController(AudioController audioController)
    {
        _audioController = audioController;
        _gunBaseData = Resources.Load<GunBaseData>("Guns/BulletGunData");
        _bulletBaseData = Resources.Load<BulletBaseData>("Bullets/BulletData");
        _shootController = new ShootController();
    }

    public void Init()
    {
        _gunModel = new BulletGunModel(_gunBaseData);
        _gunGo = Object.Instantiate(_gunModel.Prefab, GunPosition);

        if (_gunGo != null)
        {
            _bulletSpawnPosition = _gunGo.GetComponentInChildren<BulletSpawnMarker>().transform;
            _gunView = _gunGo.GetComponent<BulletGunView>();
        }
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
        _audioController.Play(AudioClipName.BulletGunShot);
        Debug.Log("Пыщ-пыщ!");
    }
}