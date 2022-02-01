using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private ShipBaseData _playerShipData;
    [SerializeField] private ShipBaseData _enemyShipData;

    private IShipController _playerController;
    private IShipController _enemyController;

    void Start()
    {
        _playerController = new PlayerShipEvoController();
        _playerController.Init(_playerShipData);
    }

    void Update()
    {
        _playerController.Control();
    }

    private void FixedUpdate()
    {
        _playerController.Flight();
    }
}
