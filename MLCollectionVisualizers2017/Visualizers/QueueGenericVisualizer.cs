using Microsoft.VisualStudio.DebuggerVisualizers;
using System;
using System.Collections.Generic;

[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(MLCollectionVisualizers2017.QueueGenericVisualizer),
    typeof(VisualizerObjectSource),
    Target = typeof(Queue<>),
    Description = "ML QueueGeneric Visualizer")
    ]

namespace MLCollectionVisualizers2017
{
    public class QueueGenericVisualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            MLVisualizer.ShowVisualizer(windowService, objectProvider);
        }
    }
}
