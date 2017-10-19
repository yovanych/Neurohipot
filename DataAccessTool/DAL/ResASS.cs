using System;
using System.Collections;
using System.Collections.Generic;
using BusinessObjects;
using DataAccessTool.DAL;

namespace DALayer
{
    public class _ResASS : _ResAS, IEnumerable<_ResASS>, IEnumerator<_ResASS>
    {
        #region Constructores
        public _ResASS()
            : base( "ResASS" )
        { }
        #endregion

        #region Implementation of IEnumerable

        public IEnumerator<_ResASS> GetEnumerator()
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

        public _ResASS Current
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
