using UnityEngine;

public class PlayerShipEvoController : IShipController
{
    private IShipModel _shipEvoModel;
    private IGunController _shipGun;
    private PlayerShipView _shipView;
    private Vector3 _movement;
    private KeyCode _shootKeyCode = KeyCode.Space;
    private AudioController _audioController;

    private float _left;
    private float _right;
    private float _top;
    private float _bottom;

    public IGunController ShipGun
    {
        get => _shipGun;
        set => _shipGun = value;
    }

    public PlayerShipEvoController()
    {
    }

    public void Init(ShipBaseData shipBaseData)
    {
        _shipEvoModel = new PlayerShipEvoModel(shipBaseData);
        _shipView = _shipEvoModel.ShipGameObject.GetComponent<PlayerShipView>();

        SetLimitFlightAreaByColliderSize();
    }

    public void SetGun(IGunController gunController)
    {
        ShipGun = gunController;
        ShipGun.GunPosition = _shipEvoModel.GunPosition;
        ShipGun.Init();
    }

    public void UnsetGun()
    {
        Object.Destroy(ShipGun.GunGameObject);
    }

    public void FlightControl()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        _movement = new Vector3(h, 0, v);

        LimitFlightArea();
    }

    public void ShootControl()
    {
        if (Input.GetKeyDown(_shootKeyCode))
        {
            ShipGun.Shoot();
        }
    }

    public void Flight()
    {
        _shipEvoModel.ShipRigidBody.velocity = _movement * _shipEvoModel.Speed;
        _shipEvoModel.ShipRigidBody.rotation = Quaternion.Euler(0, 0, -_shipEvoModel.ShipRigidBody.velocity.x * _shipEvoModel.Turn);
    }

    private void LimitFlightArea()
    {
        float x = Mathf.Clamp(_shipEvoModel.ShipTransform.position.x, _left, _right);
        float z = Mathf.Clamp(_shipEvoModel.ShipTransform.position.z, _top, _bottom);

        _shipEvoModel.ShipTransform.position = new Vector3(x, 0, z);
    }

    private void SetLimitFlightAreaByColliderSize()
    {
        float zOffset = _shipEvoModel.ShipCollider.height / 2;
        float xOffset = _shipEvoModel.ShipCollider.radius;

        _left = ScreenBorder.Left + xOffset;
        _right = ScreenBorder.Right - xOffset;
        _top = ScreenBorder.Top + zOffset;
        _bottom = ScreenBorder.Bottom - zOffset;
    }
}
