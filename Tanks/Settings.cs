namespace Tanks
{
    public class TankSettings
    {
        public TankTreadSettings LeftTread { get; set; } = new TankTreadSettings();
        public TankTreadSettings RightTread { get; set; } = new TankTreadSettings();
        public TankTurretSettings Turret { get; set; } = new TankTurretSettings();
    }

    public class TankTreadSettings
    {
        public int MotorNumber;
    }

    public class TankTurretSettings
    {
        public TankTurretAxisSettings HorizontalAxis { get; set; } = new TankTurretAxisSettings();
        public TankTurretAxisSettings VerticalAxis { get; set; } = new TankTurretAxisSettings();
    }

    public class TankTurretAxisSettings
    {
        public int ChannelNumber;
        public double MaximumAngle;
        public double MinimumPulseWidthMicroseconds;
        public double MaximimPulseWidthMicroseconds;
    }

}