# HelloHylandPoint Mod

A simple mod for Schedule I that logs messages to the MelonLoader console.

## Features

- Displays a welcome message when the game starts
- Logs scene changes during gameplay
- Configurable welcome message

## Installation

1. Make sure you have [MelonLoader](https://github.com/LavaGang/MelonLoader) installed for Schedule I
2. Download the latest `HelloHylandPoint.dll` from the releases
3. Place the `HelloHylandPoint.dll` file in your `<Schedule I>/Mods/` folder
4. (Optional) Create a `HelloHylandPoint.json` file in your `<Schedule I>/Mods/` folder to customize the welcome message

## Configuration

You can customize the welcome message by editing the `HelloHylandPoint.json` file:

```json
{
  "WelcomeMessage": "Your custom welcome message here!"
}
```

If the config file doesn't exist, it will be created automatically with default values the first time you run the mod.

## Building from Source

### Requirements
- .NET 6.0 SDK or later
- Visual Studio 2019/2022 or another compatible IDE

### Steps
1. Clone this repository
2. Open the solution in your IDE
3. Ensure the `GamePath` in `build.bat` points to your Schedule I installation
4. Run the `build.bat` script or build the solution from your IDE

The build script will:
- Compile the mod
- Copy the DLL to the project root
- Copy the DLL to your game's Mods folder

## Logging

To view the logs:
1. Run the game with the mod installed
2. Open the MelonLoader console
3. Look for messages prefixed with `[HelloHylandPoint]`

## License

This project is open source. Feel free to modify and distribute as needed. 