using Microsoft.VisualStudio.DebuggerVisualizers;
using System.Collections.Concurrent;
using System;

[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(MLCollectionVisualizers2017.ConcurrentBagVisualizer),
    typeof(VisualizerObjectSource),
    Target = typeof(ConcurrentBag<>),
    Description = "ML ConcurrentBag Visualizer")
    ]
namespace MLCollectionVisualizers2017
{
    public class ConcurrentBagVisualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            MLVisualizer.ShowVisualizer(windowService, objectProvider);
        }
    }
}
