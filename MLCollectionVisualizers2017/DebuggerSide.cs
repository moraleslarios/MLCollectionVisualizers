//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;
//using Microsoft.VisualStudio.DebuggerVisualizers;
//using System.Drawing;
//using System.Runtime.Serialization;

//[assembly: System.Diagnostics.DebuggerVisualizer(
//    typeof(PkoVisualizer.DebuggerSide),
//    typeof(VisualizerObjectSource),
//    Target = typeof(List<>),
//    Description = "Pakkko Collection Visualizer")
//]
//namespace MLCollectionVisualizers2017
//{
//    public class DebuggerSide : DialogDebuggerVisualizer
//    {



//        protected override void Show(IDialogVisualizerService windowService, IVisualizerObjectProvider objectProvider)
//        {
//            //System.Diagnostics.Debugger.Launch();

//            try
//            {
//                object o = objectProvider.GetObject();

//                if(o == null)
//                {
//                    System.Windows.Forms.MessageBox.Show("La colección que intenta visualizar no es compatible con VS2015.", "Colección no compatible para Visualizers de VS 2015", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
//                }

//                IList datos = (IList)o;

//                var dt = datos.ToDataTable();

//                //System.Diagnostics.Debugger.Launch();

//                Viewer ventana = new Viewer(dt);

//                windowService.ShowDialog(ventana);
//            }
//            catch (SerializationException ex)
//            {
//                System.Windows.Forms.MessageBox.Show("El tipo de datos de la colección que quiere previsualizar, no es SERIALIZABLE, marque la clase con el atributo [Serializable] para poder realizar la ejecución.", "Clase no serializable", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
//            }
//            catch (Exception ex)
//            {
//                if (ex.GetType().Name == "RemoteObjectSourceException")
//                {
//                    System.Windows.Forms.MessageBox.Show("El tipo de datos de la colección que quiere previsualizar, no es SERIALIZABLE, marque la clase con el atributo [Serializable] para poder realizar la ejecución.", "Clase no serializable", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Information);
//                }
//                else
//                {
//                    System.Windows.Forms.MessageBox.Show("Ha ocurrido un error general al previsualizar los datos Error : " + ex.Message, "Error en generación de Visualizador", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
//                }

//            }
//        }
//    }
//}
