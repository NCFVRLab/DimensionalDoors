# DimensionalDoors

This was a project I worked on in Fall 2019, it was inspired by Minecraft mod called Dimensional Doors. In the game, we built a few different levels each exploring an interesting idea. 

Our game was built in Unreal 4.23 for the Oculus Rift. It will probably work with the HTC Vive but we haven't tested it.

# How to play 
If you want to play the game clone the repo and download Unreal Engine 4.23.
Once you've cloned the project open up file explorer, naviagate to \[Dimensional Doors place\]/DimensionalDoors and double click on DimensionalDoors.uproject.
This will launch the project in Unreal. It'll take a while to do this since this the first time the game has been opened on your computer 
## Lighting
Once you've done that I'd suggest building the lighting for all the levels, that way you'll see the game how we intended not with the quick rendering, you can do this by clicking the build button at the top. Depending on the level and how fast your game is it can take a few minutes to build the lighting. For reference on my computer (Intel i7-8750H), production lighting and on the Ocean level which is the slowest to load it took 13 minutes.
To save you time I suggest you build a lower lighting quality on the Ocean level, you can do this by clicking the drop down on the build button going to lighting quality then choose which setting you want. 

Once you're all done with that you can start the game, load up the SpawnMap located in Content/Maps/SpawnMap. Then you can click the drop down next to play (Up at the top of the screen) and select VR Preview.

# Controls 

Left hand joystick controls movement (walking is relative to the player, not the world)
A increase speed (Upper right hand button)
B decrease speed (Lower right hand button)
Side triggers close your hand
To open a door you close your hand and reach for the door knob

# Levels

Spawn Map -  The purpose of this level is to allow players to be in a room where they can just play around with the controls and get comfortable in VR.
Cave - This is a level in a mountain range, where you're standing on a broken bridge above a pit of deadly slime. 
Kitchen - If you’ve seen the old Alice in Wonderland movie Disney released in 1951 then you might recognize we’re recreating the [Door Scene](https://www.youtube.com/watch?v=di7dZwidXZU). In the scene Alice sees a door that's too small for her to fit through. She then drinks a bottle and shrinks down to a size that's small enough to walk through the door. We recreated that scene in VR where you drink from a bottle and shrink down.
Nothingness -  In this level we wanted to see if players would get motion sick if they were walking on nothing (thus the name). By the way for this level you can't move with the joystick past the platform, you need to physically walk to the door. If your VR playspace is too small to reach the door either move the door closer or just restart the game so that you can hopefully skip this level
Ocean - This level simulates life at the bottom of the sea. Surrounded by rocks, coral, seaweed, and a sunken submarine, the player wanders along the seafloor in search of the door. 

https://www.youtube.com/watch?v=yegCryR3d_E
