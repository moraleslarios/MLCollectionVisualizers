using Microsoft.VisualStudio.DebuggerVisualizers;
using System.Collections;

[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(MLCollectionVisualizers2015.StackVisualizer),
    typeof(VisualizerObjectSource),
    Target = typeof(Stack),
    Description = "ML Stack Visualizer")
    ]

namespace MLCollectionVisualizers2015
{
    public class StackVisualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            MLVisualizer.ShowVisualizer(windowService, objectProvider);
        }
    }
}
