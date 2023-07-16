///Author: Kirbyrawr
///License: MIT

using nanoFramework.Hardware.Esp32;

public class LightSleepTouchscreenWakeup
{
    //Light Sleep is a low power mode that allows the CPU to wake up when certain conditions are met.
    public void LightSleep()
    {
        Sleep.StartLightSleep();
    }

    //39 is the pin number for the touchscreen interrupt in M5StackCore2
    //If you are using another device, check the pin number for the touchscreen interrupt in the schematic diagram
    public void EnableWakeupByTouchScreen()
    {
        Sleep.EnableWakeupByMultiPins(Sleep.WakeupGpioPin.Pin39, Sleep.WakeupMode.AllLow);
    }

    public void Demo()
    {
        //We need first to enable the pin to wakeup the device from sleep when touching the screen.
        EnableWakeupByTouchScreen();

        //Enter in light sleep mode
        LightSleep();

        //Logic to do after wakeup from light sleep
    }
}