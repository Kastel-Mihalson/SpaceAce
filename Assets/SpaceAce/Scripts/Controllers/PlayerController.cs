using UnityEngine;

public class PlayerController
{
    private PlayerModel _playerModel;
    private PlayerView _playerView;
    private Rigidbody _rigidbody;
    private Transform _transform;
    private CapsuleCollider _playerCollider;

    private GameObject _playerGO;

    private Vector3 _movement;

    private float left;
    private float right;
    private float top;
    private float bottom;

    public PlayerController(PlayerSO playerData)
    {
        _playerModel = new PlayerModel(playerData);
    }

    public void Init()
    {
        _playerGO = Object.Instantiate(_playerModel.Prefab, 
            _playerModel.Spawn, Quaternion.identity);

        _playerView = _playerGO.GetComponent<PlayerView>();
        _rigidbody = _playerView.GetComponent<Rigidbody>();
        _playerCollider = _playerView.gameObject.GetComponent<CapsuleCollider>();

        _transform = _rigidbody.transform;

        SetLimitFlightAreaByColliderSize();
    }

    private void PlayerInputGetAxisDirection()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        _movement = new Vector3(h, 0, v);
    }

    private void LimitFlightArea()
    {
        float x = Mathf.Clamp(_transform.position.x, left, right);
        float z = Mathf.Clamp(_transform.position.z, top, bottom);

        _transform.position = new Vector3(x, 0, z);
    }

    private void SetLimitFlightAreaByColliderSize()
    {
        float zOffset = _playerCollider.height / 2;
        float xOffset = _playerCollider.radius;

        left = ScreenBorder.Left + xOffset;
        right = ScreenBorder.Right - xOffset;
        top = ScreenBorder.Top + zOffset;
        bottom = ScreenBorder.Bottom - zOffset;
    }

    private void Move()
    {
        _rigidbody.velocity = _movement * _playerModel.Speed;
        _rigidbody.rotation = Quaternion.Euler(0, 0, -_rigidbody.velocity.x * _playerModel.Turn);
    }

    public void UpdateExecute()
    {
        PlayerInputGetAxisDirection();
        LimitFlightArea();
    }

    public void FixedUpdateExecute()
    {
        Move();
    }
}
