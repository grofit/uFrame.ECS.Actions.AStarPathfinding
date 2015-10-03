

using System;
using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding - Pro")]
    [ActionTitle("Create Constant Path")]
    [ActionDescription("Creates a constant path for use")]
    public class CreateConstantPathAction : UFAction
    {
        [In]
        public int MaxScore;

        [In]
        Vector3 SourcePosition;

        [Out]
        public ConstantPath GeneratedPath;

        [Out] public Action PathGenerated;

        [Out] public string Error;

        [Out] public Action PathFailed;

        public override void Execute()
        {
            var currentPath = ConstantPath.Construct(SourcePosition, MaxScore, PathFinishedDelegate);
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

            GeneratedPath = (ConstantPath) path;
            PathGenerated();
        }
    }
}