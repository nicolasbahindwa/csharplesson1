using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace CustomException
{
    class customeExceptionDemo
    {
        public static void Main()
        {
            try
            {

                throw new userAlredyLoggedInException("user already logged , no diplicated session allowed");
            }
            catch (Exception ex)
            { 
            
            }

        }
    }

    [Serializable]
    public class userAlredyLoggedInException:Exception
    {
        public userAlredyLoggedInException(string Message)
            :base()
        {

        }
        public userAlredyLoggedInException()
            :base()
        {
                
        }
        public userAlredyLoggedInException(string message, Exception innerException) 
            :base( message, innerException)
        {

        }
        public userAlredyLoggedInException(SerializationInfo info, StreamingContext contect)
            :base(info,contect)
        {

        }

    }


}
