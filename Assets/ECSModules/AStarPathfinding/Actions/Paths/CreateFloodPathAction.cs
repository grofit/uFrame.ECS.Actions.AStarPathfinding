

using System;
using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding - Pro")]
    [ActionTitle("Create Flood Path")]
    [ActionDescription("Creates a flood path for subsequent lookups")]
    public class CreateFloodPathAction : UFAction
    {
        [In]
        public Vector3 SourcePosition;

        [Out]
        public Path GeneratedPath;

        [Out]
        public Action PathGenerated;

        [Out]
        public string Error;

        [Out]
        public Action PathFailed;

        public override void Execute()
        {
            var currentPath = FloodPath.Construct(SourcePosition, PathFinishedDelegate);
            AstarPath.StartPath(currentPath);
        }

        private void PathFinishedDelegate(Path path)
        {
            if (path.error)
            {
                Error = path.errorLog;
                PathFailed();
                return;
            }

            GeneratedPath = (FloodPath)path;
            PathGenerated();
        }
    }
}