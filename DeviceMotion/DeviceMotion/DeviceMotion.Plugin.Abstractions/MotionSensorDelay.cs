using System;

namespace DeviceMotion.Plugin.Abstractions
{
	/// <summary>
	/// Motion sensor delay enum.
	/// </summary>
	public enum MotionSensorDelay
	{
		/// <summary>
		/// Fastest Delay
		/// </summary>
		Fastest = 0,
		/// <summary>
		/// Game Delay
		/// </summary>
		Game = 20,
		/// <summary>
		/// Ui Delay
		/// </summary>
		Ui = 60,
		/// <summary>
		/// Default Delay
		/// </summary>
		Default = 200,

		/// <summary>
		/// Medium Delay (500ms)
		/// </summary>
		Medium = 500,

		/// <summary>
		/// Slowest Delay (1000ms)
		/// </summary>
		Slowest = 1000
	}
}
