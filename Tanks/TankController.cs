using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Device.Gpio;
using Iot.Device.Uln2003;
using Iot.Device.MotorHat;
using Iot.Device.DCMotor;
using Iot.Device.ServoMotor;
using Microsoft.Extensions.DependencyInjection;
using Tanks;

namespace Tanks
{
    [ApiController]
    [Route("[controller]")]
    public class TankController : ControllerBase
    {
        private readonly ILogger<TankController> _logger;
        private readonly Tank _tank;

        public TankController(ILogger<TankController> logger, Tank tank)
        {
            _logger = logger;
            _tank = tank;
        }

        [HttpPost]
        public void Stop()
        {
            _tank.Stop();
        }

        [HttpPost]
        public void MoveTreads(double leftTreadSpeed, double rightTreadSpeed)
        {
            _tank.MoveTreads(leftTreadSpeed, rightTreadSpeed);
        }

        [HttpPost]
        public void MoveTurret(double horizontalAngle, double verticalAngle)
        {
            _tank.MoveTurret(horizontalAngle, verticalAngle);
        }
    }
}
