using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace IntroWinForms.Exceptions
{
    [Serializable]
    class NumberOfArgsException : System.Exception, ISerializable
    {
        public int NumberOfArgs { get; set; }

        public NumberOfArgsException(int numberOfArgs)
        {
            NumberOfArgs = numberOfArgs;
            this.HelpLink = "http://google.com";
        }

        public NumberOfArgsException(int numberOfArgs, string message) : base(message)
        {
            NumberOfArgs = numberOfArgs;
            this.HelpLink = "http://google.com";
        }


        public NumberOfArgsException(int numberOfArgs, string message, Exception exception) : base(message, exception)
        {
            NumberOfArgs = numberOfArgs;
            this.HelpLink = "http://google.com";
        }

        protected NumberOfArgsException(SerializationInfo info, StreamingContext context)
        {
            NumberOfArgs = (int)info.GetValue("NumberOfArgs", typeof(int));
        }

        public override void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("NumberOfArgs", NumberOfArgs, typeof(int));
        }

    }
}