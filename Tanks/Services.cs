using Iot.Device.DCMotor;
using Iot.Device.ServoMotor;

namespace Tanks
{
    public interface IAxisMotor
    {
        void WriteAngle(double angle);
        void WritePulseWidth(int microseconds);
    }

    public interface ITurretHorizontalAxisMotor : IAxisMotor
    {
    }

    public interface ITurretVerticalAxisMotor : IAxisMotor
    {
    }

    public interface ITreadMotor
    {
        double Speed { get; set; }
    }

    public interface ILeftTreadMotor : ITreadMotor
    {
    }

    public interface IRightTreadMotor : ITreadMotor
    {
    }
}