namespace Tanks
{
    public class TankSettings
    {
        public TankTreadSettings LeftTread;
        public TankTreadSettings RightTread;
        public TankTurretSettings Turret;
    }

    public class TankTreadSettings
    {
        public int MotorNumber;
    }

    public class TankTurretSettings
    {
        public TankTurretAxisSettings HorizontalAxis;
        public TankTurretAxisSettings VerticalAxis;
    }

    public class TankTurretAxisSettings
    {
        public int ChannelNumber;
        public double MaximumAngle;
        public double MinimumPulseWidthMicroseconds;
        public double MaximimPulseWidthMicroseconds;
    }

}