using UnityEngine;

public class BulletModel
{
    public GameObject Prefab { get; set; }

    public float Speed { get; set; }

    public float Damage { get; set; }

    public float LifeTime { get; set; }

    public BulletModel(BulletBaseData bulletBaseData)
    {
        Prefab = bulletBaseData.Prefab;
        Speed = bulletBaseData.Speed;
        Damage = bulletBaseData.Damage;
        LifeTime = bulletBaseData.LifeTime;
    }
}
