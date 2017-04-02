using Microsoft.VisualStudio.DebuggerVisualizers;
using System.Collections;

[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(MLCollectionVisualizers2017.QueueVisualizer),
    typeof(VisualizerObjectSource),
    Target = typeof(Queue),
    Description = "ML Queue Visualizer")
    ]

namespace MLCollectionVisualizers2017
{
    public class QueueVisualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            MLVisualizer.ShowVisualizer(windowService, objectProvider);
        }
    }
}
