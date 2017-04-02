using Microsoft.VisualStudio.DebuggerVisualizers;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(MLCollectionVisualizers2017.ReadOnlyCollectionVisualizer),
    typeof(VisualizerObjectSource),
    Target = typeof(ReadOnlyCollection<>),
    Description = "ML ReadOnlyCollection Visualizer")
    ]

namespace MLCollectionVisualizers2017
{
    public class ReadOnlyCollectionVisualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            MLVisualizer.ShowVisualizer(windowService, objectProvider);
        }
    }
}
