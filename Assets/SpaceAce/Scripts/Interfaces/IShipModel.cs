using UnityEngine;

public interface IShipModel
{
    GameObject Prefab { get; set; }

    GameObject ShipGameObject { get; }

    Rigidbody ShipRigidBody { get; }

    Transform ShipTransform { get; }

    CapsuleCollider ShipCollider { get; }

    Vector3 GunPosition { get; }

    Vector3 Spawn { get; set; }

    float Health { get; set; }

    float Damage { get; set; }

    float Speed { get; set; }

    float Turn { get; set; }
}
