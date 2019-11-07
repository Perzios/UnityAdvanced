# UnityAdvanced
Unity Advanced
The Creation of a 3D World
CSC3020H Assignment 4
1 Introduction
This practical is intended to familiarize you with the 3D side of Unity. You will
be setting up a 3D scene in Unity focused around a player model with a weapon
or item (gun, flashlight?). You can use any model (a basic Cube would do, but
search online for free models (or in the Unity Asset Store)).
You will be tested on your use of Unitys built in functionality for rendering
various 3D aspects in a game. This practical will not test you on the ability to
create advanced shaders but you will need to understand how to use the built
in shaders in Unity.
This practical is designed to prepare you for your final gaming practical. We
recommend that you design the practical in such a way that you can easily reuse
it or pieces of it when it comes time for your final practical since this will save
you some time.
2 Requirements
2.1 Player Model Setup and Movement
You will need to implement a model carrying a weapon, you will need to have
controls set up that allow you to move the model around the world. In addition to
basic movement, you will need to be able to move the weapon/item. Appropriate
animation of the model will need to be displayed to represent these movements.
There are samples that demonstrate all of this functionality, so please refer to
the resource list at the end of this practical spec.
2.2 Cameras
Next you will need to implement a set of Unity cameras. You will have to add
scripts to the cameras to define their behavior. The first camera will be a 3rd
person chase camera that has initial acceleration and deceleration when following
the models movement; its not a fixed camera but has a fluid motion. The second
camera you will need to implement is an orbiting camera that will fly in a circle
with the model always focused as its target. The last camera will be a first person
camera that should have the weapon in view, it must also move up, down, left or
right when the player moves the view. Both the 3rd person and orbiting cameras
should be configurable in game by allowing the player to set the distance from
the model (radius) as well as height easily.
2.3 Environment Setup and Physics
Now that the camera is set up you need to create the environment; you will
need to place a ground object in the X-Z axis that represents the floor that the
model drives on. Next you will need to place several randomly placed randomized
objects; feel free to make use of your own. Remember to use Prefabs for multiple
instances of an object.
These objects that you create will serve as collidable objects. By now you
should be familiar with the Unity physics system. You now have to extend this
by implementing 3D physics in your game world. The player model and world
objects need to be able to collide. Remember to use Triggers and Colliders.
2.4 Ray-casting
The Player Model needs to be able to shoot the weapon. In order to detect
collisions you will have to implement ray casting. Appropriate objects that are
hit by this ray need to be destructible.
2.5 Visual Effects
Now that most of the scene is set up you will need to add in some visual effects in
the form of lights, texturing, text and particle effects. You will need to make use
of different types of lights in your scene. You need to add in textures for each of
the random objects that you place in the scene. This is done through Materials
and Textures. To get you familiar with certain elements of Unity you will be
required to render 3D text to the scene. The final piece of graphics functionality
is the use of the built in particle effects engine and identifying a suitable effect
that matches your scene well in terms of aesthetics. The Particle System can
help make game effects look really professional. This could either be triggered
when there are collisions or by player input.
Just a few notes about the randomness factor. In the practical you need to
place a set of objects in the environment. These need to be of various model
types (sphere, cube, etc) which are placed about the level randomly and also
have a randomly assigned material type (texture). This will prevent hard coding
of the various aspects in the game and will allow for some diversity and thus
keep things interesting.
2.6 Sounds
You are required to implement audio for the scene. Examples of useful sounds
to have include bullets firing or explosions when objects are destroyed.
3 Marking Guide
Feature Marks
Player Movement and Animation 15%
Cameras 15%
Environment setup and Physics 15%
Raycasting 10%
Visual Effects 30%
Sounds 5%
Randomness 10%
4 Submission Deadline
Hand in the assignment by 10.00am Monday, 4 June 2018.
5 Useful Resources
1. https://unity3d.com/learn/tutorials/s/roll-ball-tutorial
2. https://unity3d.com/learn/tutorials/projects/adventure-game-tutorial
