class RemoteControlCar
{
    private int _speed;
    private int _batteryDrain;
    private int _metersDriven;
    private int _battery;
    
    public RemoteControlCar(int speed, int batteryDrain){
        _speed = speed;
        _batteryDrain = batteryDrain;
        _battery = 100;
    }

    public bool BatteryDrained() => _battery < _batteryDrain;

    public int DistanceDriven() => _metersDriven;

    public void Drive()
    {
        if(_battery > 0 && !BatteryDrained()){
            _metersDriven += _speed;
            _battery -= _batteryDrain;
        }
    }

    public static RemoteControlCar Nitro() => new RemoteControlCar(50, 4);
}

class RaceTrack
{
    private int _distanceTrack;
    
    public RaceTrack(int distance){
        _distanceTrack = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while(_distanceTrack > car.DistanceDriven() ){
            if(car.BatteryDrained())
                return false;
            car.Drive();
        }
        
        return true;
    }
}
