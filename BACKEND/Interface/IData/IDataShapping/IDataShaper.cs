﻿using System.Collections.Generic;
using System.Dynamic;

namespace BACKEND.Interface.IData.IDataShapping
{
    public interface IDataShaper<T>
    {
        IEnumerable<ExpandoObject> ShapeData(IEnumerable<T> entities, string fieldsString);
        ExpandoObject ShapeData(T entity, string fieldsString);
    }
}
