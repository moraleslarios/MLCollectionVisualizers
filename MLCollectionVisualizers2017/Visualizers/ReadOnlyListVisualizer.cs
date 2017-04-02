using Microsoft.VisualStudio.DebuggerVisualizers;
using System;
using System.Collections.Generic;

[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(MLCollectionVisualizers2017.ReadOnlyListVisualizer),
    typeof(VisualizerObjectSource),
    Target = typeof(IReadOnlyList<>),
    Description = "ML ReadOnlyList Visualizer")
    ]

namespace MLCollectionVisualizers2017
{
    public class ReadOnlyListVisualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            MLVisualizer.ShowVisualizer(windowService, objectProvider);
        }
    }
}
