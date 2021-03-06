﻿using Microsoft.VisualStudio.DebuggerVisualizers;
using System;
using System.Collections.Generic;

[assembly: System.Diagnostics.DebuggerVisualizer(
    typeof(MLCollectionVisualizers2015.StackGenericVisualizer),
    typeof(VisualizerObjectSource),
    Target = typeof(Stack<>),
    Description = "ML StackGeneric Visualizer")
    ]

namespace MLCollectionVisualizers2015
{
    public class StackGenericVisualizer : DialogDebuggerVisualizer
    {
        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            MLVisualizer.ShowVisualizer(windowService, objectProvider);
        }
    }
}
