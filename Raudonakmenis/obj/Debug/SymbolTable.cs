using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Raudonakmenis.obj.Debug
{
    public class SymbolTable
    {
        private Dictionary<String, object> table;

        public SymbolTable()
        {
            table = new Dictionary<String, object>();
        }

        public void put(String name, object value)
        {
            table.Add(name, value);
        }

        public object get(String name)
        {
            return table[name];
        }

        public bool contains(String name)
        {
            return table.ContainsKey(name);
        }

        public int size()
        {
            return table.Count;
        }
        public void add(String name, object value)
        {
            table[name] = value;
        }
    }
}
