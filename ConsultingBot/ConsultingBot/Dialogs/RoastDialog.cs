using System.Threading;
using System.Threading.Tasks;
using RoastOrToastBot.Model;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.Dialogs;

namespace RoastOrToastBot.Dialogs
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
                ProjectStepAsync
            }));

            // The initial child Dialog to run.
            InitialDialogId = nameof(WaterfallDialog);
        }

        // Step 1: Get Roasted 
        // Result is a Roast
        private async Task<DialogTurnResult> ProjectStepAsync(WaterfallStepContext stepContext, CancellationToken cancellationToken)
        {
            var requestDetails = stepContext.Options is RoastOrToastRequestDetails
                ? stepContext.Options as RoastOrToastRequestDetails
                : new RoastOrToastRequestDetails();

            var insult = InsultApiResult.GetInsults();
                
            await stepContext.Context.SendActivityAsync(MessageFactory.Text(insult), cancellationToken);
            return await stepContext.EndDialogAsync(null, cancellationToken);            
        }
    }
}
