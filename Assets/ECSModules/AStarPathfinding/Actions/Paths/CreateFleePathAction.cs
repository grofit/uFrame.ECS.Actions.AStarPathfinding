

using System;
using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding - Pro")]
    [ActionTitle("Create Flee Path")]
    [ActionDescription("Creates a flee path for from an agents position")]
    public class CreateFleePathAction : UFAction
    {
        [In]
        public Vector3 SourcePosition;

        [In]
        public Vector3 AvoidPosition;

        [In]
        public int GScoreToStopAt;

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
            var path = FleePath.Construct(SourcePosition, AvoidPosition, GScoreToStopAt, PathFinishedDelegate);
            AstarPath.StartPath(path);
        }

        private void PathFinishedDelegate(Path path)
        {
            if(path.error)
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