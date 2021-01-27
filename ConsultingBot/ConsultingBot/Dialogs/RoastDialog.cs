using System.Threading;
using System.Threading.Tasks;
using ConsultingBot.Model;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Dialogs;

namespace ConsultingBot.Dialogs
{
    public class RoastDialog : CancelAndHelpDialog
    {
        public RoastDialog(string dialogId) : base(dialogId)
        {
            AddDialog(new TextPrompt(nameof(TextPrompt) + "Roasted"));
            AddDialog(new ChoicePrompt(nameof(ChoicePrompt)));
            AddDialog(new ConfirmPrompt(nameof(ConfirmPrompt)));
            AddDialog(new WaterfallDialog(nameof(WaterfallDialog), new WaterfallStep[]
            {
                ProjectStepAsync,
                FinalStepAsync,
            }));

            // The initial child Dialog to run.
            InitialDialogId = nameof(WaterfallDialog);
        }

        // Step 1: Get Roasted 
        // Result is a Roast
        private async Task<DialogTurnResult> ProjectStepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var requestDetails = stepContext.Options is ConsultingRequestDetails
                ? stepContext.Options as ConsultingRequestDetails
                : new ConsultingRequestDetails();

            // List<ConsultingProject> result = await ResolveProject(requestDetails.projectName);
            return await stepContext.PromptAsync(nameof(TextPrompt) + "Roasted", new PromptOptions
            {
                Prompt = MessageFactory.Text("You'll never get your chatbot to work"),
            }, cancellationToken);
        }
        
        private async Task<DialogTurnResult> FinalStepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            return await stepContext.EndDialogAsync(null, cancellationToken);
        }
    }
}
