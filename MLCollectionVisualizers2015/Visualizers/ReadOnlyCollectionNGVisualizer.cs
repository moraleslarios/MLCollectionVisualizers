using Microsoft.VisualStudio.DebuggerVisualizers;
using System.Collections;

[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(MLCollectionVisualizers2015.ReadOnlyCollectionNGVisualizer),
    typeof(VisualizerObjectSource),
    Target = typeof(ReadOnlyCollectionBase),
    Description = "ML ReadOnlyCollection Visualizer")
    ]

namespace MLCollectionVisualizers2015
{
    public class ReadOnlyCollectionNGVisualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            MLVisualizer.ShowVisualizer(windowService, objectProvider);
        }
    }
}
