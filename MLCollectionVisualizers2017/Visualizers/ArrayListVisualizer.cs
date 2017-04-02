using Microsoft.VisualStudio.DebuggerVisualizers;
using System.Collections;

[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(MLCollectionVisualizers2017.ArrayListVisualizer),
    typeof(VisualizerObjectSource),
    Target = typeof(ArrayList),
    Description = "ML ArrayList Visualizer")
    ]

namespace MLCollectionVisualizers2017
{
    public class ArrayListVisualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            MLVisualizer.ShowVisualizer(windowService, objectProvider);
        }
    }
}
