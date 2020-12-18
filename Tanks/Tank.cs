using System;
using Iot.Device.DCMotor;
using Iot.Device.ServoMotor;

namespace Tanks
{
    public class Tank
    {
        ILeftTreadMotor leftTread;
        IRightTreadMotor rightTread;
        ITurretHorizontalAxisMotor turretHorizontalAxis;
        ITurretVerticalAxisMotor turretVerticalAxis;
        public const double MaxTreadSpeed = 1;

        public Tank(
            ILeftTreadMotor leftTread,
            IRightTreadMotor rightTread,
            ITurretHorizontalAxisMotor turretHorizontalAxis,
            ITurretVerticalAxisMotor turretVerticalAxis)
        {
            this.leftTread = leftTread ?? throw new ArgumentNullException(nameof(leftTread));
            this.rightTread = rightTread ?? throw new ArgumentNullException(nameof(rightTread));
            this.turretHorizontalAxis = turretHorizontalAxis ?? throw new ArgumentNullException(nameof(turretHorizontalAxis));
            this.turretVerticalAxis = turretVerticalAxis ?? throw new ArgumentNullException(nameof(turretVerticalAxis));
        }

        public void Stop()
        {
            leftTread.Speed = 0;
            rightTread.Speed = 0;
        }

        public void MoveTreads(double leftTreadSpeed, double rightTreadSpeed)
        {
            leftTread.Speed = leftTreadSpeed;
            rightTread.Speed = rightTreadSpeed;
        }

        public void MoveTurret(double horizontalAngle, double verticalAngle)
        {
            turretHorizontalAxis.WriteAngle(horizontalAngle);
            turretVerticalAxis.WriteAngle(verticalAngle);
        }
    }
}