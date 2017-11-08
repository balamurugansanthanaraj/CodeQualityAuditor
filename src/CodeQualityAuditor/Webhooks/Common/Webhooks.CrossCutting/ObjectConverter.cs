using System;
using Newtonsoft.Json.Linq;

namespace Webhooks.CrossCutting
{
    public class ObjectConverter
    {
        public static T GetDataOrDefault<T>(object data)
            where T : class
        {
            switch (data)
            {
                case null:
                    return default(T);
                case JToken token when !typeof(JToken).IsAssignableFrom(typeof(T)):
                    try
                    {
                        var tempData = token.ToObject<T>();
                        return tempData;
                    }
                    catch (Exception ex)
                    {
                        //string msg = string.Format(CultureInfo.CurrentCulture, ReceiverResources.GetDataOrDefault_Failure, context.Data.GetType(), typeof(T), ex.Message);
                        //context.RequestContext.Configuration.DependencyResolver.GetLogger().Error(msg, ex);
                        return default(T);
                    }
                    default:
                    return data as T;
            }
        }
    };
}
