using UnityEngine;

[CreateAssetMenu(fileName = "GunBaseData", menuName = "ScriptableObjects/Guns/GunBaseData")]
public class GunBaseData : ScriptableObject
{
    [SerializeField] private GameObject _prefab;
    [SerializeField] private float _rateOfFire;
    [SerializeField] private float _totalAmmo;
    [SerializeField] private float _clipCapacity;
    [SerializeField] private float _reloadSpeed;
    [SerializeField] private float _coolingTime;

    public GameObject Prefab
    {
        get => _prefab;
        set => _prefab = value;
    }

    public float RateOfFire
    {
        get => _rateOfFire;
        set => _rateOfFire = value;
    }

    public float TotalAmmo
    {
        get => _totalAmmo;
        set => _totalAmmo = value;
    }

    public float ClipCapacity
    {
        get => _clipCapacity;
        set => _clipCapacity = value;
    }

    public float ReloadSpeed
    {
        get => _reloadSpeed;
        set => _reloadSpeed = value;
    }

    public float CoolingTime
    {
        get => _coolingTime;
        set => _coolingTime = value;
    }
}