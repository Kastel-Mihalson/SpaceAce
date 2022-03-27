using UnityEngine;

public interface IGunController
{
    Transform GunPosition { get; set; }
    GameObject GunGameObject { get; set; }

    void Init();
    void Shoot();
    void Reload();
    void Overheat();
}