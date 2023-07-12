<p align="center">
 <img width="200px" src="https://i.imgur.com/TUygkzS.png" align="center" alt="GitHub Readme Stats" />
 <h2 align="center">TownieLib</h2>
 <p align="center">Town of Salem 2 Mod Library! 
</p>
<p align="center">
Not to be confused with <img width= "30px" src="https://i.imgur.com/WB9QCft.png"/> Coven.
</p>
<br>
  <p align="center">
    <a href="https://github.com/djshinter/townielib/graphs/contributors">
      <img alt="GitHub Contributors" src="https://img.shields.io/discord/1003392508568535101?label=discord&logo=discord&style=flat" />
    </a>
    <a href="https://github.com/djshinter/townielib/graphs/contributors">
      <img alt="GitHub Contributors" src="https://img.shields.io/github/contributors/djshinter/TownieLib" />
    </a>
    <a href="https://github.com/djshinter/townielib/graphs/contributors">
    <a href="https://github.com/djshinter/townielib/issues">
      <img alt="Issues" src="https://img.shields.io/github/issues/djshinter/TownieLib?color=0088ff" />
    </a>
    <a href="https://github.com/djshinter/townielib/pulls">
      <img alt="GitHub pull requests" src="https://img.shields.io/github/issues-pr/djshinter/townielib?color=0088ff" />
    </a>
    <br/>
    <br/>
    <a href="https://github.com/BepInEx/BepInEx">
      <img src="https://img.shields.io/badge/Supports-BepInEx-gray.svg?colorA=orange&colorB=FB542B&style=for-the-badge"/>
    </a>
  </p>

  <p align="center">
    <a href="https://discord.gg/bCEbam2anG">Join the Discord!</a>
    ·
    <a href="https://github.com/djshinter/townielib/issues/new/choose">Report Issues</a>
    ·
    <a href="https://github.com/djshinter/townielib/issues/new/choose">Request Feature</a>
    ·
    <a href="https://github.com/DjShinter/TownieLib/wiki">Documentation</a>
  </p>


<p align="center">Love the project? Please consider <a href="https://github.com/DjShinter/TownieLib/Contribution.md">contributing</a> to help it improve.</p>




___
### TownieLib
The purpose of TownieLib is to help Modder's create mods for [Town of Salem 2](https://store.steampowered.com/app/334230/Town_of_Salem/).

This project is an ongoing project and is under heavy development, so expect breaking with minor revisions before the 1.0.0 release.

TownieLib is mainly used to help making mods to prevent code repetition and complex code as it is only needed to be implemented once.
### Example Code

```cs
using TownieLib;
using UnityEngine;

void Awake() 
    {
        // ur stuff
    }
void Update()
    {
        if (Input.GetKey(KeyCode.LeftControl) || Input.GetKey(KeyCode.RightControl))
        {
            if(Input.GetKeyDown(KeyCode.F))
            {
                Logger.LogInfo($"The game phase is {TownieApi.GamePhase}...");
            }
        }
        
    }
```

This example assumes you already know how to setup a BepInEx Plugin, and this advises you on how to use TownieLib, If TownieLib is missing a useful or required method / field, it can be [requested](https://github.com/djshinter/townielib/issues/new/choose) here, and if you can contribute, you may read the contributing section!
____
### Building this project

*to be written*...

____
### Contributing
You would need to follow the "Building this project", and you can create a pull request.


All help is appreciated!


___
### Is modding bannable?
To quote the "Salem Mod Loader" [Discord](https://discord.gg/bCEbam2anG).
> Use the mod at your own risk, while you have very low odds of being banned, you could be at risk if you openly state in games you are running a modded client as trials may guilty you under hacking even though the mod gives no advantages.

[Town of Salem Rules](https://www.blankmediagames.com/rules/)
> No Cheating – Gaining an unfair advantage over players through means other than normal gameplay. This includes but isn’t limited to using multiple accounts in the same game, sharing information outside the game, using a foreign language to communicate in a way that can’t be understood by the players in the current locale, and posting screenshots to prove something happened in game.

To quote a developer in the official Town of Salem 2 [Discord](https://discord.gg/townofsalem2). [Message Link](https://discord.com/channels/1110363758792036352/1111801081060655154/1112876123852906617)
> We plan to have official mod support, but having a good base is important. A new player won't have a mod preinstalled.

</p>

___
### Credits
[ljoonal](https://github.com/ljoonal) - Very helpful! This project wouldn't have existed without them.
