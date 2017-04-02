using Microsoft.VisualStudio.DebuggerVisualizers;
using System.Collections.Concurrent;
using System;

[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(MLCollectionVisualizers2017.ConcurrentQueueVisualizer),
    typeof(VisualizerObjectSource),
    Target = typeof(ConcurrentQueue<>),
    Description = "ML ConcurrentQueue Visualizer")
    ]

namespace MLCollectionVisualizers2017
{
    public class ConcurrentQueueVisualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            MLVisualizer.ShowVisualizer(windowService, objectProvider);
        }
    }
}
