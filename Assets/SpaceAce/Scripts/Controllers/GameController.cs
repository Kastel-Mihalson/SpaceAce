using UnityEngine;

public class GameController : MonoBehaviour
{
    [SerializeField] private PlayerSO _playerData;

    private PlayerController _playerController;

    void Start()
    {
        _playerController = new PlayerController(_playerData);
        _playerController.Init();
    }

    void Update()
    {
        _playerController.UpdateExecute();
    }

    private void FixedUpdate()
    {
        _playerController.FixedUpdateExecute();
    }
}
