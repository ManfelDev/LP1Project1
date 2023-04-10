using System;

/// <summary>
/// Enum that represents the state of the lamps
/// </summary>
[Flags]
enum LampState
{
    Off = 0,
    Lamp1On = 1 << 0,
    Lamp2On = 1 << 1,
    Lamp3On = 1 << 2,
}