using System;
using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding")]
    [ActionTitle("Is Path Valid")]
    [ActionDescription("Checks to see if the path is valid and not null or empty")]
    public class IsPathValid : UFAction
    {
        [In]
        public Path Path;

        [Out]
        public Action True;

        [Out]
        public Action False;

        public override void Execute()
        {
            if(Path == null || Path.error || Path.vectorPath.Count == 0)
            { True(); }
            else
            { False(); }
        }
    }
}