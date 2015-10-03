using System;
using System.Collections.Generic;
using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding - Pro")]
    [ActionTitle("Create Multi Path")]
    [ActionDescription("Creates a path from the current agent to the destination point")]
    public class CreateMultiPathAction : UFAction
    {
        [In]
        public Vector3 SourcePosition;

        [In]
        public List<Vector3> TargetDestinations;

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
            var currentPath = MultiTargetPath.Construct(SourcePosition, TargetDestinations.ToArray(), null, PathFinishedDelegate);
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