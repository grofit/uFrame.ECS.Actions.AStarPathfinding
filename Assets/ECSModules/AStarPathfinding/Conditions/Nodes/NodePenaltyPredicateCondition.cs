using System;
using Pathfinding;
using uFrame.Actions;
using uFrame.Attributes;

namespace ECSModules.AStarPathfinding
{
    [uFrameCategory("A* Pathfinding")]
    [ActionTitle("Node Penalty Predicate")]
    [ActionDescription("Checks node penalty with predicate")]
    public class NodePenaltyPredicateCondition : UFAction
    {
        [In]
        public GraphNode NodeToCheck;

        [In]
        public PredicateTypes PredicateType = PredicateTypes.EqualTo;

        [In]
        public int ComparisonValue;

        [Out]
        public Action True;

        [Out]
        public Action False;

        public override void Execute()
        {
            var penalty = NodeToCheck.Penalty;
            var result = false;
            switch (PredicateType)
            {
                case PredicateTypes.EqualTo: { result = (penalty == ComparisonValue); } break;
                case PredicateTypes.GreaterThan: { result = (penalty > ComparisonValue); } break;
                case PredicateTypes.GreaterThanOrEqualTo: { result = (penalty >= ComparisonValue); } break;
                case PredicateTypes.LessThan: { result = (penalty < ComparisonValue); } break;
                case PredicateTypes.LessThanOrEqualTo: { result = (penalty <= ComparisonValue); } break;
            }

            if(result)
            { True(); }
            else
            {  False(); }
        }
    }
}