using System;
using System.Collections.Generic;
using System.Linq;

namespace Zivver.Candidate.Assignment.Models
{

    public enum DataToReturn
    {
        AccountId, 
        ConversationId,
        MessageId,
        SenderName,
        RecipientNames
    }

    public enum DataToFilter
    {
        Recipients,
        IsSent,
        IsZivverMessage,
        IsDraft,
    }

    public class ZIVVER
    {
        public List<Message> Messages { get; }

        public string AccountId { get; }

        public List<string> Recipients { get; }

        public string ConversationId { get; }

        public int MessageId { get; }

        public string FirstNameSender { get; }

        public string LastNameSender { get; }

        public string FullNameSender => string.Concat(FirstNameSender, " ", LastNameSender);

        public bool IsSent { get; }

        public bool IsZivverMessage { get; }

        public bool IsDraft { get; }

        public string Subject { get; }

        public string Body { get; }

        public ZIVVER(List<Message> messages)
        {
            Messages = messages;
        }

        public object GetCorrectDataFromMessage(List<DataToReturn> dataToReturn, List<DataToFilter> dataToFilters)
        {
            List<Message> nullCheckMessages = new List<Message>();
            
            // do null checks
            for (int i = 0; i < Messages.Count; i++)
            {
                bool nullValueFound = false;

                if (string.IsNullOrWhiteSpace(Messages[i].AccountId))
                {
                    nullValueFound = true;
                }
                if (Messages[i].Recipients == null)
                {
                    nullValueFound = true;
                }
                if (string.IsNullOrWhiteSpace(Messages[i].ConversationId))
                {
                    nullValueFound = true;
                }
                if (string.IsNullOrWhiteSpace(Messages[i].SenderFirstName))
                {
                    nullValueFound = true;
                }
                if (string.IsNullOrWhiteSpace(Messages[i].SenderLastName))
                {
                    nullValueFound = true;
                }
                if (string.IsNullOrWhiteSpace(Messages[i].Subject))
                {
                    nullValueFound = true;
                }
                if (string.IsNullOrWhiteSpace(Messages[i].Body))
                {
                    nullValueFound = true;
                }
                
                if(!nullValueFound)
                {
                    nullCheckMessages.Add(Messages[i]);
                }
            }

            List<Message> correctMessages = new List<Message>();

            for(int i = 0; i < nullCheckMessages.Count; i++)
            {
                if (dataToFilters.Any(d => d == DataToFilter.IsDraft))
                {
                    if (dataToFilters.Any(d => d == DataToFilter.IsZivverMessage))
                    {
                        if (dataToFilters.Any(d => d == DataToFilter.Recipients))
                        {
                            if (nullCheckMessages[i].IsDraft && nullCheckMessages[i].IsZivverMessage && nullCheckMessages[i].Recipients.Count > 0)
                            {
                                correctMessages.Add(nullCheckMessages[i]);
                            }
                        }
                        else
                        {
                            if (nullCheckMessages[i].IsDraft && nullCheckMessages[i].IsZivverMessage)
                            {
                                correctMessages.Add(nullCheckMessages[i]);
                            }
                        }
                    }
                    else if (dataToFilters.Any(d => d == DataToFilter.Recipients))
                    {
                        if (nullCheckMessages[i].IsDraft && nullCheckMessages[i].Recipients.Count > 0)
                        {
                            correctMessages.Add(nullCheckMessages[i]);
                        }
                    }
                    else
                    {
                        if (nullCheckMessages[i].IsDraft)
                        {
                            correctMessages.Add(nullCheckMessages[i]);
                        }
                    }
                }
                else if (dataToFilters.Any(d => d == DataToFilter.IsSent))
                {
                    if (dataToFilters.Any(d => d == DataToFilter.IsZivverMessage))
                    {
                        if (dataToFilters.Any(d => d == DataToFilter.Recipients))
                        {
                            if (nullCheckMessages[i].IsSent && nullCheckMessages[i].IsZivverMessage && nullCheckMessages[i].Recipients.Count > 0)
                            {
                                correctMessages.Add(nullCheckMessages[i]);
                            }
                        }
                        else
                        {
                            if (nullCheckMessages[i].IsSent && nullCheckMessages[i].IsZivverMessage)
                            {
                                correctMessages.Add(nullCheckMessages[i]);
                            }
                        }
                    }
                    else if (dataToFilters.Any(d => d == DataToFilter.Recipients))
                    {
                        if (nullCheckMessages[i].IsSent && nullCheckMessages[i].Recipients.Count > 0)
                        {
                            correctMessages.Add(nullCheckMessages[i]);
                        }
                    }
                    else
                    {
                        if (nullCheckMessages[i].IsSent)
                        {
                            correctMessages.Add(nullCheckMessages[i]);
                        }
                    }
                }
                else if (dataToFilters.Any(d => d == DataToFilter.IsZivverMessage))
                {
                    if (dataToFilters.Any(d => d == DataToFilter.Recipients))
                    {
                        if (nullCheckMessages[i].IsZivverMessage && nullCheckMessages[i].Recipients.Count > 0)
                        {
                            correctMessages.Add(nullCheckMessages[i]);
                        }
                    }
                    else
                    {
                        if (nullCheckMessages[i].IsZivverMessage)
                        {
                            correctMessages.Add(nullCheckMessages[i]);
                        }
                    }
                }
                else if (dataToFilters.Any(d => d == DataToFilter.Recipients))
                {
                    if (nullCheckMessages[i].Recipients.Count > 0)
                    {
                        correctMessages.Add(nullCheckMessages[i]);
                    }
                }
            }

            var messagesToReturn = new List<DataForAnalysis>();

            if(correctMessages.Count > 0)
            {
                for (int i = 0; i < correctMessages.Count; i++)
                {
                    var accountId = string.Empty;
                    var conversationId = string.Empty;
                    var messageId = 0;
                    var recipientNames = new List<string>();
                    var senderName = string.Empty;

                    foreach (var d in dataToReturn)
                    {
                        if (d == DataToReturn.AccountId)
                        {
                            accountId = correctMessages[i].AccountId;
                        }
                        else if (d == DataToReturn.ConversationId)
                        {
                            conversationId = correctMessages[i].ConversationId;
                        }
                        else if (d == DataToReturn.MessageId)
                        {
                            messageId = correctMessages[i].MessageId;
                        }
                        else if (d == DataToReturn.RecipientNames)
                        {
                            recipientNames = correctMessages[i].Recipients;
                        }
                        else if (d == DataToReturn.SenderName)
                        {
                            senderName = string.Concat(correctMessages[i].SenderFirstName + " " + correctMessages[i].SenderLastName);
                        }
                    }

                    var x = new DataForAnalysis(accountId, conversationId, messageId, recipientNames, senderName);
                    messagesToReturn.Add(x);
                }
            }

            return messagesToReturn;
        }
    }

    public class DataForAnalysis
    {
        public string AccountId { get; }
        public string ConversationId { get; }
        public int MessageId { get; }
        public List<string> RecipientNames { get; }
        public string SenderName { get; }

        public DataForAnalysis(string accountId, string conversationId, int messageId, List<string> recipientNames, string senderName)
        {
            AccountId = accountId;
            ConversationId = conversationId;
            MessageId = messageId;
            RecipientNames = recipientNames;
            SenderName = senderName;
        }
    }
}
