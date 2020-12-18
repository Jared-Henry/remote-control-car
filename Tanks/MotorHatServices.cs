using System;
using Iot.Device.DCMotor;
using Iot.Device.MotorHat;
using Iot.Device.ServoMotor;

namespace Tanks
{
    public class MotorHatAxisMotor : IDisposable, ITurretVerticalAxisMotor, ITurretHorizontalAxisMotor
    {
        private bool disposedValue;
        private ServoMotor motor;

        public MotorHatAxisMotor(MotorHat hat, TankTurretAxisSettings settings)
        {
            motor = hat.CreateServoMotor(
                settings.ChannelNumber,
                settings.MaximumAngle,
                settings.MinimumPulseWidthMicroseconds,
                settings.MaximimPulseWidthMicroseconds);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    motor.Dispose();
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        public void WriteAngle(double angle)
        {
            motor.WriteAngle(angle);
        }

        public void WritePulseWidth(int microseconds)
        {
            motor.WritePulseWidth(microseconds);
        }
    }

    public class MotorHatTreadMotor : IDisposable, ILeftTreadMotor, IRightTreadMotor
    {
        private bool disposedValue;
        DCMotor motor;

        public MotorHatTreadMotor(MotorHat hat, TankTreadSettings settings)
        {
            motor = hat.CreateDCMotor(settings.MotorNumber);
        }

        public double Speed { get => motor.Speed; set => motor.Speed = value; }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    motor.Dispose();
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            // Do not change this code. Put cleanup code in 'Dispose(bool disposing)' method
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}