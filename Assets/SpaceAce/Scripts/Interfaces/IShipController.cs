public interface IShipController
{
    void Init(ShipBaseData shipBaseData);
    void FlightControl();
    void ShootControl();
    void Flight();
    void InitGun(IGunController gunController);
}