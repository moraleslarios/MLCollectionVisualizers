using Microsoft.VisualStudio.DebuggerVisualizers;
using System.Collections;

[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(MLCollectionVisualizers2017.StackVisualizer),
    typeof(VisualizerObjectSource),
    Target = typeof(Stack),
    Description = "ML Stack Visualizer")
    ]

namespace MLCollectionVisualizers2017
{
    public class StackVisualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            MLVisualizer.ShowVisualizer(windowService, objectProvider);
        }
    }
}
