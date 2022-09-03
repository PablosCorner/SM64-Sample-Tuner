# SM64 Sample Tuner
![SM64 Sample Tuner Preview](https://github.com/PablosCorner/SM64-Sample-Tuner/blob/main/sm64sampletuner_preview.png?raw=true)
## About
SM64 Sample Tuner lets you tune custom instruments for Super Mario 64, for use with JSON soundbanks from SM64 decomp, or with N64SoundTool.
## How to use
Open the program .exe, type the bitrate and root key that your sample is using, press the "Calculate" button, and you should see the float key that should be pasted into the "tuning" in the JSON soundbank.
## Building
Open the .sln of the project in Visual Studio 2022 Community Edition, and build the program from there, should hopefully just work.
## Credits
* PablosCorner - Programmed base/core code
* ThisMight - Assisting with porting original Java CLI code to C# and working with a GUI
* Trenavix - The formula for calculating the float key value for instrument tuning
