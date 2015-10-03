

using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace EECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding", "Paths")]
    [ActionTitle("Draw Debug Path")]
    [ActionDescription("Draws a debug line for the path in the scene")]
    public class DrawDebugPathAction : UFAction
    {
        [In]
        public Path Path;

        public Color PathColor = Color.green;
        public float TimeToShow =  0.1f;

        public override void Execute()
        {
            var vectorPath = Path.vectorPath;
            for (var i = 1; i < vectorPath.Count; i++)
            {
                Debug.DrawLine(vectorPath[i - 1], vectorPath[i], PathColor, TimeToShow);
            }
        }
    }
}
