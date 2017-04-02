using Microsoft.VisualStudio.DebuggerVisualizers;
using System;
using System.Collections.Generic;

[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(MLCollectionVisualizers2017.LinkedListVisualizer),
    typeof(VisualizerObjectSource),
    Target = typeof(LinkedList<>),
    Description = "ML LinkedList Visualizer")
    ]
namespace MLCollectionVisualizers2017
{
    public class LinkedListVisualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            MLVisualizer.ShowVisualizer(windowService, objectProvider);
        }
    }
}
