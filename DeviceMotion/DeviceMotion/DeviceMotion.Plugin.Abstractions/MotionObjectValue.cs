using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeviceMotion.Plugin.Abstractions
{
    public class MotionObjectValue
    {
        public double[] RotationRate { get; set; }
        public double[] AttitudeQuarternion { get; set; }
        public double[] AttitudeYawPitchRoll { get; set; }
    }
}
