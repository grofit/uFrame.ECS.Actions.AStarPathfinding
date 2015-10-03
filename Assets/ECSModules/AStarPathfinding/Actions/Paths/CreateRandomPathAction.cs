using System;
using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.AStarPathfinding
{
    [ActionLibrary]
    [uFrameCategory("A* Pathfinding - Pro")]
    [ActionTitle("Create Random Path")]
    [ActionDescription("Creates a random path based upon the starting point and the search length")]
    public class CreateRandomPathAction : UFAction
    {
        [In] public Vector3 StartingPoint;
        [In] public int SearchLength;

        [Out] public Path GeneratedPath;
        [Out] public Action PathGenerated;

        [Out] public string Error;
        [Out] public Action PathFailed;

        public override void Execute()
        {
            var currentPath = RandomPath.Construct(StartingPoint, SearchLength, PathFinishedDeletate);
            AstarPath.StartPath(currentPath);
        }

        private void PathFinishedDeletate(Path path)
        {
            if (path.error)
            {
                Error = path.errorLog;
                PathFailed();
            }
            else
            {
                GeneratedPath = path;
                PathGenerated();
                PathGenerated();
            }
        }
    }
}