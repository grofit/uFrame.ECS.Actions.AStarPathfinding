using System;
using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding", "Paths")]
    [ActionTitle("Create AB Path")]
    [ActionDescription("Creates an AB Path from the source position to the destination position.")]
    public class CreateABPathAction : UFAction
    {
        [In]
        public Vector3 SourcePosition;

        [In]
        public Vector3 DestinationPosition;

        [Out]
        public Path GeneratedPath;

        [Out]
        public string Error;

        [Out]
        public Action PathGenerated;

        [Out]
        public Action PathFailed;

        public override void Execute()
        {
            var currentPath = ABPath.Construct(SourcePosition, DestinationPosition, PathFinishedDelegate);
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

            GeneratedPath = path;
            PathGenerated();
        }
    }
}