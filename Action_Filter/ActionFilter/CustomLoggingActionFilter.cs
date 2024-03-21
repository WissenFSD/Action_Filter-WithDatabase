using Microsoft.AspNetCore.Mvc.Filters;

namespace Action_Filter.ActionFilter
{
    public class CustomLoggingActionFilter:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            // Action Filter, bir action'a girilmeden önce ve girildikten sonra çalışır.

            //OnActionExecuting metodu  : action'dan önce 
            //OnActionExecuted metodu    : actiondan sonra çalışır.


            string controller = context.RouteData.Values["controller"].ToString();
            string action = context.RouteData.Values["action"].ToString();

            // Bu metotların çalışması için, Actionların üstüne yada controllerin üstüne bu action tanımları yapılması gerekmektedir.

            //string controller = context.RouteData.Values.Values[0].;




            // string action = context.RouteData.Values[1];
            StreamWriter wri = new StreamWriter("c:\\log\\log.txt", true);
            wri.WriteLine(controller+" içerisindeki "+action+" isimli metot çağırıldı");
            wri.Close();
            base.OnActionExecuting(context);
        }
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            base.OnActionExecuted(context);
        }
    }
}
