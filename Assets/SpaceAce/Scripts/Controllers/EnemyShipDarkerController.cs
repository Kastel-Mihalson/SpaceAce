using UnityEngine;

public class EnemyShipDarkerController : IShipController
{
    private IShipModel _shipDarkerModel;
    private EnemyShipView _enemyShipView;
    private Vector3 _movement;

    public EnemyShipDarkerController() { }

    public void Init(ShipBaseData shipBaseData)
    {
        _shipDarkerModel = new EnemyShipDarkerModel(shipBaseData);
        _enemyShipView = _shipDarkerModel.ShipGameObject.GetComponent<EnemyShipView>();
    }

    public void FlightControl()
    {
    }

    public void ShootControl()
    {
    }

    public void Flight()
    {
    }

    public void SetGun(IGunController gunController)
    {
    }

    public void UnsetGun()
    {
        throw new System.NotImplementedException();
    }
}