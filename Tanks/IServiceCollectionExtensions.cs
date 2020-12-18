using Iot.Device.MotorHat;
using Microsoft.Extensions.DependencyInjection;

namespace Tanks
{
    public static class IServiceCollectionExtensions
    {
        public static IServiceCollection AddTank(this IServiceCollection services)
        {
            return services.AddSingleton<Tank>();
        }

        public static IServiceCollection AddMotorHat(this IServiceCollection services, TankSettings settings)
        {
            return services.AddSingleton<MotorHat>()
            .AddMotorHatLeftTread(settings.LeftTread)
            .AddMotorHatRightTread(settings.RightTread)
            .AddMotorHatTurretHorizontalAxis(settings.Turret.HorizontalAxis)
            .AddMotorHatTurretVerticalAxis(settings.Turret.VerticalAxis);
        }

        public static IServiceCollection AddMotorHatLeftTread(this IServiceCollection services, TankTreadSettings settings)
        {
            return services.AddSingleton<ILeftTreadMotor>(provider =>
            {
                var hat = provider.GetRequiredService<MotorHat>();
                return new MotorHatTreadMotor(hat, settings);
            });
        }
        public static IServiceCollection AddMotorHatRightTread(this IServiceCollection services, TankTreadSettings settings)
        {
            return services.AddSingleton<ILeftTreadMotor>(provider =>
            {
                var hat = provider.GetRequiredService<MotorHat>();
                return new MotorHatTreadMotor(hat, settings);
            });
        }

        public static IServiceCollection AddMotorHatTurretVerticalAxis(this IServiceCollection services, TankTurretAxisSettings settings)
        {
            return services.AddSingleton<ITurretVerticalAxisMotor>(provider =>
            {
                var hat = provider.GetRequiredService<MotorHat>();
                return new MotorHatAxisMotor(hat, settings);
            });
        }

        public static IServiceCollection AddMotorHatTurretHorizontalAxis(this IServiceCollection services, TankTurretAxisSettings settings)
        {
            return services.AddSingleton<ITurretHorizontalAxisMotor>(provider =>
            {
                var hat = provider.GetRequiredService<MotorHat>();
                return new MotorHatAxisMotor(hat, settings);
            });
        }
    }
}