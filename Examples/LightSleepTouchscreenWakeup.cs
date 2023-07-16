///Author: Kirbyrawr
///License: MIT

using nanoFramework.Hardware.Esp32;

public class LightSleepTouchscreenWakeup
{
    public void Demo()
    {
        ///39 is the pin number for the touchscreen interrupt in M5StackCore2
        //If you are using another device, check the pin number for the touchscreen interrupt in the schematic diagram
        Sleep.EnableWakeupByMultiPins(Sleep.WakeupGpioPin.Pin39, Sleep.WakeupMode.AllLow);

        //Enter light sleep mode.
        //Light Sleep is a low power mode that allows the CPU to wake up when certain conditions are met.
        Sleep.StartLightSleep();

        //Logic to do after wakeup from light sleep
    }
}