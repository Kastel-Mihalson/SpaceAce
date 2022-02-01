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

    public void Control()
    {
    }

    public void Flight()
    {
    }

    public void Gun()
    {
    }
}