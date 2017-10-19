using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ExceptionHandler
{
    public enum ExceptionCode
    {
        ImportantFileNotFound
    }

    public class ExceptionHandler
    {
        private readonly ExceptionCode code;
        private object sender;
        public string Message
        {
            get { return ExcResource.ResourceManager.GetString(this.code.ToString()); }
        }

        public ExceptionHandler(ExceptionCode code, object sender)
        {
            this.code = code;
            this.sender = sender;
        }
    }
}
