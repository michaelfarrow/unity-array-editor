using System;
using System.Collections.Generic;
public class TypeUtils
{

  static public bool IsSubclassOfRawGeneric(Type generic, Type toCheck)
  {
    while (toCheck != null && toCheck != typeof(object))
    {
      var cur = toCheck.IsGenericType ? toCheck.GetGenericTypeDefinition() : toCheck;
      if (generic == cur)
      {
        return true;
      }
      toCheck = toCheck.BaseType;
    }
    return false;
  }

  static public bool IsList(object o)
  {
    if (o == null) return false;
    // o is IList &&
    return o.GetType().IsGenericType &&
           o.GetType().GetGenericTypeDefinition().IsAssignableFrom(typeof(List<>));
  }

}
