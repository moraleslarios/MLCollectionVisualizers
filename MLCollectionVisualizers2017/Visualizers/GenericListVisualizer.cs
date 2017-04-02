using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualStudio.DebuggerVisualizers;
using System.Drawing;
using System.Runtime.Serialization;

[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(MLCollectionVisualizers2017.GenericListVisualizer),
    typeof(VisualizerObjectSource),
    Target = typeof(List<>),
    Description = "ML Collection Visualizer")
]
namespace MLCollectionVisualizers2017
{
    public class GenericListVisualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            MLVisualizer.ShowVisualizer(windowService, objectProvider);
        }
    }
}
