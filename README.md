# Dodge Game 3D

A Physics-Based Survival Challenge in Unity.

## Project Overview
This project is a 3D survival game developed to master the core fundamentals of Unity Engine and C# Scripting. It focuses on real-time object interaction, physics-based movement, and dynamic environment triggers.

## Core Mechanics

* Dynamic Interaction: The player (controlled cube) changes the color of any static object to red upon collision.
* Collision Tracking: Every unique interaction is calculated and logged in real-time to the system console.
* Smart Chaser Spheres: These entities continuously track the player's live position and self-destruct upon successful contact.
* Targeted Projectiles: Objects programmed to move toward specific coordinates and vanish once their objective is reached.
* Rotational Hazards: Centrally located rotating obstacles designed to test player timing and movement precision.

## Technical Stack & Implementation

* Engine: Unity 2022.x+
* Language: C# (MonoBehaviour)
* Physics: OnCollisionEnter, Rigidbody
* Movement: Vector3.MoveTowards, Transform.Rotate
* Logic: Dynamic Instantiation & Destruction

## How to Run

1. Clone the Repo:
   git clone https://github.com/yourusername/Dodge_game.git

2. Open Project:
   Launch Unity Hub, click "Add", and select the project folder.

3. Play:
   Open "Assets/Scenes/SampleScene.unity" and press the Play button at the top of the editor.
