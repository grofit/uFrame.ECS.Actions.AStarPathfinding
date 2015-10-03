

using System;
using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding - Pro")]
    [ActionTitle("Create Flood Path Trace")]
    [ActionDescription("Creates a path from the trace start to the flood path start")]
    public class CreateFloodPathTraceAction : UFAction
    {
        [In]
        public Vector3 TraceStart;

        [In]
        public FloodPath FloodPath;

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
            var path = FloodPathTracer.Construct(TraceStart, FloodPath, PathFinishedDelegate);
            AstarPath.StartPath(path);
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