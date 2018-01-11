using System.Threading.Tasks;
using OrchardCore.Scripting;
using OrchardCore.Workflows.Models;

namespace OrchardCore.Workflows.Services
{
    public interface IWorkflowScriptEvaluator
    {
        Task<T> EvaluateAsync<T>(WorkflowExpression<T> expression, WorkflowContext workflowContext, params IGlobalMethodProvider[] scopedMethodProviders);
    }
}
