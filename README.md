Flappy Bird Unity Project
This is a simple Flappy Bird style game built with Unity. The game involves a bird navigating through pipes by flapping to avoid collisions. The code uses C# scripts and the Unity 2D physics system.

Features
Bird flapping controlled by spacebar or mouse click.

Pipes spawn with random vertical positions creating a gap.

Simple scoring and game over logic.

Designed to build for WebGL or standalone platforms.

Scripts Overview
BirdScript.cs: Controls bird movement, flapping input, and collision detection.

PipeSpawnerScript.cs: Spawns pipe pairs at regular intervals with random heights.

PipeMiddleScript.cs: Handles pipe middle segment behavior.

PipeMoveScript.cs: Moves pipes leftwards to simulate bird movement.

LogicScript.cs: Handles game logic such as scoring and game over.

How to Run
Open the project in Unity.

Attach the scripts to respective GameObjects (Bird, Pipes, Game Logic).

Set up the build profile for your target platform (WebGL recommended for easy sharing).

Build and run your game.

Input
Press Spacebar or Click to make the bird flap upwards.

The bird automatically falls due to gravity.

Building for WebGL
Use Unity's Build Profiles to build the project for WebGL.

Upload the resulting build folder to a web host or Unity Play for browser play.

