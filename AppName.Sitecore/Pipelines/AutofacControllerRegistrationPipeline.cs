using Autofac.Integration.Mvc;
using AppName.Core.Infrastructure;
using Sitecore.Pipelines;
using System.Web.Mvc;

namespace AppName.SCCMS.Pipelines
{
    public class AutofacControllerRegistrationPipeline
    {
        public void Process(PipelineArgs args)
        {
            PenContext.Initialize();

            var cdr = new ChainedMvcResolver(
                new AutofacDependencyResolver(PenContext.Current.IOCContainerManager.Container),
                DependencyResolver.Current);

            DependencyResolver.SetResolver(cdr);

            var controllerFactory = new AutofacControllerFactory(PenContext.Current.IOCContainerManager.Container);

            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }
    }
}
