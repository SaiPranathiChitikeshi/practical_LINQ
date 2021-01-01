using System;
using System.Collections.Generic;
using System.Linq;
namespace practicalLINQ
{
    
    public interface Name
    {
        
        string First { get; }
        string Middle { get; }
        
        string Last { get; }
    }

    public  class OrderBy1
    {
        
        public static IEnumerable<Name> SortNames(IEnumerable<Name> names)
        {
            
            return names.OrderByDescending(_ => _.Last);
            
        }
        
    }
    public  class ThenBy1
    {
        
        public  IEnumerable<Name> SortNames(IEnumerable<Name> names)
        {
            
            return names.OrderBy(_ => _.Last).ThenBy(_ => _.First).ThenBy(_ => _.Middle);
           
        }
    }
    public class Program{
        public static void Main(){
            OrderBy1 o=new OrderBy1();
            ThenBy1 t=new ThenBy1();
            //o.SortNames(IEnumerator<Name> GetEnumerator(););
            o.GetType();
            t.GetType();
        }
    }
    public static class MethodSyntax1
    {
        public static IEnumerable<string> FilterAndSort(IEnumerable<string> inValues, string pattern)
        {
            return inValues
                
                .Where(_ => _.Contains(pattern))
                .OrderBy(_ => _);
        }
    }
}
