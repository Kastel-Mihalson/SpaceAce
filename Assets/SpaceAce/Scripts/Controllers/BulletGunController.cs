using UnityEngine;

public class BulletGunController : IGunController
{
    public void Overheat()
    {
        throw new System.NotImplementedException();
    }

    public void Reload()
    {
        throw new System.NotImplementedException();
    }

    public void Shoot()
    {
        Debug.Log("Пыщ-пыщ!");
    }
}