using Microsoft.VisualStudio.DebuggerVisualizers;
using System;
using System.Collections.Generic;

[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(MLCollectionVisualizers2015.LinkedListVisualizer),
    typeof(VisualizerObjectSource),
    Target = typeof(LinkedList<>),
    Description = "ML LinkedList Visualizer")
    ]
namespace MLCollectionVisualizers2015
{
    public class LinkedListVisualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            MLVisualizer.ShowVisualizer(windowService, objectProvider);
        }
    }
}
