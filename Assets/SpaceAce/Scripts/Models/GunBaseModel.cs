using UnityEngine;

public abstract class GunBaseModel : IGunModel
{
    public GameObject Prefab { get; set; }

    public float RateOfFire { get; set; }

    public float TotalAmmo { get; set; }

    public float ClipCapacity { get; set; }

    public float ReloadSpeed { get; set; }

    public float CoolingTime { get; set; }


    public GunBaseModel(GunBaseData gunBaseData)
    {
        Prefab = gunBaseData.Prefab;
        RateOfFire = gunBaseData.RateOfFire;
        TotalAmmo = gunBaseData.TotalAmmo;
        ClipCapacity = gunBaseData.ClipCapacity;
        ReloadSpeed = gunBaseData.ReloadSpeed;
        CoolingTime = gunBaseData.CoolingTime;
    }
}