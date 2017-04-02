using Microsoft.VisualStudio.DebuggerVisualizers;
using System;
using System.Collections.Generic;

[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(MLCollectionVisualizers2015.HashSetVisualizer),
    typeof(VisualizerObjectSource),
    Target = typeof(HashSet<>),
    Description = "ML HashSet Visualizer")
    ]
namespace MLCollectionVisualizers2015
{
    public class HashSetVisualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            MLVisualizer.ShowVisualizer(windowService, objectProvider);
        }
    }
}
