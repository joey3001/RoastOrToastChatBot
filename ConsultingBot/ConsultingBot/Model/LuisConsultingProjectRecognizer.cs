using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using ConsultingBot.Model;
using Microsoft.Bot.Builder;
using Microsoft.Bot.Builder.AI.Luis;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Recognizers.Text;
using Microsoft.Recognizers.Text.DateTime;
using Newtonsoft.Json.Linq;

namespace ConsultingBot
{
    public class LuisConsultingProjectRecognizer 
    {
        public static async Task<ConsultingRequestDetails> ExecuteQuery(IConfiguration configuration, ILogger logger, ITurnContext turnContext, CancellationToken cancellationToken)
        {
            var result = new ConsultingRequestDetails();

            try
            {
                // Create the LUIS settings from configuration.
                var luisApplication = new LuisApplication(
                    configuration["LuisAppId"],
                    configuration["LuisAPIKey"],
                    "https://" + configuration["LuisAPIHostName"]
                );

                var recognizer = new LuisRecognizer(luisApplication);

                // The actual call to LUIS
                var recognizerResult = await recognizer.RecognizeAsync(turnContext, cancellationToken);
                var (intent, score) = recognizerResult.GetTopScoringIntent();

                // Now based on the intent, fill in the result as best we can
                switch (intent)
                {
                    case "Toast":
                        {
                            result.intent = Intent.Toast;
                            break;
                        }
                    case "Roast":
                        {
                            result.intent = Intent.Roast;
                            break;
                        }
                    default:
                        {
                            result.intent = Intent.Unknown;
                            break;
                        }
                }
            }
            catch (Exception e)
            {
                logger.LogWarning($"LUIS Exception: {e.Message} Check your LUIS configuration.");
            }

            return result;
        }

    }
}
