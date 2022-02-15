using UnityEngine;

public interface IGunModel
{
    GameObject Prefab { get; set; }

    float RateOfFire { get; set; }

    float TotalAmmo { get; set; }

    float ClipCapacity { get; set; }

    float ReloadSpeed { get; set; }

    float CoolingTime { get; set; }
}