using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] 
    private ShipBaseData _playerShipData;

    [SerializeField]
    private ShipBaseData _enemyShipData;

    [SerializeField]
    private AudioData _audioData;

    private IShipController _playerController;
    private IShipController _enemyController;
    private IGunController _playerGunController;

    private AudioController _audioController;

    void Start()
    {
        _audioController = new AudioController(_audioData);
        _playerController = new PlayerShipEvoController();
        _playerController.Init(_playerShipData);
        _playerController.SetGun(new LaserGunController(_audioController));
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            _playerController.UnsetGun();
            _playerController.SetGun(new BulletGunController(_audioController));
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            _playerController.UnsetGun();
            _playerController.SetGun(new LaserGunController(_audioController));
        }

        _playerController.FlightControl();
        _playerController.ShootControl();
    }

    private void FixedUpdate()
    {
        _playerController.Flight();
    }
}
