using Microsoft.VisualStudio.DebuggerVisualizers;
using System.Collections.ObjectModel;
using System;

[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(MLCollectionVisualizers2017.ArrayVisualizer),
    typeof(VisualizerObjectSource),
    Target = typeof(ObservableCollection<>),
    Description = "ML ObservableCollection Visualizer")
    ]
namespace MLCollectionVisualizers2017
{
    public class ObservableCollectionVisualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            MLVisualizer.ShowVisualizer(windowService, objectProvider);
        }
    }
}
