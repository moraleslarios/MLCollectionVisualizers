using Microsoft.VisualStudio.DebuggerVisualizers;
using System;
using System.Collections;
using System.Runtime.Serialization;

namespace MLCollectionVisualizers2015
{
    public static class MLVisualizer
    {
        public static void ShowVisualizer(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
        {
            //System.Diagnostics.Debugger.Launch();

            try
            {
                object o = objectProvider.GetObject();

                if (o == null)
                {
                    System.Windows.Forms.MessageBox.Show($"The collection you are trying to view isn't compatible with MLCollectionVisualizer {StringsData.VSVERSION}.", "Collection not supported", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                }

                IEnumerable datos = (IEnumerable)o;

                var dt = datos.ToDataTable();

                //System.Diagnostics.Debugger.Launch();

                Viewer ventana = new Viewer(dt);

                windowService.ShowDialog(ventana);
            }
            catch (SerializationException ex)
            {
                System.Windows.Forms.MessageBox.Show("The datatype of your collections, isn't SERIALIZABLE, you mark the class with [Serializable] attribute for previsualize data.", "Clase is not serializable", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                if (ex.GetType().Name == "RemoteObjectSourceException")
                {
                    System.Windows.Forms.MessageBox.Show("The datatype of your collections, isn't SERIALIZABLE, you mark the class with [Serializable] attribute for previsualize data.", "Clase is not serializable", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
                }
                else
                {
                    System.Windows.Forms.MessageBox.Show("Has been an general error to previsualize the collection, Error : " + ex.Message, "Previsualize Error", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                }

            }
        }
    }
}
