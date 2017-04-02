using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MLCollectionVisualizers2017
{
    public class ToDataTableActions
    {

        public static DataTable EnumerableToDataTable(IEnumerable coleccion)
        {
            if (GetFirstItem(coleccion) == null)
            {
                return new DataTable();
            }

            if (IsSimpleItem(coleccion))
            {
                return EnumerableToDataTableSimple(coleccion);
            }
            else
            {
                return EnumerableToDataTableCompuesto(coleccion);
            }
        }


        private static DataTable EnumerableToDataTableCompuesto(IEnumerable coleccion)
        {
            Type t = GetTypeItems(coleccion);

            DataTable dtResultado = new DataTable();

            PropertyInfo[] pi = t.GetProperties();

            string nombrePropiedad = string.Empty;

            try
            {
                // creamos las columnas del DataTable
                //pi.ToList().ForEach(d => dtResultado.Columns.Add(d.Name, d.PropertyType));

                CreateDatatableColums(pi, dtResultado);

                foreach (var dato in coleccion)
                {
                    List<object> row = new List<object>();
                    foreach (PropertyInfo p in pi)
                    {
                        nombrePropiedad = p.Name;
                        object value = null;
                        try
                        {
                            value = p.GetValue(dato, null);
                        }
                        catch (Exception ex1)
                        {
                            value = "Datos extraídos en error";
                        }
                        row.Add(value != null ? value : null);
                    }
                    dtResultado.Rows.Add(row.ToArray());
                }

                return dtResultado;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Ha ocurrido un error al Transformar los datos del DataTable a la clase, en la propiedad : " + nombrePropiedad + " Error : " + ex.Message, "Error en generación de Visualizador", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return new DataTable();
            }
        }

        private static void CreateDatatableColums(IEnumerable<PropertyInfo> properties, DataTable dt)
        {
            foreach (var property in properties)
            {
                if (property.PropertyType.FullName.Contains("System.Nullable"))
                {
                    dt.Columns.Add(property.Name, property.PropertyType.GenericTypeArguments.First());
                }
                else
                {
                    dt.Columns.Add(property.Name, property.PropertyType);
                }
            }
        }


        private static DataTable EnumerableToDataTableSimple(IEnumerable coleccion)
        {
            Type t = GetTypeItems(coleccion);

            DataTable dtResultado = new DataTable();
            dtResultado.Columns.Add(t.Name, t);

            try
            {
                foreach (var dato in coleccion)
                {
                    dtResultado.Rows.Add(dato);
                }
                return dtResultado;
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Ha ocurrido un error al Transformar los datos del DataTable a la clase Error : " + ex.Message, "Error en generación de Visualizador", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Error);
                return new DataTable();
            }


        }

        public static Type GetTypeItems(IEnumerable coleccion)
        {

            Type resultado = (Type)GetGenericData(coleccion, o => o.GetType());

            return resultado;
        }


        public static object GetFirstItem(IEnumerable coleccion)
        {
            return GetGenericData(coleccion, o => o);
        }


        public static bool IsSimpleItem(IEnumerable coleccion)
        {
            var tipo = GetTypeItems(coleccion);

            bool resultado = false;

            if (tipo.IsValueType || tipo.IsPrimitive || tipo.Name == "String" || tipo.IsEnum || Nullable.GetUnderlyingType(tipo) != null)
            {
                resultado = true;
            }

            return resultado;

        }






        private static object GetGenericData(IEnumerable coleccion, Func<object, object> func)
        {
            if (coleccion == null)
            {
                throw new ArgumentException("La colección introducida no puede ser nula");
            }

            object resultado = null;

            var enumerador = coleccion.GetEnumerator();

            while (enumerador.MoveNext())
            {
                resultado = func(enumerador.Current);

                break;
            }

            return resultado;
        }


    }
}
