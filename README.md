# CSGO Music Controller
Automatically adjusts music levels up and down during the round depending on whether the player is alive or dead.

## Installation
1. [Download and run the installer](https://github.com/DiNitride/CSGOAutoMusicVolume/releases)
2. Launch the program
3. Select your music player from the drop down list, if it's not there start playing music on it and hit refresh.
4. Boot CS:GO and once the game is loaded you can click start on the program. Once you're in-game, it may take 10-20 seconds for CS:GO to start sending the updates to the program and for it to start communicating.

## Troubleshooting
### #1-  I'm getting an error when I boot?! "A CS:GO Install could not be located"


This means that either the program couldn't automatically find your CS:GO install, and you will need to manually add the required cfg to the install folder yourself. To do this, copy the file called `gamestate_integration_musicControllApp.cfg` to `/csgo/cfg/` within your `Counter-Strike Global Offensive` install directory. You will get the error every time it loads, however if you dismiss it and continue the program will work as normal.

### #2 - My music player isn't showing up

Start playing music in the player to start the audio session in windows and press refresh. It should appear.

### #3 - It's been over 2 minutes and CS:GO hasn't started communicating with it

Ensure that the cfg was correctly loaded, follow the steps for trouble shooting #1

## Building an .exe
If you're spooked by the "Unknown Publisher" warning from Windows you'd rather opt to build the .exe from source locally rather than using an installer, you can do so with VS 2017 and simply importing the project. Switch the build to `release` from `debug` and then `build > build solution`. The .exe will be found in the project directory under `/bin/release/`

## Contributing
If you're interesting in contributing to anything, feel free to open a issue, or fork the repo and make a PR back in with your changes. Also, before starting this project I had 0 hours of experience with C#, I learnt everything on the way, so please excuse any poor practice, please correct me!
