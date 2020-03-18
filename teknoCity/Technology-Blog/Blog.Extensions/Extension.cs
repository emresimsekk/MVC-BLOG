using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Extensions
{
    public static class Extension
    {
        public static  T Changer<T>(this object source)
        {
            //hedef
            T target = Activator.CreateInstance<T>();
            // Kaynak
            Type resource = source.GetType();

            PropertyInfo[] resourceProps = resource.GetProperties();
            PropertyInfo[] targetProps = typeof(T).GetProperties();

            foreach (PropertyInfo pi in resourceProps)
            {
                object value = pi.GetValue(source);
                PropertyInfo tp = targetProps.FirstOrDefault(x => x.Name == pi.Name);
                if (tp!=null)
                {
                    tp.SetValue(target, value);
                }
                

            }
            return target;
        }
    }
}
