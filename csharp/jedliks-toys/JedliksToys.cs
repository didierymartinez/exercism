class RemoteControlCar
{
    private int _metersDriving = 0;
    private int _battery = 100;
        
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {_metersDriving} meters";

    public string BatteryDisplay() => (_battery != 0) ? $"Battery at {_battery}%" : "Battery empty";

    public void Drive()
    {
        if(_battery > 0 ){
            _metersDriving += 20;
            _battery -= 1;
        }
    }
}
