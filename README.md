# Silent Sound Generator

## Overview

The Silent Sound Generator is a small utility designed to address issues with wireless headsets, specifically Jabra devices, which tend to automatically turn off due to inactivity. This application helps prevent such devices from powering down by simulating continuous audio playback, ensuring they remain active and ready for use.

## Purpose

Many wireless headsets, especially Jabra models, have a feature that turns them off automatically when they detect inactivity or when no audio is being played. This can be problematic if you need to keep the headset active for extended periods, as it might not turn back on promptly when needed. The Silent Sound Generator solves this problem by continuously simulating audio playback, keeping the headset active and ready.

## Features

- **Simulated Continuous Audio Playback**: Plays a silent audio file in an endless loop.
- **Resource Embedded**: The silent audio file is embedded within the executable, so no external files are required.
- **Simple Operation**: Runs as a background process, ensuring minimal impact on system performance.
- **Autostart Support**: Can be configured to start automatically with Windows.

## Installation

1. **Download the Latest Release**: Go to the [Releases page](https://github.com/Q-Sharp/SilentSoundGenerator/releases) and download the latest version of the executable.

2. **Run the Application**: Simply run the downloaded `.exe` file. It will start simulating silent audio playback and will continue to do so until it is closed.

3. **(Optional) Add to Autostart**: To ensure the application starts automatically with Windows:
    - **Manual Method**: Create a shortcut of the `SilentSoundGenerator.exe` file and place it in the Windows Startup folder. You can access this folder by pressing `Win + R`, typing `shell:startup`, and pressing Enter. Paste the shortcut in the opened folder.
    - **Automated Method**: You can use third-party tools or scripts to add the application to the startup automatically. 

## Usage

1. **Launch the Application**: Double-click on the executable file to start the Silent Sound Generator.

2. **Keep Your Headset Active**: The application will continuously play silent audio, preventing your wireless headset from automatically turning off.

3. **Stop the Application**: To stop the simulation, close the application window or use the task manager to terminate the process.

## How It Works

The Silent Sound Generator uses a small, silent `.wav` file that is embedded in the application. It leverages the `System.Media.SoundPlayer` class to play this file in a loop. The application runs indefinitely, simulating audio playback to keep the headset active.

## Technical Details

- **Platform**: Windows
- **Framework**: .NET 8.0
- **Embedded Resource**: Silent audio file is embedded within the executable.
- **Deployment**: Built as a self-contained executable, no .NET runtime required on target machines.

## Troubleshooting

- **No Sound or Application Not Working**: Ensure that the application is running and check the task manager to verify that it is active.
- **Headset Still Turns Off**: Ensure that the headset is not affected by other power-saving features or settings outside of audio playback.

## License

This project is licensed under the [MIT License](LICENSE).

## Contact

If you have any questions or feedback, please feel free to reach out via [GitHub Issues](https://github.com/Q-Sharp/SilentSoundGenerator/issues).

---

*Silent Sound Generator* is a community-driven project aimed at improving the usability of wireless headsets. Contributions and feedback are always welcome!
