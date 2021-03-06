﻿namespace BrainSharper.Implementations.Algorithms.RandomForests
{
    using Abstract.Algorithms.RandomForests;

    public class RandomForestParams : IRandomForestModelBuilderParams
    {
        public RandomForestParams(int treesCount, int maximalTreeDepth)
        {
            TreesCount = treesCount;
            MaximalTreeDepth = maximalTreeDepth;
        }

        public int TreesCount { get; }
        public int MaximalTreeDepth { get; }
    }
}
