using Easy_Password_Validator;
using Easy_Password_Validator.Models;

using System;
using System.Windows.Forms;

namespace Easy_Password_Validator_GUI
{
    public partial class PasswordValidatorForm : Form
    {
        private readonly PasswordRequirements requirements;

        public PasswordValidatorForm()
        {
            InitializeComponent();

            // Create default settings object
            requirements = new PasswordRequirements()
            {
                MinScore = 100
            };

            // Assign values to form
            numericUpDownLength.Value = requirements.MinLength;
            numericUpDownUnique.Value = requirements.MinUniqueCharacters;
            numericUpDownRepeat.Value = requirements.MaxRepeatSameCharacter;
            numericUpDownNeighboring.Value = requirements.MaxNeighboringCharacter;
            numericUpDownScore.Value = requirements.MinScore;

            if (requirements.RequireDigit)
                radioButtonDigitsY.Checked = true;
            else
                radioButtonDigitsN.Checked = true;

            if (requirements.RequireLowercase)
                radioButtonLowercaseY.Checked = true;
            else
                radioButtonLowercaseN.Checked = true;

            if (requirements.RequireUppercase)
                radioButtonUppercaseY.Checked = true;
            else
                radioButtonUppercaseN.Checked = true;

            if (requirements.RequirePunctuation)
                radioButtonPunctuationY.Checked = true;
            else
                radioButtonPunctuationN.Checked = true;

            // Add notes
            richTextBoxNotes.Text = "For most applications the following applies to score:" + Environment.NewLine + Environment.NewLine;
            richTextBoxNotes.Text += "< 0: Terrible password, never use" + Environment.NewLine;
            richTextBoxNotes.Text += "0 - 50: Bad password, use only when required" + Environment.NewLine;
            richTextBoxNotes.Text += "50 - 100: Ok password, avoid if possible" + Environment.NewLine;
            richTextBoxNotes.Text += "100 - 250: Good password, what you want" + Environment.NewLine;
            richTextBoxNotes.Text += "> 250: Amazing password, this is overkill";
        }

        private void UpdateScore()
        {
            // Validate password
            var validator = new PasswordValidatorService(requirements);
            var pass = false;

            if (textBoxPassword.TextLength > 0)
                pass = validator.TestAndScore(textBoxPassword.Text);

            // Output result
            if (validator.Score < progressBarScore.Minimum)
                progressBarScore.Value = progressBarScore.Minimum;
            else if (validator.Score > progressBarScore.Maximum)
                progressBarScore.Value = progressBarScore.Maximum;
            else
                progressBarScore.Value = validator.Score;

            richTextBoxDetails.Text = "";

            if (textBoxPassword.TextLength == 0)
                richTextBoxDetails.Text += "Please enter password to test." + Environment.NewLine;
            else if (pass)
                richTextBoxDetails.Text += $"Password passed with score: {validator.Score}" + Environment.NewLine;
            else
                richTextBoxDetails.Text += $"Password failed with score: {validator.Score}" + Environment.NewLine;

            richTextBoxDetails.Text += Environment.NewLine;

            if (pass == false)
                foreach (var message in validator.FailureMessages)
                    richTextBoxDetails.Text += message + Environment.NewLine;
        }

        private void TextBoxPassword_TextChanged(object sender, EventArgs e)
        {
            UpdateScore();
        }

        private void NumericUpDownLength_ValueChanged(object sender, EventArgs e)
        {
            requirements.MinLength = (int)Math.Floor(numericUpDownLength.Value);

            UpdateScore();
        }

        private void NumericUpDownUnique_ValueChanged(object sender, EventArgs e)
        {
            requirements.MinUniqueCharacters = (int)Math.Floor(numericUpDownUnique.Value);

            UpdateScore();
        }

        private void NumericUpDownRepeat_ValueChanged(object sender, EventArgs e)
        {
            requirements.MaxRepeatSameCharacter = (int)Math.Floor(numericUpDownRepeat.Value);

            UpdateScore();
        }

        private void NumericUpDownNeighboring_ValueChanged(object sender, EventArgs e)
        {
            requirements.MaxNeighboringCharacter = (int)Math.Floor(numericUpDownNeighboring.Value);

            UpdateScore();
        }

        private void NumericUpDownScore_ValueChanged(object sender, EventArgs e)
        {
            requirements.MinScore = (int)Math.Floor(numericUpDownScore.Value);

            UpdateScore();
        }

        private void RadioButtonDigitsY_CheckedChanged(object sender, EventArgs e)
        {
            requirements.RequireDigit = radioButtonDigitsY.Checked;

            UpdateScore();
        }

        private void RadioButtonDigitsN_CheckedChanged(object sender, EventArgs e)
        {
            requirements.RequireDigit = radioButtonDigitsY.Checked;

            UpdateScore();
        }

        private void RadioButtonLowercaseY_CheckedChanged(object sender, EventArgs e)
        {
            requirements.RequireLowercase = radioButtonLowercaseY.Checked;

            UpdateScore();
        }

        private void RadioButtonLowercaseN_CheckedChanged(object sender, EventArgs e)
        {
            requirements.RequireLowercase = radioButtonLowercaseY.Checked;

            UpdateScore();
        }

        private void RadioButtonUppercaseY_CheckedChanged(object sender, EventArgs e)
        {
            requirements.RequireUppercase = radioButtonUppercaseY.Checked;

            UpdateScore();
        }

        private void RadioButtonUppercaseN_CheckedChanged(object sender, EventArgs e)
        {
            requirements.RequireUppercase = radioButtonUppercaseY.Checked;

            UpdateScore();
        }

        private void RadioButtonPunctuationY_CheckedChanged(object sender, EventArgs e)
        {
            requirements.RequirePunctuation = radioButtonPunctuationY.Checked;

            UpdateScore();
        }

        private void RadioButtonPunctuationN_CheckedChanged(object sender, EventArgs e)
        {
            requirements.RequirePunctuation = radioButtonPunctuationY.Checked;

            UpdateScore();
        }
    }
}
