using Microsoft.VisualStudio.DebuggerVisualizers;
using System.Collections.Concurrent;
using System;

[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(MLCollectionVisualizers2017.ConcurrentStackVisualizer),
    typeof(VisualizerObjectSource),
    Target = typeof(ConcurrentStack<>),
    Description = "ML ConcurrentStack Visualizer")
    ]
namespace MLCollectionVisualizers2017
{
    public class ConcurrentStackVisualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            MLVisualizer.ShowVisualizer(windowService, objectProvider);
        }
    }
}
