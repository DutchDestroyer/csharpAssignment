using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Zivver.Candidate.Assignment.Models;
using Message = Zivver.Candidate.Assignment.Models.Message;

namespace Zivver.Candidate.Assignment
{
    public partial class Form1 : Form
    {
        private List<DataToFilter> _filterProperties;
        private List<DataToReturn> _returnProperties;

        private readonly List<Message> _messages;

        public Form1(string nameOfParticipant, List<Message> messages)
        {
            _messages = messages;
            _filterProperties = new List<DataToFilter>();
            InitializeComponent();
            label2.Text += string.Concat(string.IsNullOrWhiteSpace(nameOfParticipant) ? "<insert name>" : nameOfParticipant, ",");
            this.label1.MaximumSize = new Size(this.Width - 50, 0);
            label1.AutoSize = true;
            var strSize = this.CreateGraphics().MeasureString("Welcome to the Zivver Assignment for C# developers. This assignment is used to give us an estimation of your programming capabilities. This application has been build to make an API request to get messages from the ZIVVER backend. Once the data has been received, the application performs some logic. This logic can be divided into three steps: The first step is checking whether any properties of a message is null. In that case, the message should be ignored, because none of those properties should ever be null. The second step is to filter messages based on the values of certain properties, and the third step is to determine what data of these messages should be provided to the user of the application.The current implementation is far from perfect, so we would like you to improve the current code base. Good luck!", this.label1.Font);            
            this.label1.Height = (int)(Math.Round(strSize.Height, 0));
        }

        private void IsDraft_CheckedChanged(object sender, EventArgs e)
        {
            if(sender is CheckBox checkBox)
            {
                UpdateFilterProperties(checkBox, DataToFilter.IsDraft);
            }
        }

        private void IsZivverMessage_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                UpdateFilterProperties(checkBox, DataToFilter.IsZivverMessage);
            }
        }

        private void IsSent_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                UpdateFilterProperties(checkBox, DataToFilter.IsSent);
            }
        }

        private void Recipients_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                UpdateFilterProperties(checkBox, DataToFilter.Recipients);
            }
        }

        private void AccountId_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                UpdateReturnProperties(checkBox, Models.DataToReturn.AccountId);
            }
        }

        private void ConversationId_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                UpdateReturnProperties(checkBox, Models.DataToReturn.ConversationId);
            }
        }

        private void MessageId_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                UpdateReturnProperties(checkBox, Models.DataToReturn.MessageId);
            }
        }

        private void SenderName_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                UpdateReturnProperties(checkBox, Models.DataToReturn.SenderName);
            }
        }

        private void RecipientNames_CheckedChanged(object sender, EventArgs e)
        {
            if (sender is CheckBox checkBox)
            {
                UpdateReturnProperties(checkBox, Models.DataToReturn.RecipientNames);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            new ZIVVER(_messages).GetCorrectDataFromMessage(_returnProperties, _filterProperties);
        }

        private void UpdateFilterProperties(CheckBox checkBox, DataToFilter filterProperty)
        {
            if (checkBox.Checked)
            {
                _filterProperties.Add(filterProperty);
            }
            else
            {
                _filterProperties.Remove(filterProperty);
            }
        }

        private void UpdateReturnProperties(CheckBox checkBox, DataToReturn returnProperty)
        {
            if (checkBox.Checked)
            {
                _returnProperties.Add(returnProperty);
            }
            else
            {
                _returnProperties.Remove(returnProperty);
            }
        }

    }
}
