using System;

namespace DeviceMotion.Plugin.Abstractions
{
	/// <summary>
	/// Motion vector.
	/// </summary>
	public class  MotionObject: MotionValue
	{
	    /// <summary>
	    /// Gets or sets the object.
	    /// </summary>
	    /// <value>The object.</value>
	    public object ValueObject { get; set; }

	    /// <summary>
        /// Vector to string
        /// </summary>
        /// <returns></returns>
        public override string ToString()
	    {
	        return ValueObject.ToString();
	    }

		/// <summary>
		/// Gets total value.
		/// </summary>
		/// <value>The value.</value>
		public override double? Value {
			get{
				return 0;
			}
		}

	}
}

