using System.Threading;
using System.Threading.Tasks;
using RoastOrToastBot.Model;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Dialogs;

namespace RoastOrToastBot.Dialogs
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
            var requestDetails = stepContext.Options is RoastOrToastRequestDetails
                ? stepContext.Options as RoastOrToastRequestDetails
                : new RoastOrToastRequestDetails();

            string compliment = ComplimentApiResult.GetCompliments(); // MAKE API CALL USING APIHELPER AND CLASS

            await stepContext.Context.SendActivityAsync(MessageFactory.Text(compliment), cancellationToken);
            return await stepContext.EndDialogAsync(null, cancellationToken);    
        }
    }
}
