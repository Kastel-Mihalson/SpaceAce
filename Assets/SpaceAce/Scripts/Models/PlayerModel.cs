using UnityEngine;

public class PlayerModel
{
    private GameObject _prefab;
    private Vector3 _spawn;

    private float _speed;
    private float _turn;

    public GameObject Prefab
    {
        get => _prefab;
        set => _prefab = value;
    }

    public Vector3 Spawn
    {
        get => _spawn;
        set => _spawn = value;
    }

    public float Speed
    {
        get => _speed;
        set => _speed = value;
    }

    public float Turn
    {
        get => _turn;
        set => _turn = value;
    }

    public PlayerModel(PlayerSO playerData)
    {
        Prefab = playerData.Prefab;
        Spawn = playerData.Spawn;
        Speed = playerData.Speed;
        Turn = playerData.Turn;
    }
}
