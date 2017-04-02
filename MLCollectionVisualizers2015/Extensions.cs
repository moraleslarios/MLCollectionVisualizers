using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace MLCollectionVisualizers2015
{
    public static class Extensions
    {

        public static DataTable ToDataTable(this IEnumerable source)
        {
            return ToDataTableActions.EnumerableToDataTable(source);
        }




    }
}
