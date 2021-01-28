<!-- START doctoc generated TOC please keep comment here to allow auto update -->
<!-- DON'T EDIT THIS SECTION, INSTEAD RE-RUN doctoc TO UPDATE -->
<!-- END doctoc generated TOC please keep comment here to allow auto update -->

# Roast or Toast ChatBot

#### A ChatBot Integrating LUIS Machine-Learning to Insult or Compliment a User Based on their Typed Utterance, 1/28/21

#### By Eric Endsley, Joe Nero, Eric Stratton, and Austin Schrader

**Table of Contents**  *generated with [DocToc](https://github.com/thlorenz/doctoc)*

* [🔥 Description 🥂](#-description-)
* [👀 Visit The Bot's Live Page](#-visit-the-bots-live-page)
* [🔧 Setup: Follow these instructions to download the software packages needed to run the bot locally.](#-setup-follow-these-instructions-to-download-the-software-packages-needed-to-run-the-bot-locally)
* [🛠️ Technologies Used](#%EF%B8%8F-technologies-used)
* [🐛 Known Bugs](#-known-bugs)
* [📫 Contact Information](#-contact-information)
* [📘 Legal](#-legal)
* [📖 Further Reading](#-further-reading)

## 🔥 Description 🥂

This is a ChatBot developed using the Microsoft Bot Framework & integrating LUIS machine-learning to determine whether a user will recieve a roast (insult) or a toast (compliment) from the bot. The roasts and toasts themselves are generated by querying one of two APIs which can be found in the technologies section. The bot uses LUIS language interpretation to ascertain whether A. A user has explicitly requested a roast or toast or B. A user is being hostile or friendly to the bot. A user who requests a roast or toast will recieve one, while a hostile or friendly user will receive a roast or toast respectively. 

## 👀 Visit The Bot's Live Page

As an alternative to running the bot locally and sending it utterances in the emulator, you may visit the bot's live page at the following link : 

[Roast or Toast Bot's Live Page](https://www.roastortoastchatbot.com/)

## 🔧 Setup: Follow these instructions to download the software packages needed to run the bot locally. 

### Install .NET Core

1. This program is written in C# and requires the .NET Core to run locally. For PC users click [this link](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.203-windows-x64-installer) and follow the installation instructions. 
For Mac users click [this link](https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-2.2.106-macos-x64-installer) and follow the installation instructions.

2. Install dotnet script by entering the following command in your terminal: "dotnet tool install -g dotnet-script"

3. Install the Microsoft Bot Framework Emulator at [This Link](https://github.com/Microsoft/BotFramework-Emulator/releases). Ensure that you download version 4.3.0 or greater. 

### Follow these instructions to clone & run the application locally using terminal commands. 

1. Enter the following command into your terminal program to clone the repo into a directory of your choice : 

          git clone https://github.com/joey3001/RoastOrToastChatBot.git

2. Run a bash terminal inside the directory /RoastOrToastBot in the newly cloned respository. 

3. In the terminal, type the command "dotnet run".

### Test the Bot Using Bot Framework Emulator

1. Open the Bot FrameWork Emulator Program. If you haven't installed it, you can do so [at this link.](https://github.com/Microsoft/BotFramework-Emulator/releases)

2. Select "Open Bot" on the home page of the emulator. 

3. Enter "http://localhost:3978/api/messages" for the Bot URL and press "Connect." 

4. Enjoy chatting with your bot! 

## 🛠️ Technologies Used

  * LUIS.ai Machine Learning
  * Microsoft Bot Framework 
  * Microsoft Azure
  * Microsoft Teams
  * Newtonsoft Json.Net
  * REST APIs 
    * [Insult Generator API](https://insultgenerator.docs.apiary.io/#)
    * [Complimentr API](https://complimentr.com/)
  * C# V7.3
  * .NET Core V2.2
  * dotnet script REPL
  * VSCode 
  * Git
  * Github 
  * Git Bash

## 🐛 Known Bugs

There are no known bugs at this time. 

## 📫 Contact Information

To ask questions or report a bug, contact : 

  * [Eric Endsley](mailto:eric.endsley4@gmail.com)
  * [Joseph Nero](mailto:josephnero111@gmail.com)
  * [Austin Schrader](mailto:eric.endsley4@gmail.com)
  * [Eric Stratton](mailto:strattonericj@gmail.com)

## 📘 Legal

[MIT License](https://choosealicense.com/licenses/mit/)

Copyright (c) 2020 Joseph Nero, Eric Endsley, Eric Stratton, Austin Schrader. 

## 📖 Further Reading 

  * [Bot Framework Documentation](https://docs.botframework.com)
  * [Bot Basics](https://docs.microsoft.com/azure/bot-service/bot-builder-basics?view=azure-bot-service-4.0)
  * [Dialogs](https://docs.microsoft.com/en-us/azure/bot-service/bot-builder-concept-dialog?view=azure-bot-service-4.0)
  * [Gathering Input Using Prompts](https://docs.microsoft.com/en-us/azure/bot-service/bot-builder-prompts?view=azure-bot-service-4.0&tabs=csharp)
  * [Activity processing](https://docs.microsoft.com/en-us/azure/bot-service/bot-builder-concept-activity-processing?view=azure-bot-service-4.0)
  * [Azure Bot Service Introduction](https://docs.microsoft.com/azure/bot-service/bot-service-overview-introduction?view=azure-bot-service-4.0)
  * [Azure Bot Service Documentation](https://docs.microsoft.com/azure/bot-service/?view=azure-bot-service-4.0)
  * [.NET Core CLI tools](https://docs.microsoft.com/en-us/dotnet/core/tools/?tabs=netcore2x)
  * [Azure CLI](https://docs.microsoft.com/cli/azure/?view=azure-cli-latest)
  * [Azure Portal](https://portal.azure.com)
  * [Language Understanding using LUIS](https://docs.microsoft.com/en-us/azure/cognitive-services/luis/)
  * [Channels and Bot Connector Service](https://docs.microsoft.com/en-us/azure/bot-service/bot-concepts?view=azure-bot-service-4.0)
