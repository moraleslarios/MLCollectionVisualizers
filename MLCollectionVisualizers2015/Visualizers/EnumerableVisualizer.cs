using Microsoft.VisualStudio.DebuggerVisualizers;
using System;
using System.Collections;

[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(MLCollectionVisualizers2015.EnumerableVisualizer),
    typeof(VisualizerObjectSource),
    Target = typeof(IEnumerable),
    Description = "ML Enumerable Visualizer")
    ]
namespace MLCollectionVisualizers2015
{
    public class EnumerableVisualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            MLVisualizer.ShowVisualizer(windowService, objectProvider);
        }
    }
}
