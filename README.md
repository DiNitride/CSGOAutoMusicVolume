# CSGO Music Controller
Automatically adjusts music levels up and down during the round depending on whether the player is alive or dead.

## Installation
1. [Download and run the installer](https://github.com/DiNitride/CSGOAutoMusicVolume/releases)
2. (Optional, but recomended) The shortcut the installer made was really weird so, navigate to the install directory and create on manually and drop it on your desktop or wherever. The directory by default is `"C:\Program Files (x86)\CSGO Automatic Music Control\CSGOMusicController.exe"`
3. Launch the program
4. Select your music player from the drop down list, if it's not there start playing music on it and hit refresh.
5. Boot CS:GO and once the game is loaded you can click start on the program. Once you're in-game, it may take 10-20 seconds for CS:GO to start sending the updates to the program and for it to start communicating.

## FAQ
**I'm getting an error when I boot?! "A CS:GO Install could not be located"**
This means that either the program couldn't automatically find your CS:GO install, and you will need to manually add the required cfg to the install folder yourself. To do this, copy the file called `gamestate_integration_musicControllApp.cfg` to `/csgo/cfg/` within your `Counter-Strike Global Offensive` install directory. You will get the error every time it loads, however if you dismiss it and continue the program will work as normal.

## Contributing
If you're interesting in contributing to anything, feel free to open a issue, or fork the repo and make a PR back in with your changes. Also, before starting this project I had 0 hours of experience with C#, I learnt everything on the way, so please excuse any poor practice, please correct me!
