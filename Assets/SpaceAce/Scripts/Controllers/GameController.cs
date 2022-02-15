using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private ShipBaseData _playerShipData;
    [SerializeField] private ShipBaseData _enemyShipData;

    private IShipController _playerController;
    private IShipController _enemyController;
    private IGunController _playerGunController;

    void Start()
    {
        _playerController = new PlayerShipEvoController();
        _playerController.Init(_playerShipData);
        _playerController.InitGun(new LaserGunController());
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.G))
        {
            _playerController.InitGun(new BulletGunController());
        }
        if (Input.GetKeyDown(KeyCode.H))
        {
            _playerController.InitGun(new LaserGunController());
        }

        _playerController.FlightControl();
        _playerController.ShootControl();
    }

    private void FixedUpdate()
    {
        _playerController.Flight();
    }
}
