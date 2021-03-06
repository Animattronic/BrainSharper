﻿using BrainSharper.Abstract.Algorithms.Infrastructure;
using BrainSharper.Abstract.MathUtils.DistanceMeaseures;

namespace BrainSharper.Abstract.Algorithms.Knn
{
    public interface IKnnPredictor<TPredictionResult> : IPredictor<TPredictionResult>
    {
        IDistanceMeasure DistanceMeasure { get; }
        bool NormalizeNumericValues { get; set; }

        // TODO: add maybe methods for handling matrices directly in Predict call
    }
}
