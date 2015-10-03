//#define IS_ASTAR_FREE


#if IS_ASTAR_FREE
namespace Pathfinding
{
	public class FloodPathTracer : Path
	{	
		public static FloodPathTracer Construct (Vector3 position , FloodPath floodPath , OnPathDelegate callback)
        { return null; }

        protected override void Recycle()
        {
            throw new System.NotImplementedException();
        }

        public override void Prepare()
        {
            throw new System.NotImplementedException();
        }

        public override void Initialize()
        {
            throw new System.NotImplementedException();
        }

        public override void CalculateStep(long targetTick)
        {
            throw new System.NotImplementedException();
        }
	}
}
#endif