using System;
using System.Collections;
using System.IO;
using System.Numerics;

namespace Python
{
    public partial class System
    {
        #region print

        public static void Print(object @object,
                                 string sep = " ",
                                 string end = "\r\n",
                                 StreamWriter file = null,
                                 bool flush = false) => print(@object, sep, end, file, flush);


        public static void Print(IEnumerable @object,
                                 string sep = " ",
                                 string end = "\r\n",
                                 StreamWriter file = null,
                                 bool flush = false) => print(@object, sep, end, file, flush);





#if OBSOLETE
        [Obsolete("This method is deprecated, use `{nameof(Print)}` instead.")]
#endif
        public static void print(object @object,
                                 string sep = " ",
                                 string end = "\r\n",
                                 StreamWriter file = null,
                                 bool flush = false)
        {
            var _file = file ?? Console.Out;

            _file.Write(@object);
            _file.Write(end);
            if (flush) _file.Flush();
        }

#if OBSOLETE
        [Obsolete("This method is deprecated, use `{nameof(Print)}` instead.")]
#endif
        public static void print(IEnumerable @object,
                                 string sep = " ",
                                 string end = "\r\n",
                                 StreamWriter file = null,
                                 bool flush = false)
        {
            var _file = file ?? Console.Out;
            if (@object is String)
            {
                _file.Write(@object);
                _file.Write(end);
            }
            else
            {
                string str = "";
                foreach (var item in @object)
                {
                    str += item.ToString();
                    str += sep;
                }

                str = str.Remove(str.Length - sep.Length, sep.Length);

                _file.Write(str);
                _file.Write(end);
            }
            if (flush) _file.Flush();
        }
        #endregion

    }
}
