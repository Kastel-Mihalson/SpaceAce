using UnityEngine;

public class CutScenes
{
    private Transform _playerTransform;
    private Rigidbody _playerRigidBody;

    private Vector3 _playerFlightDirection;

    private float _playerFlightSpeed;

    public CutScenes(Rigidbody rigidbody)
    {
        _playerRigidBody = rigidbody;
        _playerTransform = rigidbody.transform;

        _playerFlightDirection = Vector3.forward;

        _playerFlightSpeed = 4f;
    }

    public void ShipFlightToStartPosition()
    {
        if (_playerTransform.position.z == -3.5f)
        {
            _playerFlightDirection = Vector3.back;
            _playerFlightSpeed = 1.5f;
        }
        _playerRigidBody.velocity = _playerFlightDirection * _playerFlightSpeed;
    }
}
