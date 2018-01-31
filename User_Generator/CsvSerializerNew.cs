using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User_Generator
{
    public class CsvSerializerNew<T> where T : class, new()
    {
        //public void Serialize(string FilePath, IList<T> Data)
        //{
        //    using (var w = new StreamWriter(path))
        //    {
        //        for ( /* your loop */)
        //        {
        //            var first = yourFnToGetFirst();
        //            var second = yourFnToGetSecond();
        //            var line = string.Format("{0},{1}", first, second);
        //            w.WriteLine(line);
        //            w.Flush();
        //        }
        //    }
        //}
    }

    //public class CsvIgnoreAttribute : Attribute
    //{
    //    public string Value = null;
    //}
}
