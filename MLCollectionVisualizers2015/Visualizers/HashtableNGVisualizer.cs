using Microsoft.VisualStudio.DebuggerVisualizers;
using System.Collections;

[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(MLCollectionVisualizers2015.HashtableNGVisualizer),
    typeof(VisualizerObjectSource),
    Target = typeof(Hashtable),
    Description = "ML HashTable Visualizer")
    ]

namespace MLCollectionVisualizers2015
{
    public class HashtableNGVisualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            MLVisualizer.ShowVisualizer(windowService, objectProvider);
        }
    }
}
