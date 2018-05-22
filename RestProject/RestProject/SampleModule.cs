using System;
namespace RestProject
{
    public class SampleModule : Nancy.NancyModule
    {
        public SampleModule(){

            Get["/"] = _ => {
                return "HelloWorld!";
            };
        }
    }
}
