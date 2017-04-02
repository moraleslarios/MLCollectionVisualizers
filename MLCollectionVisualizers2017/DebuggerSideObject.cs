using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.DebuggerVisualizers;

namespace MLCollectionVisualizers2017
{
    class DebuggerSideObject : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            object o = objectProvider.GetObject();

            System.Diagnostics.Debugger.Launch();
        }
    }
}
