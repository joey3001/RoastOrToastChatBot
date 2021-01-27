using System.Threading;
using System.Threading.Tasks;
using ConsultingBot.Model;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Dialogs;

namespace ConsultingBot.Dialogs
{
    public class ToastDialog : CancelAndHelpDialog
    {
        public ToastDialog(string dialogId) : base(dialogId)
        {
            AddDialog(new TextPrompt(nameof(TextPrompt) + "Toasted"));
            AddDialog(new ChoicePrompt(nameof(ChoicePrompt)));
            AddDialog(new ConfirmPrompt(nameof(ConfirmPrompt)));
            AddDialog(new WaterfallDialog(nameof(WaterfallDialog), new WaterfallStep[]
            {
                ProjectStepAsync
            }));

            // The initial child Dialog to run.
            InitialDialogId = nameof(WaterfallDialog);
        }

        // Step 1: Get Toasted 
        // Result is a Toast
        private async Task<DialogTurnResult> ProjectStepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var requestDetails = stepContext.Options is ConsultingRequestDetails
                ? stepContext.Options as ConsultingRequestDetails
                : new ConsultingRequestDetails();

            await stepContext.Context.SendActivityAsync(MessageFactory.Text("You're an amazing friend and programmer."), cancellationToken);
            return await stepContext.EndDialogAsync(null, cancellationToken);    
        }
    }
}
