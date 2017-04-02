using Microsoft.VisualStudio.DebuggerVisualizers;
using System.Collections;

[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(MLCollectionVisualizers2015.QueueVisualizer),
    typeof(VisualizerObjectSource),
    Target = typeof(Queue),
    Description = "ML Queue Visualizer")
    ]

namespace MLCollectionVisualizers2015
{
    public class QueueVisualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            MLVisualizer.ShowVisualizer(windowService, objectProvider);
        }
    }
}
