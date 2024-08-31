# Silent Sound Generator

[![Silent Sound Generator](https://github.com/Q-Sharp/SilentSoundGenerator/actions/workflows/dotnet.yml/badge.svg)](https://github.com/Q-Sharp/SilentSoundGenerator/actions/workflows/dotnet.yml)

## Overview

The Silent Sound Generator is a utility designed to solve an issue with wireless headsets, specifically Jabra and similar devices, which tend to turn off automatically due to inactivity. This application simulates continuous audio playback in the background, ensuring the headset stays active.

## Purpose

Many wireless headsets, like Jabra devices, power down automatically when there is no audio being played. This behavior can be inconvenient when you need the headset to remain active. The Silent Sound Generator ensures that headsets stay connected and ready by simulating silent audio playback in the background, effectively "tricking" the headset into staying on.

## Features

- **Continuous Silent Audio Playback**: Uses NAudio to play an infinite loop of silence.
- **Minimizes to System Tray**: Runs silently in the background and minimizes to the system tray, showing a small icon for easy access.
- **Embedded Silent Playback**: No external audio files are needed, as the silent audio is generated programmatically.
- **Minimal Resource Usage**: The application is lightweight and designed to have minimal impact on system performance.
- **Autostart Support**: Can be configured to launch automatically when Windows starts.

## Installation

1. **[Install .NET 8 Runtime](https://dotnet.microsoft.com/en-us/download/dotnet/8.0)**: Make sure you have the .NET 8 runtime installed on your machine.

2. **Download the Latest Release**: Visit the [Releases page](https://github.com/Q-Sharp/SilentSoundGenerator/releases) to download the latest version of the executable.

3. **Run the Application**: Execute the `.exe` file. The application will begin simulating silent audio playback and will minimize to the system tray.

4. **(Optional) Add to Autostart**:
   - **Manual Method**: Create a shortcut of the `SilentSoundGenerator.exe` file and place it in the Windows Startup folder. You can access this folder by pressing `Win + R`, typing `shell:startup`, and pressing Enter. Paste the shortcut in the folder.
   - **Automated Method**: Use scripts or third-party utilities to add the application to startup.

## Usage

1. **Launch the Application**: Double-click on the executable file. Once launched, the application will run in the background, visible only via the system tray icon.

2. **Keep Your Headset Active**: The application will continuously play silent audio, ensuring that your wireless headset remains powered on and ready to use.

3. **Stop the Application**: Right-click the tray icon and select "Exit" to stop the silent sound generation and close the application.

## How It Works

The Silent Sound Generator uses the [NAudio](https://github.com/naudio/NAudio) library to generate and play an infinite loop of silence. The application minimizes to the system tray to ensure a non-intrusive user experience. Silent audio is generated in memory and played through the system's audio hardware to keep the headset active.

## Technical Details

- **Platform**: Windows
- **Framework**: .NET 8.0
- **NAudio**: Used for generating and managing silent audio playback.
- **Deployment**: Distributed as a self-contained executable, so no additional dependencies are required on the target machine.

## Troubleshooting

- **Application Does Not Start**: Ensure that the .NET 8 runtime is installed and up to date.
- **Headset Still Turns Off**: Check your device's power management settings or other related features that may be causing the headset to power down.
- **No System Tray Icon**: Verify that the application is running. If the icon is missing, try restarting the application or your system.

## License

This project is licensed under the [MIT License](LICENSE).

## Contact

For questions, issues, or feature requests, please open a ticket via [GitHub Issues](https://github.com/Q-Sharp/SilentSoundGenerator/issues).

---

*Silent Sound Generator* is a community-driven project that helps improve the usability of wireless headsets by preventing unwanted power-downs during inactivity. Contributions and feedback are always welcome!
