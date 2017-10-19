using System;
using System.Collections;
using System.Collections.Generic;
using BusinessObjects;
using DataAccessTool.DAL;

namespace DALayer
{
    public class _ResASC : _ResAS, IEnumerable<_ResASC>, IEnumerator<_ResASC>
    {
        public static string TableName = "ResASC";

        #region Constructores
        public _ResASC()
            : base(TableName)
        { }
        #endregion

        #region Implementation of IEnumerable

        public IEnumerator<_ResASC> GetEnumerator()
        {
            return this;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        #endregion

        #region Implementation of IDisposable

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Implementation of IEnumerator

        public void Reset()
        {
            throw new NotImplementedException();
        }

        public _ResASC Current
        {
            get { return this; }
        }

        object IEnumerator.Current
        {
            get { return Current; }
        }

        #endregion
        
    }
}
