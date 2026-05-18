A 2D-controlled platformer with 3D assets where the user control a fox to collect stars.
Features:
- Working ladders and water floating system
- Walls that hide when you walk through them, effectively acting as secret areas
- Stars that float on a sine wave and rotate around the Y axis
- Sound effects for jumping and collecting stars
- Camera that follows the player character and contains an AudioSource component that plays music
- Each feature is included as a prefab, so that levels can be added onto in the Unity Editor if wished

Notes/Bugs:
- Make sure to open the "scenes" folder to find the project, titled "Foxing"- otherwise the Unity Project will appear blank
- On occasion, despite a rotation lock, the fox will rotate. There is nothing to ask for this in the code besides a solid "set rotation to 90/-90" and it is probably a result of angular dampening.
- Otherwise no bugs, but the level does seem a bit short. Again, it can be extended easily with the Unity Editor, as all assets and types are in the prefabs folder and can just be dragged into the scene.
- Due to its 3-Dimensional nature, prefabs usually do not go to the same spot on the axis as the rest of the game, and will occasionally need to be dragged over so that they can be interacted with.
- The scene is not horizontal on the X axis, which makes positioning slightly more annoying.
- The course library provided "Fox" asset does not have a jumping animation, so it looks a bit lackluster in that aspect.

Plans for Future Updates:
- Enemies with basic pathfinding
- Health system
- Several levels
- Saveable game (only not added currently due to complications of "which collectibles specifically have been collected"; I do not know how to code this without individual variables for each collectible yet, which would massively clutter the code.)
- Checkpoints when the player dies
- Puzzles
- NPCs? Maybe? (Least priority)
