using UnityEngine;

public class LaserGunController : IGunController
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
        Debug.Log("Пиу-пиу!");
    }
}