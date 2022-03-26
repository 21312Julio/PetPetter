# PetPetter Final Project for Dorset College - ![chsarp](https://img.shields.io/badge/-csharp-green) ![unity](https://img.shields.io/badge/-unity-lightgrey)
![](/readmeimages/pets.png)
## Table of Contents
* [Links](#links)
* [Softwares](#softwares)
* [Introduction](#introduction)
* [Walkthrough](#walkthrough)
* [Minigames](#minigames)
* [Bugs](#bugs)
* [Credits](#credits)

## Links
- Figma Prototype | https://www.figma.com/file/1XoqBgc3Rh6cbTocTWLMV0/PET-PETTER?node-id=0%3A1
- Youtube | https://youtu.be/EgCyftsUcEE
- Youtube Update | https://youtu.be/xzX6Hw4TCSQ
- Android SDK | https://drive.google.com/drive/folders/15XasSi9rXwOU5cJw2OHJJGqWWRxTibaZ?usp=sharing

## Softwares

- Unity 2020.3.30f1
- Visual Studio 2022
- Piskel

## Introduction
Pet Petter is a mobile Android clicker-game created with Unity, where you can level up your pets and discover the different name and sprite combinations. The idea is to explore what makes a game addictive and potentially a habit where the player will come back to it every day. In order to create a game for mobile where the 
elements will keep at the same place no matter the screen size, I used a combination of two scripts linked in the [Credits](#credits) to anchor elements to the 
main camera.
![](/readmeimages/changeplatform.jpg)
When downloading the project and opening it on Unity, you must go to File > Build Settings and make sure to change the platform to Android, and hit 'Switch Platform' to keep the ratio, use 18:9 Portrait. The option will only show if you have the Android SDK installed along with your current editor version. Just go to Unity Hub and click on 'Installs' to make sure.
![](/readmeimages/unityeditor.jpg)
## Walkthrough
As a player, the attributes you have are Coins, PPC (Pats-per-click), and PPS (Pats-per-second). You can get coins per second as the game goes on, as well as by patting your pet. In order to have visual elements to give feedback to the player, you find on the main screen of the game an EXPats bar on the current amount of exp you have and each time you click on the pet image, you get both visual and sound feedback.

![](/readmeimages/mainscreen.jpg)

In order to increase the amount of PPC and PPS you can spend your coins on the shop panel and upgrade panel. The price is coded in a way to gradually increase along with the amount of each itens you currently have. 

![](/readmeimages/shop.jpg)
![](/readmeimages/upgrade.jpg)

For each 10 levels you can get a new pet and the sprites and name of your pet will change and be decided automatically. There are many possible combinations for
the player to discover! The amount of EXP you need also gradually increases and cycles through the amount of levels you already have. The data of the game is being constantly updated and saved using a Binary Formatter, and the information is then loaded once the application is opened.

## Minigames
![](/readmeimages/minigamescreen.jpg)

You can also get coins by playing one of the two minigames available. The first one is called catch. In order to help the manager Bread keep awake and finish his
tasks in time, you can get the energy drinks that fall from the sky and accumulate points. If a carrot is collected, you lose. The points are also then transformed
into more coins that you can spend on shop and upgrades.

![](/readmeimages/catchone.jpg)
![](/readmeimages/catchtwo.jpg)

The second minigame you are helping the manager Bread with his work by calculating numbers. Two random numbers are generated everytime and you are prompted with
4 possibles solutions. By choosing the correct one you get a point and have to pick the correct answer for the next challenge. You can lose this minigame by either choosing the wrong answer of by having the timer hit 00:00. You get 5 more seconds for each correct answer.

![](/readmeimages/mathone.jpg)
![](/readmeimages/mathtwo.jpg)
## Bugs
The game might crash upon being loaded the first time because it won't be able to find a save file to load. Just press play again on the editor and it should work accordingly.

## Credits
- Background Music by 'super noot ensemble' 🎵 | https://www.youtube.com/watch?v=ox_T5Ia_Y0A
- Minigame Screen Music by 'HeatleyBros' 🎵 | https://www.youtube.com/watch?v=hdZLNZBZFlY
- Math Minigame Music by 'RoccoW' 🎵 | https://www.youtube.com/watch?v=UwNar5ebWzg
- Catch Minigame Music by 'Loeder/Nintendo' 8BIT COVER 🎵 | https://www.youtube.com/watch?v=oBHssgMSIwk
- Viewport Handler Script | https://gamedev.stackexchange.com/questions/79546/how-do-you-handle-aspect-ratio-differences-with-unity-2d
- Camera Anchor Script | https://gist.github.com/fadookie/256947788c364400abe1


