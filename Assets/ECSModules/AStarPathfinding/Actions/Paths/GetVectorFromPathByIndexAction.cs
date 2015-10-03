

using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;
using UnityEngine;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding", "Paths")]
    [ActionTitle("Get Vector From Path By Index")]
    [ActionDescription("Gets a vector from a path by index")]
    public class GetVectorFromPathByIndexAction : UFAction
    {
        [In]
        public Path Path;

        [In]
        public int Index;

        [Out]
        public Vector3 Vector;

        public override void Execute()
        {
            if (Path.path.Count >= Index) { return; }

            Vector = Path.vectorPath[Index];
        }
    }
}