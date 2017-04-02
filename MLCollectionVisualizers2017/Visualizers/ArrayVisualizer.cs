using Microsoft.VisualStudio.DebuggerVisualizers;
using System;

[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(MLCollectionVisualizers2017.ArrayVisualizer),
    typeof(VisualizerObjectSource),
    Target = typeof(Array),
    Description = "ML Array Visualizer")
    ]
namespace MLCollectionVisualizers2017
{

    public class ArrayVisualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            MLVisualizer.ShowVisualizer(windowService, objectProvider);
        }
    }
}
