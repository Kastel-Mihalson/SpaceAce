public interface IShipController
{
    void Init(ShipBaseData shipBaseData);
    void FlightControl();
    void ShootControl();
    void Flight();
    void SetGun(IGunController gunController);
    void UnsetGun();
}