# A* Pathfinding Actions for uFrame ECS

A set of actions to expose A* pathfinding functionality directly to the ECS handlers.

## Targeted Versions

- uFrame ECS (beta2)
- A* Free/Pro (3.7)

## Installation

- Make sure you have added this package with at least the AStarPathfinding folder
- Make sure you have A* Pathfinding (Aron Granberg) free or pro installed
- Make sure you have uFrame ECS installed

We have a `dist` folder to allow you to just take the `.unitypackage`, although you can download the source if you wish to make a custom version of the actions.

## Using Actions & Conditions
You should now notice that you have a new category in your actions and conditions called A* Pathfinding 
and A* Pathfinding Pro. You can then put the actions into your project and use them rather than 
interacting progmatically.

## Using A* Free Version

If you are using the free version then you will need to enable polyfills or you will get errors
within the project, to enable polyfills go to the "polyfills" folder and  you should see a list
of files within there. The top line will have a commented out bit of code which looks like:

`//#define IS_ASTAR_FREE`

If you remove the `//` (uncomment) that line in each polyfill then your actions will work correctly.
This unfortunately is the only way in which we can support both pro and free versions with a
single package.